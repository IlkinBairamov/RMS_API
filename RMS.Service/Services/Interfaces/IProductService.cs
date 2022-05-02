using RMS.Service.DTOs;
using RMS.Service.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IProductService
    {
        Task CreateAsync(ProductPostDTO productDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNameAsync<TEntity>(string name);
        Task<PagenatedListDTO<ProductGetDTO>> GetAllFilteredAsync(int page, int pageSize,string search="");
        Task<ProductGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task EditAsync(int id, ProductPostDTO productDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
