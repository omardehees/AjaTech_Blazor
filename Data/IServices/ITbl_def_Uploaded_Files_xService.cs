using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Uploaded_Files_xService
    {
        Task<bool> Tbl_def_Uploaded_Files_xDelete(int ID);
        Task<bool> Tbl_def_Uploaded_Files_xInsert(Tbl_def_Uploaded_Files_x tbl_def_Modules_x);
        Task<IEnumerable<Tbl_def_Uploaded_Files_x>> Tbl_def_Uploaded_Files_xList();
        Tbl_def_Uploaded_Files_x Tbl_def_Uploaded_Files_xOne(int ID);
        Task<bool> Tbl_def_Uploaded_Files_xUpdate(Tbl_def_Uploaded_Files_x tbl_def_Modules_x);
    }
}