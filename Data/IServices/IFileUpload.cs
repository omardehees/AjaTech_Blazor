using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    interface IFileUpload
    {
        Task Upload(IFileListEntry file);
    }
}
