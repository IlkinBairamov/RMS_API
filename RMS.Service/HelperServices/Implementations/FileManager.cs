using Microsoft.AspNetCore.Http;
using RMS.Service.DTOs;
using RMS.Service.Exceptions;
using RMS.Service.HelperServices.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.HelperServices.Implementations
{
    public class FileManager : IFileManager
    {
        public async Task<SavedFileDTO> Save(IFormFile file,string folder)
        {
            if (file == null) throw new Exception("File can't be null");
            if (file.ContentType != "image/jpeg" && file.ContentType != "image/png" && file.ContentType != "image/jpg")
                throw new FileFormatException("Upload Type must be image(png,jpg,jpeg)");
            string newFileName = file.FileName;
            newFileName = newFileName.Length >64 ? newFileName.Substring(newFileName.Length - 64, 64) : newFileName;
            newFileName = Guid.NewGuid().ToString() + newFileName;
            string path = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/uploads/", folder, newFileName);

            SavedFileDTO savedFile = new SavedFileDTO
            {
                FileName = file.FileName,
                ChangedFileName = newFileName,
                Path = "https://localhost:44355/uploads/foods/" + newFileName,
            };

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return savedFile;
        }
    }
}
