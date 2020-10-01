using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Courses_Types_xService
    {
        Task<bool> Tbl_def_Courses_Types_xDelete(int ID);
        Task<bool> Tbl_def_Courses_Types_xInsert(Tbl_def_Courses_Types_x tbl_def_Courses_Types_x);
        Task<IEnumerable<Tbl_def_Courses_Types_x>> Tbl_def_Courses_Types_xList();
        Tbl_def_Courses_Types_x Tbl_def_Courses_Types_xOne(int ID);
        Task<bool> Tbl_def_Courses_Types_xUpdate(Tbl_def_Courses_Types_x tbl_def_Courses_Types_x);
    }
}