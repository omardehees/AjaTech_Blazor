using AjaTech_Blazor.Data.IServices;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Services
{
    public class FIleUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FIleUpload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task Upload(IFileListEntry file)
        {
            var path = Path.Combine(_webHostEnvironment.ContentRootPath, "wwwroot/css/UploadsFile", file.Name);
           var MemoryStream = new MemoryStream();
           await file.Data.CopyToAsync(MemoryStream);
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            { MemoryStream.WriteTo(fileStream); }
        }
    }
}
