using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_Log_Ex_SQLEx_Errors_xService
    {
        Task<bool> Tbl_Log_Ex_SQLEx_Errors_xDelete(int ID);
        Task<bool> Tbl_Log_Ex_SQLEx_Errors_xInsert(Tbl_Log_Ex_SQLEx_Errors_x tbl_def_Modules_x);
        Task<IEnumerable<Tbl_Log_Ex_SQLEx_Errors_x>> Tbl_Log_Ex_SQLEx_Errors_xList();
        Tbl_Log_Ex_SQLEx_Errors_x Tbl_Log_Ex_SQLEx_Errors_xOne(int ID);
        Task<bool> Tbl_Log_Ex_SQLEx_Errors_xUpdate(Tbl_Log_Ex_SQLEx_Errors_x tbl_def_Modules_x);
    }
}