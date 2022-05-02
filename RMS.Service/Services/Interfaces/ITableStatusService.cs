using RMS.Service.DTOs;
using RMS.Service.DTOs.TableStatusDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface ITableStatusService
    {
        Task CreateAsync(TableStatusPostDTO tableStatusDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNameAsync<TEntity>(string name);
        Task<PagenatedListDTO<TableStatusGetDTO>> GetAllFilteredAsync(int page, int pageSize, string search = "");
        Task<TableStatusGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task EditAsync(int id, TableStatusPostDTO tableStatusDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
