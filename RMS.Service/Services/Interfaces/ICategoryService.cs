using RMS.Service.DTOs;
using RMS.Service.DTOs.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryCreateReturnDTO> CreateAsync(CategoryPostDTO CategoryDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNameAsync<TEntity>(string name);
        Task<CategoryGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task EditAsync(int id, CategoryEditDTO CategoryDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
