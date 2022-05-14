using RMS.Service.DTOs;
using RMS.Service.DTOs.HallDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IHallService
    {
        Task CreateAsync(HallPostDTO hallDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByNameAsync<TEntity>(string name);
        Task<PagenatedListDTO<HallGetDTO>> GetAllFilteredAsync(int page,int pageSize, string search="");
        Task<HallGetAllDTO> GetAllAsync();
        Task EditAsync(int id, HallPostDTO hallDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
