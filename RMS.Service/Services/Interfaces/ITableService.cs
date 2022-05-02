using RMS.Service.DTOs;
using RMS.Service.DTOs.TableDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface ITableService
    {
        Task CreateAsync(TablePostDTO hallDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNumberAsync<TEntity>(int number);
        Task<PagenatedListDTO<TableGetDTO>> GetAllFilteredAsync(int page, int pageSize);
        Task EditAsync(int id, TablePostDTO hallDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
