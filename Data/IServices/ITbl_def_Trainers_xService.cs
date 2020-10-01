using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Trainers_xService
    {
        Task<bool> Tbl_def_Trainers_xDelete(int ID);
        Task<bool> Tbl_def_Trainers_xInsert(Tbl_def_Trainers_x tbl_def_Trainers_x);
        Task<IEnumerable<Tbl_def_Trainers_x>> Tbl_def_Trainers_xList();
        Tbl_def_Trainers_x Tbl_def_Trainers_xOne(int ID);
        Task<IEnumerable<string>> Tbl_def_Trainers_xList_Jobs();
        Task<bool> Tbl_def_Trainers_xUpdate(Tbl_def_Trainers_x tbl_def_Trainers_x);
    }
}