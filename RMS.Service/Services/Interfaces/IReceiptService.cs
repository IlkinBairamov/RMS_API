using RMS.Service.DTOs;
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
        Task CreateAsync(ReceiptPostDTO receiptDTO);
        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<PagenatedListDTO<ReceiptGetDTO>> GetAllFilteredAsync(int page, int pageSize);
        Task<ReceiptGetAllDTO<TEntity>> GetAllAsync<TEntity>();
        Task Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
