using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.OrderDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task CreateAsync(OrderPostDTO orderDTO)
        {
            Table table = await _unitOfWork.TableRepository.GetAsync(x=>x.Id == orderDTO.TableId, "Status");
            if (table.Status.Status == "Full")
            {
                throw new AlreadyFullException($"{table.Number} is full. Please select other table!");
            }
            if (await _unitOfWork.ReservationRepository.IsReservedAsync(table.Id))
            {
                if (await _unitOfWork.ReservationRepository.IsExistAsync(x => x.TableId == orderDTO.TableId && x.ClientName == orderDTO.ClientName && x.IsDeleted == false))
                {
                    if (await _unitOfWork.OrderRepository.IsExistAsync(x => x.TableId == table.Id && x.IsDeleted == false))
                        throw new AlreadyExistException($"Order is already exist in {orderDTO.TableId} Table. Please select other table!");
                    Order order = _mapper.Map<Order>(orderDTO);
                    table.StatusId = 5;
                    Reservation reservation = await _unitOfWork.ReservationRepository.GetAsync(x => x.TableId == table.Id && x.IsDeleted == false);
                    reservation.IsDeleted = true;
                    await _unitOfWork.OrderRepository.InsertAsync(order);
                    await _unitOfWork.CommitAsync();
                }
                else
                {
                    throw new TableIsReservedException($"{orderDTO.TableId} is Reserved or Client Name Invalid.Please select other table");
                }
            }
            else
            {
                if (await _unitOfWork.OrderRepository.IsExistAsync(x => x.TableId == table.Id && x.IsDeleted == false))
                    throw new AlreadyExistException($"Order is already exist in {orderDTO.TableId} Table. Please select other table!");
                Order order = _mapper.Map<Order>(orderDTO);
                table.StatusId = 5;
                await _unitOfWork.OrderRepository.InsertAsync(order);
                await _unitOfWork.CommitAsync();
            }
            
        }

        public async Task Delete(int id)
        {
            Order order = await _unitOfWork.OrderRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            if (order == null)
            {
                throw new NotFoundException("Order doesn't exist in this Id");
            }
            Table table = await _unitOfWork.TableRepository.GetAsync(x => x.Id == order.TableId && x.IsDeleted == false);
            if (await _unitOfWork.ReservationRepository.IsReservedAsync(table.Id))
            {
                Reservation reservation = await _unitOfWork.ReservationRepository.GetAsync(x=>x.TableId == table.Id && x.IsDeleted == false);
                reservation.IsDeleted = true;
            }
            else
            {
                table.StatusId = 3;
            }
            order.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, OrderEditDTO orderDTO)
        {
            Order order = await _unitOfWork.OrderRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            Food food = await _unitOfWork.FoodRepository.GetAsync(x=>x.Id == orderDTO.FoodId && x.IsDeleted == false);
            if (order == null)
            {
                throw new Exception("Order doesn't exist in this Id");
            }
            if (await _unitOfWork.FoodOrderRepository.IsExistAsync(x=>x.OrderId == id && x.FoodId==orderDTO.FoodId && x.IsDeleted== false))
            {
                FoodOrder foodOrder = await _unitOfWork.FoodOrderRepository.GetAsync(x => x.OrderId == id && x.FoodId==orderDTO.FoodId && x.IsDeleted == false);
                foodOrder.FoodAmount++;
                order.TotalPrice += food.Price;
            }
            else
            {
                FoodOrder foodOrder = new FoodOrder();
                foodOrder.OrderId = id;
                foodOrder.FoodId = orderDTO.FoodId;
                foodOrder.FoodAmount = 1;
                order.TotalPrice += food.Price;
                await _unitOfWork.FoodOrderRepository.InsertAsync(foodOrder);
            }
            
            await _unitOfWork.CommitAsync();
        }

        public async Task<OrderGetAllDTO> GetAllAsync()
        {
            List<Order> entities = await _unitOfWork.OrderRepository.GetAllAsync(x => x.IsDeleted == false, "FoodOrders.Food", "Staff" , "Table");
            
            List<OrderGetDTO> orders = new List<OrderGetDTO>();
            foreach (var item in entities)
            {
                orders.Add(_mapper.Map<OrderGetDTO>(item));
            }
            int count = await _unitOfWork.OrderRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            OrderGetAllDTO orderGetAll = new OrderGetAllDTO
            {
                Orders = orders,
                Count = count
            };
            return orderGetAll;
        }

        public async Task<PagenatedListDTO<OrderGetDTO>> GetAllFilteredAsync(int page, int pageSize)
        {
            List<Order> orders = await _unitOfWork.OrderRepository.GetAllPagenatedAsync(x => x.IsDeleted == false, page, pageSize, "FoodOrders.Food", "Staff", "Table");
            List<OrderGetDTO> hallsListDto = new List<OrderGetDTO>();
            foreach (var item in orders)
            {
                _mapper.Map<OrderGetDTO>(item);
                hallsListDto.Add(_mapper.Map<OrderGetDTO>(item));
            }
            int count = await _unitOfWork.OrderRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            PagenatedListDTO<OrderGetDTO> pagenatedHalls = new PagenatedListDTO<OrderGetDTO>(hallsListDto, page, count, pageSize);
            return pagenatedHalls;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            Order order = await _unitOfWork.OrderRepository.GetAsync(x => x.Id == id && x.IsDeleted == false, "FoodOrders.Food");
            if (order == null) throw new NotFoundException("Order doesn't exist in this Id");
            TEntity entity = _mapper.Map<TEntity>(order);
            return entity;
        }

        public async Task<TEntity> GetByTableAsync<TEntity>(int id)
            {
            Order order = await _unitOfWork.OrderRepository.GetAsync(x => x.TableId == id && x.IsDeleted==false, "FoodOrders.Food");
            if (order == null) throw new NotFoundException("Order doesn't exist in this Id");
            TEntity entity = _mapper.Map<TEntity>(order);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.OrderRepository.IsExistAsync(x => x.Id == id);
        }
    }
}
