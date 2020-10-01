using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Company_yService
    {
        Task<bool> Tbl_def_Company_yDelete(int ID);
        Task<bool> Tbl_def_Company_yInsert(Tbl_def_Company_y tbl_def_Company_y);
        Tbl_def_Company_y Tbl_def_Company_yList();
        Tbl_def_Company_y Tbl_def_Company_yOne(int ID);
        Task<bool> Tbl_def_Company_yUpdate(Tbl_def_Company_y tbl_def_Company_y);
    }
}