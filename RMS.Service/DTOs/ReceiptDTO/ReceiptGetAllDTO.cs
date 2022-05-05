using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ReceiptDTO
{
    public class ReceiptGetAllDTO<TEntity>
    {
        public List<TEntity> Receipts { get; set; }
        public int Count { get; set; }
    }
}
