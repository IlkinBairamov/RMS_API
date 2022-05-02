using RMS.Service.DTOs;
using RMS.Service.DTOs.FoodDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IFoodService
    {
        Task<FoodCreateReturnDTO> CreateAsync(FoodPostDTO foodDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNameAsync<TEntity>(string name);
        Task<PagenatedListDTO<FoodGetDTO>> GetAllFilteredAsync(int page, int pageSize);
        Task<FoodGetAllDTO<TEntity>> GetAllAsync<TEntity>(int page, int pageSize);
        Task EditAsync(int id, FoodEditDTO foodDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
