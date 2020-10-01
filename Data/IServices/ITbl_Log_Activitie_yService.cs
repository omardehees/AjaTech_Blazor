using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface ITbl_Log_Activities_yService
    {
        Task<bool> Tbl_Log_Activities_yDelete(int ID);
        Task<bool> Tbl_Log_Activities_yInsert(Tbl_Log_Activities_y tbl_Log_Activities_y);
        Task<IEnumerable<Tbl_Log_Activities_y>> Tbl_Log_Activities_yList();
        Tbl_Log_Activities_y Tbl_Log_Activities_yOne(int ID);
        Task<bool> Tbl_Log_Activities_yUpdate(Tbl_Log_Activities_y tbl_Log_Activities_y);
    }
}