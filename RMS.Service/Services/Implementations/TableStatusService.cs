using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.TableStatusDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class TableStatusService : ITableStatusService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public TableStatusService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(TableStatusPostDTO tableStatusDTO)
        {
            if (await _unitOfWork.TableStatusRepository.IsExistAsync(x => x.Status == tableStatusDTO.Status))
                throw new AlreadyExistException($"{tableStatusDTO.Status} is already exist. Please change name!");
            TableStatus tableStatus = _mapper.Map<TableStatus>(tableStatusDTO);
            await _unitOfWork.TableStatusRepository.InsertAsync(tableStatus);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
            TableStatus status = await _unitOfWork.TableStatusRepository.GetAsync(x => x.Id == id);
            if (status == null)
            {
                throw new NotFoundException("table doesn't exist in this Id");
            }
            status.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, TableStatusPostDTO tableStatusDTO)
        {
            TableStatus table = await _unitOfWork.TableStatusRepository.GetAsync(x => x.Id == id);
            if (table == null)
            {
                throw new Exception("Table doesn't exist in this Id");
            }
            _mapper.Map<TableStatusPostDTO, TableStatus>(tableStatusDTO, table);
            await _unitOfWork.CommitAsync();
        }

        public async Task<TableStatusGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<TableStatus> entities = await _unitOfWork.TableStatusRepository.GetAllAsync(x=>x.IsDeleted==false);
            List<TEntity> tableStatuses = new List<TEntity>();
            foreach (var item in entities)
            {
                tableStatuses.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.TableStatusRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            TableStatusGetAllDTO<TEntity> tableStatusGetAll = new TableStatusGetAllDTO<TEntity>
            {
                TableStatuses = tableStatuses,
                Count = count
            };
            return tableStatusGetAll;
        }

        public async Task<PagenatedListDTO<TableStatusGetDTO>> GetAllFilteredAsync(int page, int pageSize, string search = "")
        {
            List<TableStatus> statuses = await _unitOfWork.TableStatusRepository.GetAllPagenatedAsync(x => x.IsDeleted == false, page, pageSize);

            List<TableStatusGetDTO> statusListDto = new List<TableStatusGetDTO>();
            foreach (var item in statuses)
            {
                statusListDto.Add(_mapper.Map<TableStatusGetDTO>(item));
            }
            int count = await _unitOfWork.HallRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            PagenatedListDTO<TableStatusGetDTO> pagenatedStatuses = new PagenatedListDTO<TableStatusGetDTO>(statusListDto, page, count, pageSize);
            return pagenatedStatuses;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            TableStatus status = await _unitOfWork.TableStatusRepository.GetAsync(x => x.Id == id);
            if (status == null) throw new NotFoundException("Hall doesn't exist in this Id");

            TEntity entity = _mapper.Map<TEntity>(status);
            return entity;
        }

        public async  Task<TEntity> GetByNameAsync<TEntity>(string name)
        {
            TableStatus status = await _unitOfWork.TableStatusRepository.GetAsync(x => x.Status == name);
            if (status == null) throw new NotFoundException("Hall doesn't exist in this Id");

            TEntity entity = _mapper.Map<TEntity>(status);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.TableStatusRepository.IsExistAsync(x => x.Id == id);
        }
    }
}
