using RMS.Service.DTOs.StaffDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IStaffService
    {
        Task<StaffCreateReturnDTO> CreateAsync(StaffPostDTO staffDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNameAsync<TEntity>(string name); 
        Task<StaffGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task EditAsync(int id, StaffPostDTO staffDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
