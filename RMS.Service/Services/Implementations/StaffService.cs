using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs.StaffDTO;
using RMS.Service.Exceptions;
using RMS.Service.HelperServices.Interfaces;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class StaffService : IStaffService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRandomGenerator _randomGenerator;

        public StaffService(IUnitOfWork unitOfWork, IMapper mapper, IRandomGenerator randomGenerator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _randomGenerator = randomGenerator;
        }
        public async Task<StaffCreateReturnDTO> CreateAsync(StaffPostDTO staffDTO)
        {
            Staff staff = _mapper.Map<Staff>(staffDTO);
            var staffs = await _unitOfWork.StaffRepository.GetAllAsync(x=>x.IsDeleted==false);
            int pin = _randomGenerator.Generate(4);
            foreach (var item in staffs)
            {
                if (pin == item.Pin)
                {
                    pin = _randomGenerator.Generate(4);
                }
            }
            staff.Pin = pin;
            await _unitOfWork.StaffRepository.InsertAsync(staff);
            await _unitOfWork.CommitAsync();
            StaffCreateReturnDTO staffCreateReturnDTO = _mapper.Map<StaffCreateReturnDTO>(staff);
            return staffCreateReturnDTO;
        }

        public async Task Delete(int id)
        {
            Staff staff = await _unitOfWork.StaffRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            if (staff==null)
                throw new NotFoundException("Staff doesn't exist in this Id");
            staff.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, StaffPostDTO staffDTO)
        {
            Staff staff = await _unitOfWork.StaffRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            if(staff==null) throw new NotFoundException("Staff doesn't exist in this Id");
            _mapper.Map<StaffPostDTO, Staff>(staffDTO, staff);
            await _unitOfWork.CommitAsync();
        }

        public async Task<StaffGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<Staff> staff = await _unitOfWork.StaffRepository.GetAllAsync(x => x.IsDeleted == false,"StaffType");
            List<TEntity> staffGetAllDTO = new List<TEntity>();
            foreach (var item in staff)
            {
                staffGetAllDTO.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.StaffRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            StaffGetAllDTO<TEntity> staffGetAll = new StaffGetAllDTO<TEntity>
            {
                Staffs = staffGetAllDTO,
                Count = count
            };
            return staffGetAll;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            Staff staff = await _unitOfWork.StaffRepository.GetAsync(x => x.Id == id && x.IsDeleted == false, "StaffType");
            if (staff == null) throw new NotFoundException("Staff doesn't exist in this Id");
            TEntity entity = _mapper.Map<TEntity>(staff);
            return entity;
        }

        public async Task<TEntity> GetByNameAsync<TEntity>(string name)
        {
            Staff staff = await _unitOfWork.StaffRepository.GetAsync(x => x.FullName == name && x.IsDeleted == false, "StaffType");
            if (staff == null) throw new NotFoundException("Staff doesn't exist in this Id");
            TEntity entity = _mapper.Map<TEntity>(staff);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.StaffRepository.IsExistAsync(x => x.Id == id && x.IsDeleted == false);
        }
    }
}
