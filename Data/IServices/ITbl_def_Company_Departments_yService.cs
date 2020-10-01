using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Company_Departments_yService
    {
        Task<bool> Tbl_def_Company_Departments_yDelete(int ID);
        Task<bool> Tbl_def_Company_Departments_yInsert(Tbl_def_Company_Departments_y tbl_def_Company_Departments_y);
       IEnumerable <Tbl_def_Company_Departments_y> Tbl_def_Company_Departments_yList();
        Tbl_def_Company_Departments_y Tbl_def_Company_Departments_yOne(int ID);
        Task<bool> Tbl_def_Company_Departments_yUpdate(Tbl_def_Company_Departments_y tbl_def_Company_Departments_y);
    }
}