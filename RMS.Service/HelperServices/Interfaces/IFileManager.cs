using Microsoft.AspNetCore.Http;
using RMS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.HelperServices.Interfaces
{
    public interface IFileManager
    {
        Task<SavedFileDTO> Save(IFormFile file,string folder);
    }
}
