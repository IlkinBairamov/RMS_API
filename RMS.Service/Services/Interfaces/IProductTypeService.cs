using RMS.Service.DTOs;
using RMS.Service.DTOs.ProductTypeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IProductTypeService
    {
        Task CreateAsync(ProductTypePostDTO productTypeDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNameAsync<TEntity>(string name);
        Task<ProductTypeGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task EditAsync(int id, ProductTypePostDTO tableStatusDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
