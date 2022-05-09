using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.TableDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class TableService : ITableService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TableService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task CreateAsync(TablePostDTO tableDto)
        {
            if (await _unitOfWork.TableRepository.IsExistAsync(x => x.Number == tableDto.Number ))
                throw new AlreadyExistException($"{tableDto.Number} is already exist. Please change name!");
            if (!await _unitOfWork.HallRepository.IsExistAsync(x=>x.Id==tableDto.HallId))
                throw new NotFoundException($"{tableDto.HallId} not Found. Please select other table!");
            if (!await _unitOfWork.TableStatusRepository.IsExistAsync(x => x.Id == tableDto.StatusId))
                throw new NotFoundException($"{tableDto.StatusId} not Found. Please select other table!");
            Table table = _mapper.Map<Table>(tableDto);
            await _unitOfWork.TableRepository.InsertAsync(table);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
            Table table = await _unitOfWork.TableRepository.GetAsync(x => x.Id == id);
            if (table == null)
            {
                throw new Exception("table doesn't exist in this Id");
            }
            table.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, TablePostDTO tableDto)
        {
            Table table = await _unitOfWork.TableRepository.GetAsync(x => x.Id == id);
            if (table == null)
            {
                throw new Exception("Table doesn't exist in this Id");
            }
            if (await _unitOfWork.TableRepository.IsExistAsync(x => x.Id != id && x.HallId==tableDto.HallId && x.Number == tableDto.Number))
            {
                throw new Exception("Table is Already Exist with this Name");
            }
            _mapper.Map<TablePostDTO, Table>(tableDto, table);
            await _unitOfWork.CommitAsync();
        }

        public async Task<PagenatedListDTO<TableGetDTO>> GetAllFilteredAsync(int page, int pageSize,int hallId)
        {
            List<Table> tables = await _unitOfWork.TableRepository.GetAllPagenatedAsync(x => x.IsDeleted == false && x.HallId == hallId, page, pageSize);

            List<TableGetDTO> tableListDto = new List<TableGetDTO>();
            foreach (var item in tables)
            {
                _mapper.Map<TableGetDTO>(item);
                tableListDto.Add(_mapper.Map<TableGetDTO>(item));
            }
            int count = await _unitOfWork.HallRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            PagenatedListDTO<TableGetDTO> pagenatedHalls = new PagenatedListDTO<TableGetDTO>(tableListDto, page, count, pageSize);
            return pagenatedHalls;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            Table table = await _unitOfWork.TableRepository.GetAsync(x => x.Id == id && x.IsDeleted==false);
            if (table == null) throw new Exception("Hall doesn't exist in this Id");

            TEntity entity = _mapper.Map<TEntity>(table);
            return entity;
        }

        public async Task<TEntity> GetByNumberAsync<TEntity>(int number)
        {
            Table table = await _unitOfWork.TableRepository.GetAsync(x => x.Number == number);
            if (table == null) throw new Exception("Hall doesn't exist in This Number");

            TEntity entity = _mapper.Map<TEntity>(table);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.TableRepository.IsExistAsync(x => x.Id == id);
        }
    }
}
