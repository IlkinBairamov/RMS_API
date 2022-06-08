using RMS.Service.DTOs;
using RMS.Service.DTOs.FoodDTO;
using RMS.Service.DTOs.ReceiptDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Interfaces
{
    public interface IReceiptService
    {
        Task<ReceiptGetDTO> CreateAsync(ReceiptPostDTO receiptDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<TEntity> GetByOrderAsync<TEntity>(int orderId);
        Task<PagenatedListDTO<ReceiptGetDTO>> GetAllFilteredAsync(int page, int pageSize);
        Task<ReceiptGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task<List<FoodReportDTO>> GetFoodsAsync(string time = "");
        Task<ReceiptGetAllDTO<TEntity>> GetAllByDateAsync<TEntity>(DateTime date);
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
