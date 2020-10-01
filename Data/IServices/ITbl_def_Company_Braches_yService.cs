using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_def_Company_Braches_yService
    {
        Task<bool> Tbl_def_Company_Braches_yDelete(int ID);
        Task<bool> Tbl_def_Company_Braches_yInsert(Tbl_def_Company_Braches_y tbl_def_Company_Braches_y);
        //Tbl_def_Company_Braches_y Tbl_def_Company_Braches_yList();
        IEnumerable<Tbl_def_Company_Braches_y> Tbl_def_Company_Braches_yList();
        Tbl_def_Company_Braches_y Tbl_def_Company_Braches_yOne(int ID);
        Task<bool> Tbl_def_Company_Braches_yUpdate(Tbl_def_Company_Braches_y tbl_def_Company_Braches_y);
    }
}