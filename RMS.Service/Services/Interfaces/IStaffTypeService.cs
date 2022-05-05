using RMS.Service.DTOs.StaffTypeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IStaffTypeService
    {
        Task CreateAsync(StaffTypePostDTO staffTypeDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNameAsync<TEntity>(string name);
        Task<StaffTypeGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task EditAsync(int id, StaffTypePostDTO staffTypeDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
