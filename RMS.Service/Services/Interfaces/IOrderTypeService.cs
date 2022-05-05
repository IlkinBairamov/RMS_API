using RMS.Service.DTOs.OrderTypeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IOrderTypeService
    {
        Task CreateAsync(OrderTypePostDTO orderTypeDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNameAsync<TEntity>(string name);
        Task<OrderTypeGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task EditAsync(int id, OrderTypePostDTO orderTypeDTO);  
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
