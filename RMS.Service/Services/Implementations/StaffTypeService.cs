using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs.StaffTypeDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class StaffTypeService : IStaffTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StaffTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsync(StaffTypePostDTO staffTypeDTO)
        {
            if (await _unitOfWork.StaffTypeRepository.IsExistAsync(x => x.Name == staffTypeDTO.Name))
                throw new AlreadyExistException($"{staffTypeDTO.Name} is already exist. Please change name!");
            StaffType staffType = new StaffType { Name = staffTypeDTO.Name };
            await _unitOfWork.StaffTypeRepository.InsertAsync(staffType);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
            StaffType staffType = await _unitOfWork.StaffTypeRepository.GetAsync(x => x.Id == id);
            if (staffType == null)
            {
                throw new NotFoundException("StaffType doesn't exist in this Id");
            }
            staffType.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, StaffTypePostDTO staffTypeDTO)
        {
            StaffType staffType = await _unitOfWork.StaffTypeRepository.GetAsync(x => x.Id == id);
            if (staffType == null)
            {
                throw new Exception("StaffType doesn't exist in this Id");
            }
            if (await _unitOfWork.StaffTypeRepository.IsExistAsync(x => x.Id != id && x.Name == staffTypeDTO.Name))
            {
                throw new Exception("StaffType is Already Exist with this Name");
            }
            _mapper.Map<StaffTypePostDTO, StaffType>(staffTypeDTO, staffType);
            await _unitOfWork.CommitAsync();
        }

        public async Task<StaffTypeGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<StaffType> staffType = await _unitOfWork.StaffTypeRepository.GetAllAsync(x => x.IsDeleted == false);
            List<TEntity> staffTypeGetAllDTO = new List<TEntity>();
            foreach (var item in staffType)
            {
                staffTypeGetAllDTO.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.StaffTypeRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            StaffTypeGetAllDTO<TEntity> staffTypeGetAll = new StaffTypeGetAllDTO<TEntity>
            {
                StaffTypes = staffTypeGetAllDTO,
                Count = count
            };
            return staffTypeGetAll;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            StaffType staffType = await _unitOfWork.StaffTypeRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            if (staffType == null) throw new Exception("StaffType doesn't exist in this Id");

            TEntity entity = _mapper.Map<TEntity>(staffType);
            return entity;
        }

        public async Task<TEntity> GetByNameAsync<TEntity>(string name)
        {
            StaffType staffType = await _unitOfWork.StaffTypeRepository.GetAsync(x => x.Name == name && x.IsDeleted == false);
            if (staffType == null) throw new Exception("StaffType doesn't exist in this Name");

            TEntity entity = _mapper.Map<TEntity>(staffType);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.StaffTypeRepository.IsExistAsync(x => x.Id == id && x.IsDeleted == false);
        }
    }
}
