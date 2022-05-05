using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs.CategoryDTO;
using RMS.Service.DTOs.OrderTypeDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class OrderTypeService: IOrderTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task CreateAsync(OrderTypePostDTO orderTypeDTO)
        {
            if (await _unitOfWork.OrderTypeRepository.IsExistAsync(x => x.Name == orderTypeDTO.Name))
                throw new AlreadyExistException($"{orderTypeDTO.Name} is already exist. Please change name!");
            OrderType orderType = new OrderType { Name = orderTypeDTO.Name };
            await _unitOfWork.OrderTypeRepository.InsertAsync(orderType);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
            OrderType orderType = await _unitOfWork.OrderTypeRepository.GetAsync(x => x.Id == id);
            if (orderType == null)
            {
                throw new Exception("OrderType doesn't exist in this Id");
            }
            orderType.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, OrderTypePostDTO orderTypeDTO)
        {
            OrderType orderType = await _unitOfWork.OrderTypeRepository.GetAsync(x => x.Id == id);
            if (orderType == null)
            {
                throw new Exception("OrderType doesn't exist in this Id");
            }
            if (await _unitOfWork.OrderTypeRepository.IsExistAsync(x => x.Id != id && x.Name == orderTypeDTO.Name))
            {
                throw new Exception("OrderType is Already Exist with this Name");
            }
            _mapper.Map<OrderTypePostDTO, OrderType>(orderTypeDTO, orderType);
            await _unitOfWork.CommitAsync();
        }

        public async Task<OrderTypeGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<OrderType> orderType = await _unitOfWork.OrderTypeRepository.GetAllAsync(x => x.IsDeleted == false);
            List<TEntity> orderTypeGetAllDTO = new List<TEntity>();
            foreach (var item in orderType)
            {
                orderTypeGetAllDTO.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.OrderTypeRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            OrderTypeGetAllDTO<TEntity> orderTypeGetAll = new OrderTypeGetAllDTO<TEntity>
            {
                OrderTypes = orderTypeGetAllDTO,
                Count = count
            };
            return orderTypeGetAll;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            OrderType orderType = await _unitOfWork.OrderTypeRepository.GetAsync(x => x.Id == id && x.IsDeleted==false);
            if (orderType == null) throw new Exception("OrderType doesn't exist in this Id");

            TEntity entity = _mapper.Map<TEntity>(orderType);
            return entity;
        }
        public async Task<TEntity> GetByNameAsync<TEntity>(string name)
        {
            OrderType orderType = await _unitOfWork.OrderTypeRepository.GetAsync(x => x.Name == name && x.IsDeleted == false);
            if (orderType == null) throw new Exception("OrderType doesn't exist in this name");

            TEntity entity = _mapper.Map<TEntity>(orderType);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.OrderTypeRepository.IsExistAsync(x => x.Id == id && x.IsDeleted == false);
        }
    }
}
