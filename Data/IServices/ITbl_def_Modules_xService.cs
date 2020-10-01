using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Modules_xService
    {
        Task<bool> Tbl_def_Modules_xDelete(int ID);
        Task<bool> Tbl_def_Modules_xInsert(Tbl_def_Modules_x tbl_def_Modules_x);
        Task<IEnumerable<Tbl_def_Modules_x>> Tbl_def_Modules_xList();
        Tbl_def_Modules_x Tbl_def_Modules_xOne(int ID);
        Task<bool> Tbl_def_Modules_xUpdate(Tbl_def_Modules_x tbl_def_Modules_x);
    }
}