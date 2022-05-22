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
        Task<TEntity> GetByTableAsync<TEntity>(int tableID);
        Task<PagenatedListDTO<OrderGetDTO>> GetAllFilteredAsync(int page, int pageSize);
        Task<OrderGetAllDTO> GetAllAsync();
        Task EditAsync(int id, OrderEditDTO orderDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
