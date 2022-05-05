using RMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ReceiptDTO
{
    public class ReceiptGetDTO
    {
        public int Barcode { get; set; }
        public DateTime Date { get; set; }
        public Order Order { get; set; }
    }
}
