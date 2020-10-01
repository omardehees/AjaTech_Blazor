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
    public class Tbl_Log_Activities_yService : ITbl_Log_Activities_yService
    {
        //DataBase connection
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_Log_Activities_yService(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert new row to Tbl_Log_Activities_y Table
        public async Task<bool> Tbl_Log_Activities_yInsert(Tbl_Log_Activities_y tbl_Log_Activities_y)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pUser_ID", tbl_Log_Activities_y.User_ID, System.Data.DbType.String);
                parameters.Add("pUser_Name", tbl_Log_Activities_y.User_Name, System.Data.DbType.String);
                parameters.Add("pUser_Job", tbl_Log_Activities_y.User_Job, System.Data.DbType.String);
                parameters.Add("pUser_Department", tbl_Log_Activities_y.User_Department, System.Data.DbType.String);
                parameters.Add("pUser_Can_Navigate", tbl_Log_Activities_y.User_Can_Navigate, System.Data.DbType.Boolean);
                parameters.Add("pPage_Name", tbl_Log_Activities_y.Page_Name, System.Data.DbType.String);
                parameters.Add("pPage_Title", tbl_Log_Activities_y.Page_Title, System.Data.DbType.String);
                parameters.Add("pHRDW", tbl_Log_Activities_y.HRDW, System.Data.DbType.String);
                parameters.Add("pIP", tbl_Log_Activities_y.IP, System.Data.DbType.String);
                parameters.Add("pDevice", tbl_Log_Activities_y.Device, System.Data.DbType.String);
                parameters.Add("pAction", tbl_Log_Activities_y.Action, System.Data.DbType.String);
                parameters.Add("pAction_Code", tbl_Log_Activities_y.Action_Code, System.Data.DbType.String);
                parameters.Add("pAction_description", tbl_Log_Activities_y.Action_description, System.Data.DbType.String);
                parameters.Add("pAction_QueryString", tbl_Log_Activities_y.Action_QueryString, System.Data.DbType.String);
                parameters.Add("pProccessID", tbl_Log_Activities_y.ProccessID , System.Data.DbType.String);
                parameters.Add("pAffected_tables", tbl_Log_Activities_y.Affected_tables , System.Data.DbType.String);
                parameters.Add("pNotes", tbl_Log_Activities_y.Notes , System.Data.DbType.String);
                //Raw sql Method
                await conn.ExecuteAsync("sp_Insert_Tbl_Log_Activities_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        //Update row in Tbl_Log_Activities_y Table
        public async Task<bool> Tbl_Log_Activities_yUpdate(Tbl_Log_Activities_y tbl_Log_Activities_y)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                Debug.WriteLine(tbl_Log_Activities_y.ID);
                var parameters = new DynamicParameters();
                parameters.Add("ID", tbl_Log_Activities_y.ID, System.Data.DbType.String);
                parameters.Add("pTimeStamp", tbl_Log_Activities_y.TimeStamp, System.Data.DbType.DateTime);
                parameters.Add("pUser_ID", tbl_Log_Activities_y.User_ID, System.Data.DbType.String);
                parameters.Add("pUser_Name", tbl_Log_Activities_y.User_Name, System.Data.DbType.String);
                parameters.Add("pUser_Job", tbl_Log_Activities_y.User_Job, System.Data.DbType.String);
                parameters.Add("pUser_Department", tbl_Log_Activities_y.User_Department, System.Data.DbType.String);
                parameters.Add("pUser_Can_Navigate", tbl_Log_Activities_y.User_Can_Navigate, System.Data.DbType.Boolean);
                parameters.Add("pPage_Name", tbl_Log_Activities_y.Page_Name, System.Data.DbType.String);
                parameters.Add("pPage_Title", tbl_Log_Activities_y.Page_Title, System.Data.DbType.String);
                parameters.Add("pHRDW", tbl_Log_Activities_y.HRDW, System.Data.DbType.String);
                parameters.Add("pIP", tbl_Log_Activities_y.IP, System.Data.DbType.String);
                parameters.Add("pDevice", tbl_Log_Activities_y.Device, System.Data.DbType.String);
                parameters.Add("pAction", tbl_Log_Activities_y.Action, System.Data.DbType.String);
                parameters.Add("pAction_Code", tbl_Log_Activities_y.Action_Code, System.Data.DbType.String);
                parameters.Add("pAction_description", tbl_Log_Activities_y.Action_description, System.Data.DbType.String);
                parameters.Add("pAction_QueryString", tbl_Log_Activities_y.Action_QueryString, System.Data.DbType.String);
                parameters.Add("pProccessID", tbl_Log_Activities_y.ProccessID, System.Data.DbType.String);
                parameters.Add("pAffected_tables", tbl_Log_Activities_y.Affected_tables, System.Data.DbType.String);
                parameters.Add("pNotes", tbl_Log_Activities_y.Notes, System.Data.DbType.String);
                Debug.WriteLine("Done . . .");
            }
            return true;
        }

        //Update row in Tbl_Log_Activities_y Table -----------------------------------------------------------------------
        public async Task<bool> Tbl_Log_Activities_yDelete(int ID)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, System.Data.DbType.Int32);
                await conn.ExecuteAsync("sp_Delete_Tbl_Log_Activities_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //List Tbl_Log_Activities_y Table        
        public async Task<IEnumerable<Tbl_Log_Activities_y>> Tbl_Log_Activities_yList()
        {
            IEnumerable<Tbl_Log_Activities_y> tbl_Log_Activities_ys;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_Log_Activities_ys = conn.Query<Tbl_Log_Activities_y>("sp_Select_Tbl_Log_Activities_y", commandType: CommandType.StoredProcedure);
                    return tbl_Log_Activities_ys;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_Log_Activities_ys = await conn.QueryAsync<Tbl_Log_Activities_y>("sp_Select_Tbl_Log_Activities_y", commandType: CommandType.StoredProcedure);
                    return tbl_Log_Activities_ys;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_Log_Activities_ys = await conn.QueryAsync<Tbl_Log_Activities_y>("sp_Select_Tbl_Log_Activities_y", commandType: CommandType.StoredProcedure);
                    return tbl_Log_Activities_ys;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //One Tbl_Log_Activities_y by ID        
        public Tbl_Log_Activities_y Tbl_Log_Activities_yOne(int ID)
        {
            Tbl_Log_Activities_y tbl_Log_Activities_y;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from Tbl_Log_Activities_y where ID=" + ID.ToString();
                Debug.WriteLine(Querystring);
                try
                {
                    tbl_Log_Activities_y = conn.QuerySingle<Tbl_Log_Activities_y>(Querystring, ID, commandType: CommandType.Text);
                    return tbl_Log_Activities_y;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_Log_Activities_y = conn.QuerySingle<Tbl_Log_Activities_y>(Querystring, commandType: CommandType.Text);
                    return tbl_Log_Activities_y;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_Log_Activities_y = conn.QuerySingle<Tbl_Log_Activities_y>(Querystring, commandType: CommandType.Text);
                    return tbl_Log_Activities_y;
                }
            }
        }
    }
}
