using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Courses_xService
    {
        Task<bool> Tbl_def_Courses_xDelete(int ID);
        Task<bool> Tbl_def_Courses_xInsert(Tbl_def_Courses_x tbl_def_Courses_x);
        Task<IEnumerable<Tbl_def_Courses_x>> Tbl_def_Courses_xList();
        Tbl_def_Courses_x Tbl_def_Courses_xOne(int ID);
        Task<bool> Tbl_def_Courses_xUpdate(Tbl_def_Courses_x tbl_def_Courses_x);
    }
}