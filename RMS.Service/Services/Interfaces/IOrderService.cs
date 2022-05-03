using RMS.Service.DTOs;
using RMS.Service.DTOs.OrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateAsync(OrderPostDTO orderDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<PagenatedListDTO<OrderGetDTO>> GetAllFilteredAsync(int page, int pageSize);
        Task<OrderGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task EditAsync(int id, OrderEditDTO orderDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
