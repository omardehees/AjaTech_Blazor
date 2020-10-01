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
    public class Tbl_Log_Ex_SQLEx_Errors_xService : ITbl_Log_Ex_SQLEx_Errors_xService
    {
        //DataBase connection
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_Log_Ex_SQLEx_Errors_xService(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert new row to Tbl_Log_Ex_SQLEx_Errors_x Table
        public async Task<bool> Tbl_Log_Ex_SQLEx_Errors_xInsert(Tbl_Log_Ex_SQLEx_Errors_x tbl_Log_Ex_SQLEx_Errors_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pTimeStamp", tbl_Log_Ex_SQLEx_Errors_x.TimeStamp, System.Data.DbType.String);
                parameters.Add("pSevirty", tbl_Log_Ex_SQLEx_Errors_x.Sevirty, System.Data.DbType.String);
                parameters.Add("pISArchived", tbl_Log_Ex_SQLEx_Errors_x.ISArchived, System.Data.DbType.Boolean);
                parameters.Add("pUser_ID", tbl_Log_Ex_SQLEx_Errors_x.User_ID, System.Data.DbType.String);
                parameters.Add("pUser_Full_Name", tbl_Log_Ex_SQLEx_Errors_x.User_Full_Name, System.Data.DbType.String);
                parameters.Add("pPage_File", tbl_Log_Ex_SQLEx_Errors_x.Page_File, System.Data.DbType.String);
                parameters.Add("pPage_Title", tbl_Log_Ex_SQLEx_Errors_x.Page_Title, System.Data.DbType.String);
                parameters.Add("pBlock", tbl_Log_Ex_SQLEx_Errors_x.Block, System.Data.DbType.String);
                parameters.Add("pLine", tbl_Log_Ex_SQLEx_Errors_x.Line, System.Data.DbType.Int32);
                parameters.Add("pIP_Address", tbl_Log_Ex_SQLEx_Errors_x.IP_Address, System.Data.DbType.String);
                parameters.Add("pBrowser", tbl_Log_Ex_SQLEx_Errors_x.Browser, System.Data.DbType.String);
                parameters.Add("pType", tbl_Log_Ex_SQLEx_Errors_x.Type, System.Data.DbType.String);
                parameters.Add("pMessage", tbl_Log_Ex_SQLEx_Errors_x.Message, System.Data.DbType.String);
                parameters.Add("pNotes", tbl_Log_Ex_SQLEx_Errors_x.Notes, System.Data.DbType.String);
                //Raw sql Method
                await conn.ExecuteAsync("sp_Insert_Tbl_Log_Ex_SQLEx_Errors_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        //Update row in Tbl_Log_Ex_SQLEx_Errors_x Table
        public async Task<bool> Tbl_Log_Ex_SQLEx_Errors_xUpdate(Tbl_Log_Ex_SQLEx_Errors_x tbl_Log_Ex_SQLEx_Errors_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                Debug.WriteLine(tbl_Log_Ex_SQLEx_Errors_x.ID);
                var parameters = new DynamicParameters();
                parameters.Add("pID", tbl_Log_Ex_SQLEx_Errors_x.ID, System.Data.DbType.Int32);
                parameters.Add("pTimeStamp", tbl_Log_Ex_SQLEx_Errors_x.TimeStamp, System.Data.DbType.String);
                parameters.Add("pSevirty", tbl_Log_Ex_SQLEx_Errors_x.Sevirty, System.Data.DbType.String);
                parameters.Add("pISArchived", tbl_Log_Ex_SQLEx_Errors_x.ISArchived, System.Data.DbType.Boolean);
                parameters.Add("pUser_ID", tbl_Log_Ex_SQLEx_Errors_x.User_ID, System.Data.DbType.String);
                parameters.Add("pUser_Full_Name", tbl_Log_Ex_SQLEx_Errors_x.User_Full_Name, System.Data.DbType.String);
                parameters.Add("pPage_File", tbl_Log_Ex_SQLEx_Errors_x.Page_File, System.Data.DbType.String);
                parameters.Add("pPage_Title", tbl_Log_Ex_SQLEx_Errors_x.Page_Title, System.Data.DbType.String);
                parameters.Add("pBlock", tbl_Log_Ex_SQLEx_Errors_x.Block, System.Data.DbType.String);
                parameters.Add("pLine", tbl_Log_Ex_SQLEx_Errors_x.Line, System.Data.DbType.Int32);
                parameters.Add("pIP_Address", tbl_Log_Ex_SQLEx_Errors_x.IP_Address, System.Data.DbType.String);
                parameters.Add("pBrowser", tbl_Log_Ex_SQLEx_Errors_x.Browser, System.Data.DbType.String);
                parameters.Add("pType", tbl_Log_Ex_SQLEx_Errors_x.Type, System.Data.DbType.String);
                parameters.Add("pMessage", tbl_Log_Ex_SQLEx_Errors_x.Message, System.Data.DbType.String);
                parameters.Add("pNotes", tbl_Log_Ex_SQLEx_Errors_x.Notes, System.Data.DbType.String); await conn.ExecuteAsync("sp_Update_Tbl_Log_Ex_SQLEx_Errors_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
                Debug.WriteLine("Done . . .");
            }
            return true;
        }

        //Update row in Tbl_Log_Ex_SQLEx_Errors_x Table -----------------------------------------------------------------------
        public async Task<bool> Tbl_Log_Ex_SQLEx_Errors_xDelete(int ID)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, System.Data.DbType.Int32);
                await conn.ExecuteAsync("sp_Delete_Tbl_Log_Ex_SQLEx_Errors_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //List Tbl_Log_Ex_SQLEx_Errors_x Table        
        public async Task<IEnumerable<Tbl_Log_Ex_SQLEx_Errors_x>> Tbl_Log_Ex_SQLEx_Errors_xList()
        {
            IEnumerable<Tbl_Log_Ex_SQLEx_Errors_x> tbl_Log_Ex_SQLEx_Errors_xs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_Log_Ex_SQLEx_Errors_xs = conn.Query<Tbl_Log_Ex_SQLEx_Errors_x>("sp_Select_Tbl_Log_Ex_SQLEx_Errors_x", commandType: CommandType.StoredProcedure);
                    return tbl_Log_Ex_SQLEx_Errors_xs;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_Log_Ex_SQLEx_Errors_xs = await conn.QueryAsync<Tbl_Log_Ex_SQLEx_Errors_x>("sp_Select_Tbl_Log_Ex_SQLEx_Errors_x", commandType: CommandType.StoredProcedure);
                    return tbl_Log_Ex_SQLEx_Errors_xs;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_Log_Ex_SQLEx_Errors_xs = await conn.QueryAsync<Tbl_Log_Ex_SQLEx_Errors_x>("sp_Select_Tbl_Log_Ex_SQLEx_Errors_x", commandType: CommandType.StoredProcedure);
                    return tbl_Log_Ex_SQLEx_Errors_xs;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //One Tbl_Log_Ex_SQLEx_Errors_x by ID        
        public Tbl_Log_Ex_SQLEx_Errors_x Tbl_Log_Ex_SQLEx_Errors_xOne(int ID)
        {
            Tbl_Log_Ex_SQLEx_Errors_x tbl_Log_Ex_SQLEx_Errors_x;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from Tbl_Log_Ex_SQLEx_Errors_x where ID=" + ID.ToString();
                Debug.WriteLine(Querystring);
                try
                {
                    tbl_Log_Ex_SQLEx_Errors_x = conn.QuerySingle<Tbl_Log_Ex_SQLEx_Errors_x>(Querystring, ID, commandType: CommandType.Text);
                    return tbl_Log_Ex_SQLEx_Errors_x;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_Log_Ex_SQLEx_Errors_x = conn.QuerySingle<Tbl_Log_Ex_SQLEx_Errors_x>(Querystring, commandType: CommandType.Text);
                    return tbl_Log_Ex_SQLEx_Errors_x;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_Log_Ex_SQLEx_Errors_x = conn.QuerySingle<Tbl_Log_Ex_SQLEx_Errors_x>(Querystring, commandType: CommandType.Text);
                    return tbl_Log_Ex_SQLEx_Errors_x;
                }
            }
        }
    }
}
