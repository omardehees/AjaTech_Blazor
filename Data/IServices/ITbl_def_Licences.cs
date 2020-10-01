using AjaTech_Blazor.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
   public interface ITbl_def_Licences
    {
        Task<bool> Tbl_def_Licences_Delete(int ID);
        Task<bool> Tbl_def_Licences_Insert(Tbl_def_Licences Tbl_def_Licences);
        IEnumerable<Tbl_def_Licences> Tbl_def_Licences_List();
        Tbl_def_Licences Tbl_def_Licences_One(int ID);
        Task<bool> _Tbl_def_Licences_Update(Tbl_def_Licences Tbl_def_Licences);
    }
}
