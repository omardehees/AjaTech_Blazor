using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Lectures_xService
    {
        Task<bool> Tbl_def_Lectures_xDelete(int ID);
        Task<bool> Tbl_def_Lectures_xInsert(Tbl_def_Lectures_x tbl_def_Lectures_x);
        Task<IEnumerable<Tbl_def_Lectures_x>> Tbl_def_Lectures_xList();
        Tbl_def_Lectures_x Tbl_def_Lectures_xOne(int ID);
        Task<bool> Tbl_def_Lectures_xUpdate(Tbl_def_Lectures_x tbl_def_Lectures_x);
    }
}