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
            Table table = await _unitOfWork.TableRepository.GetAsync(x=>x.Number == orderDTO.TableId, "Status");
            if (table.Status.Status == "Full")
            {
                throw new AlreadyFullException($"{table.Number} is full. Please select other table!");
            }
            if (await _unitOfWork.ReservationRepository.IsReservedAsync(table.Id))
            {
                throw new TableIsReservedException($"{orderDTO.TableId} is Reserved. Please select other table!");
            }
            if (await _unitOfWork.OrderRepository.IsExistAsync(x => x.TableId == table.Id))
                throw new NotFoundException($"{orderDTO.TableId} not Found. Please select other table!");
            Order order = _mapper.Map<Order>(orderDTO);
            await _unitOfWork.OrderRepository.InsertAsync(order);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
            Order order = await _unitOfWork.OrderRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            if (order == null)
            {
                throw new NotFoundException("table doesn't exist in this Id");
            }
            order.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, OrderEditDTO orderDTO)
        {
            Order order = await _unitOfWork.OrderRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            if (order == null)
            {
                throw new Exception("Table doesn't exist in this Id");
            }
            _mapper.Map<OrderEditDTO, Order>(orderDTO, order);
            foreach (var item in orderDTO.Foods)
            {
                order.TotalPrice += item.Price;
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<OrderGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<Order> entities = await _unitOfWork.OrderRepository.GetAllAsync(x => x.IsDeleted == false, "FoodOrders.Food");
            List<TEntity> orders = new List<TEntity>();
            foreach (var item in entities)
            {
                orders.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.OrderRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            OrderGetAllDTO<TEntity> productTypeGetAll = new OrderGetAllDTO<TEntity>
            {
                Orders = orders,
                Count = count
            };
            return productTypeGetAll;
        }

        public async Task<PagenatedListDTO<OrderGetDTO>> GetAllFilteredAsync(int page, int pageSize)
        {
            List<Order> orders = await _unitOfWork.OrderRepository.GetAllPagenatedAsync(x => x.IsDeleted == false, page, pageSize, "FoodOrders.Food");
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
            Order order = await _unitOfWork.OrderRepository.GetAsync(x => x.Id == id);
            if (order == null) throw new NotFoundException("Order doesn't exist in this Id");
            TEntity entity = _mapper.Map<TEntity>(order);
            return entity;
        }

        public async Task<TEntity> GetByTableAsync<TEntity>(int id)
        {
            Order order = await _unitOfWork.OrderRepository.GetAsync(x => x.TableId == id);
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
