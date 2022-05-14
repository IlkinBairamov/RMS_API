using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.HallDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class HallService : IHallService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HallService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task CreateAsync(HallPostDTO hallDTO)
        {
            if (await _unitOfWork.HallRepository.IsExistAsync(x => x.Name == hallDTO.Name))
                throw new AlreadyExistException($"{hallDTO.Name} is already exist. Please change name!");
            Hall hall = new Hall { Name = hallDTO.Name };
            await _unitOfWork.HallRepository.InsertAsync(hall) ;
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
            Hall hall = await _unitOfWork.HallRepository.GetAsync(x => x.Id == id);
            if (hall == null)
            {
                throw new Exception("Hall doesn't exist in this Id");
            }
            hall.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, HallPostDTO hallDTO)
        {
            Hall hall = await _unitOfWork.HallRepository.GetAsync(x => x.Id == id);
            if (hall == null)
            {
                throw new Exception("Hall doesn't exist in this Id");
            }
            if (await _unitOfWork.HallRepository.IsExistAsync(x=>x.Id!=id && x.Name == hallDTO.Name))
            {
                throw new Exception("Hall is Already Exist with this Name");
            }
            _mapper.Map<HallPostDTO,Hall>(hallDTO,hall);
            await _unitOfWork.CommitAsync();
        }

        public async Task<HallGetAllDTO> GetAllAsync()
        {
            List<Hall> entities = await _unitOfWork.HallRepository.GetAllAsync(x=>x.IsDeleted==false,"Tables.Hall");
            List<HallGetDTO> halls = new List<HallGetDTO>();
            foreach (var item in entities)
            {
                halls.Add(_mapper.Map<HallGetDTO>(item));
            }
            int count = await _unitOfWork.HallRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            HallGetAllDTO hallsGetAll = new HallGetAllDTO
            {
                Halls = halls,
                Count = count
            };
            return hallsGetAll;
        }

        public async Task<PagenatedListDTO<HallGetDTO>> GetAllFilteredAsync(int page, int pageSize,string search = "")
        {
            List<Hall> halls = await _unitOfWork.HallRepository.GetAllPagenatedAsync(x=>x.IsDeleted==false,page, pageSize, "Tables.Status");
            if (search.Length==0)
            {
                halls = await _unitOfWork.HallRepository.GetAllPagenatedAsync(x => x.IsDeleted == false && x.Name.Contains(search), page, pageSize);
            }
            List<HallGetDTO> hallsListDto = new List<HallGetDTO>(); 
            foreach (var item in halls)
            {
                _mapper.Map<HallGetDTO>(item);
                hallsListDto.Add(_mapper.Map<HallGetDTO>(item));
            }
            int count = await _unitOfWork.HallRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            PagenatedListDTO<HallGetDTO> pagenatedHalls = new PagenatedListDTO<HallGetDTO>(hallsListDto, page, count, pageSize);
            return pagenatedHalls;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            Hall hall = await _unitOfWork.HallRepository.GetAsync(x=>x.Id==id);
            if (hall==null) throw new Exception("Hall doesn't exist in this Id");
            
            TEntity entity= _mapper.Map<TEntity>(hall);
            return entity;
        }
        public async Task<TEntity> GetByNameAsync<TEntity>(string name)
        {
            Hall hall = await _unitOfWork.HallRepository.GetAsync(x=>x.Name == name);
            if (hall == null) throw new Exception("Hall doesn't exist in this name");

            TEntity entity = _mapper.Map<TEntity>(hall);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.HallRepository.IsExistAsync(x=>x.Id==id);
        }
    }
}
