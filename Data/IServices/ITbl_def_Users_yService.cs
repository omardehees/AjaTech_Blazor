using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Users_yService
    {
        Task<bool> Tbl_def_Users_yDelete(int ID);
        Task<bool> Tbl_def_Users_yInsert(Tbl_def_Users_y tbl_def_users_y);
        Task<IEnumerable<Tbl_def_Users_y>> Tbl_def_Users_yList();
        Tbl_def_Users_y Tbl_def_Users_yOne(int ID);
        Task<bool> Tbl_def_Users_yUpdate(Tbl_def_Users_y tbl_def_users_y);
    }
}