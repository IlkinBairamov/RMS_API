using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs
{
    public class SavedFileDTO
    {
        public string FileName { get; set; }
        public string ChangedFileName { get; set; }
        public string Path { get; set; }
    }
}
