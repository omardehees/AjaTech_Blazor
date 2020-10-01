using AjaTech_Blazor.Data.Tables_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.IServices
{
    public interface Icb_database_Service
    {
        /// ***********************************************************************************************
        /// تمت المراجعة جزئيا
        /// ***********************************************************************************************
        void Save_To_Log_Invalid_LogIn(string User_Name, string Password);
        void Save_To_Log_Valid_LogIn(string User_Name, string Password, string Language);
        string[] Select_From_Database_String_Array(string QueryString);









        void IUD_Database(string QueryString);
        Task<IEnumerable<string>> Select_From_Database(string QueryString);
        string ReadField(string QueryString, string Required_Field);
    }
}