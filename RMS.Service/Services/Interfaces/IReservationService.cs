using RMS.Service.DTOs;
using RMS.Service.DTOs.ReservationDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IReservationService
    {
        Task CreateAsync(ReservationPostDTO reservationDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<PagenatedListDTO<ReservationGetDTO>> GetAllFilteredAsync(int page, int pageSize);
        Task<ReservationGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task EditAsync(int id,ReservationPostDTO reservationDTO);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
