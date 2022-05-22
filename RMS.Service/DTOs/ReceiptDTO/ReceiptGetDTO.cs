using RMS.Core.Entities;
using RMS.Service.DTOs.OrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ReceiptDTO
{
    public class ReceiptGetDTO
    {
        public int Id { get; set; }
        public int Barcode { get; set; }
        public DateTime Date { get; set; }
        public OrderGetDTO Order { get; set; }
    }
}
