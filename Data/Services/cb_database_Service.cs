using AjaTech_Blazor.Data.Tables_Models;

using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.Data.SqlClient;
namespace AjaTech_Blazor.Data.IServices
{
    public class cb_database_Service : Icb_database_Service
    {
        string QueryString = "";
        /// ***********************************************************************************************
        /// تمت المراجعة جزئيا
        /// ***********************************************************************************************
        //Save Invalid LogIn ----------------------------------------------
        public void Save_To_Log_Invalid_LogIn(string User_Name, string Password)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //conn.ExecuteAsync(QueryString, commandType: System.Data.CommandType.Text);
            }
        }

        //Save valid LogIn  -----------------------------------------------
        public void Save_To_Log_Valid_LogIn(string User_Name, string Password, string Language)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                QueryString = "Update Tbl_def_Users_y set language='" + Language + "' where User_Name='" + User_Name + "'";
                IUD_Database(QueryString);
                //conn.ExecuteAsync(QueryString, commandType: System.Data.CommandType.Text);
            }
        }

        //DataBase connection ------------------------------------------------
        private readonly SqlConnectionConfiguration _configuration;
        public cb_database_Service(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert_Update_Delete_Database -----------------------------------------------
        public void IUD_Database(string QueryString)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                conn.ExecuteAsync(QueryString, commandType: System.Data.CommandType.Text);
            }
        }
        //Select from DataBase -----------------------------------------------
        public async Task<IEnumerable<string>> Select_From_Database(string QueryString)
        {
            //IEnumerable<string> tbl_def_Administrators_x_Jobs;
            //public async Task<IEnumerable<string>> Tbl_def_Administrators_xList_Jobs(string QueryString)
            //public IEnumerable<string> Select_From_Database(string QueryString)
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    return await conn.QueryAsync<string>(QueryString, commandType: CommandType.Text);
                }
            }
        }
        //Select_From_Database_String_Array -----------------------------------------------
        public string[] Select_From_Database_String_Array(string QueryString)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var reader = conn.ExecuteReader(QueryString, commandType: CommandType.Text);
                var list = new List<string>();
                while (reader.Read())
                    list.Add(reader.GetString(0));
                return list.ToArray();
            }
        }







        //Get String from DataBase -----------------------------------------------
        public string ReadField(string QueryString, string Required_Field)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dbAdapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = QueryString;
            cmd.Connection = new SqlConnection(_configuration.Value);
            dbAdapter.SelectCommand = cmd;
            dbAdapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            foreach (DataRow dtro in dt.Rows)
            {
                if (dtro.IsNull(Required_Field) == true)
                {
                    return null;
                }
                else
                {
                    //return  dtro.Field<string>(Required_Field);
                    return dtro[Required_Field].ToString();
                }
            }
            return "";
        }

    }
}
