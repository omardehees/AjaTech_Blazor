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
    public class Tbl_def_Users_yService : ITbl_def_Users_yService
    {
        //DataBase connection
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_def_Users_yService(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert new row to Tbl_def_Users_y Table
        public async Task<bool> Tbl_def_Users_yInsert(Tbl_def_Users_y tbl_def_Users_y)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pUser_Name", tbl_def_Users_y.User_Name, System.Data.DbType.String);
                parameters.Add("pFull_Name", tbl_def_Users_y.Full_Name, System.Data.DbType.String);
                parameters.Add("pPassword", tbl_def_Users_y.Password, System.Data.DbType.String);
                parameters.Add("pPassword_hint", tbl_def_Users_y.Password_hint, System.Data.DbType.String);
                parameters.Add("pStart_Page", tbl_def_Users_y.Start_Page, System.Data.DbType.String);
                parameters.Add("pPages", tbl_def_Users_y.Pages, System.Data.DbType.String);
                parameters.Add("pLanguage", tbl_def_Users_y.Language, System.Data.DbType.String);
                parameters.Add("pEmail", tbl_def_Users_y.Email, System.Data.DbType.String);
                parameters.Add("pPhone", tbl_def_Users_y.Phone, System.Data.DbType.String);
                parameters.Add("pAddress", tbl_def_Users_y.Address, System.Data.DbType.String);
                parameters.Add("pDefault_Treasury", tbl_def_Users_y.Default_Treasury, System.Data.DbType.String);
                parameters.Add("pjob", tbl_def_Users_y.job, System.Data.DbType.String);
                parameters.Add("pEnabled", tbl_def_Users_y.Enabled, System.Data.DbType.Boolean);
                parameters.Add("psubstitutant", tbl_def_Users_y.substitutant, System.Data.DbType.String);
                parameters.Add("pIS_Super_User", tbl_def_Users_y.IS_Super_User, System.Data.DbType.Boolean);
                parameters.Add("pNotes", tbl_def_Users_y.Notes, System.Data.DbType.String);
                //Raw sql Method
                await conn.ExecuteAsync("sp_Insert_Tbl_def_Users_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        //Update row in Tbl_def_Users_y Table
        public async Task<bool> Tbl_def_Users_yUpdate(Tbl_def_Users_y tbl_def_Users_y)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                Debug.WriteLine(">> 111");
                Debug.WriteLine(">> " + tbl_def_Users_y.ID);
                var parameters = new DynamicParameters();
                parameters.Add("pID", tbl_def_Users_y.ID, System.Data.DbType.Int32);
                parameters.Add("pUser_Name", tbl_def_Users_y.User_Name, System.Data.DbType.String);
                parameters.Add("pFull_Name", tbl_def_Users_y.Full_Name, System.Data.DbType.String);
                parameters.Add("pPassword", tbl_def_Users_y.Password, System.Data.DbType.String);
                parameters.Add("pPassword_hint", tbl_def_Users_y.Password_hint, System.Data.DbType.String);
                parameters.Add("pStart_Page", tbl_def_Users_y.Start_Page, System.Data.DbType.String);
                parameters.Add("pPages", tbl_def_Users_y.Pages, System.Data.DbType.String);
                parameters.Add("pLanguage", tbl_def_Users_y.Language, System.Data.DbType.String);
                parameters.Add("pEmail", tbl_def_Users_y.Email, System.Data.DbType.String);
                parameters.Add("pPhone", tbl_def_Users_y.Phone, System.Data.DbType.String);
                parameters.Add("pAddress", tbl_def_Users_y.Address, System.Data.DbType.String);
                parameters.Add("pDefault_Treasury", tbl_def_Users_y.Default_Treasury, System.Data.DbType.String);
                parameters.Add("pjob", tbl_def_Users_y.job, System.Data.DbType.String);
                parameters.Add("pEnabled", tbl_def_Users_y.Enabled, System.Data.DbType.Boolean);
                parameters.Add("psubstitutant", tbl_def_Users_y.substitutant, System.Data.DbType.String);
                parameters.Add("pIS_Super_User", tbl_def_Users_y.IS_Super_User, System.Data.DbType.Boolean);
                parameters.Add("pNotes", tbl_def_Users_y.Notes, System.Data.DbType.String);
                await conn.ExecuteAsync("sp_Update_Tbl_def_Users_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
                Debug.WriteLine(">> " + parameters.Get<int>("pID"));
                Debug.WriteLine(">> " + parameters.Get<String>("pUser_Name"));
                Debug.WriteLine(">> " + parameters.Get<String>("pFull_Name"));
                Debug.WriteLine(">> " + parameters.Get<String>("pPassword"));
                Debug.WriteLine(">> " + parameters.Get<String>("pPassword_hint"));
                Debug.WriteLine(">> " + parameters.Get<String>("pEmail"));
                Debug.WriteLine(">> " + parameters.Get<String>("pPhone"));
                Debug.WriteLine(">> " + parameters.Get<String>("pAddress"));
                Debug.WriteLine(">> " + parameters.Get<String>("pDefault_Treasury"));
            }
            return true;
        }

        //Update row in Tbl_def_Users_y Table -----------------------------------------------------------------------
        public async Task<bool> Tbl_def_Users_yDelete(int ID)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, System.Data.DbType.Int32);
                await conn.ExecuteAsync("sp_Delete_Tbl_def_Users_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //List Tbl_def_Users_y Table        
        public async Task<IEnumerable<Tbl_def_Users_y>> Tbl_def_Users_yList()
        {
            IEnumerable<Tbl_def_Users_y> tbl_def_Users_ys;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_def_Users_ys = conn.Query<Tbl_def_Users_y>("sp_Select_Tbl_def_Users_y", commandType: CommandType.StoredProcedure);
                    return tbl_def_Users_ys;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Users_ys = await conn.QueryAsync<Tbl_def_Users_y>("sp_Select_Tbl_def_Users_y", commandType: CommandType.StoredProcedure);
                    return tbl_def_Users_ys;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Users_ys = await conn.QueryAsync<Tbl_def_Users_y>("sp_Select_Tbl_def_Users_y", commandType: CommandType.StoredProcedure);
                    return tbl_def_Users_ys;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //One Tbl_def_Users_y by ID        
        public Tbl_def_Users_y Tbl_def_Users_yOne(int ID)
        {
            Tbl_def_Users_y tbl_def_Users_y;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from Tbl_def_Users_y where ID=" + ID.ToString();
                Debug.WriteLine(Querystring);
                try
                {
                    tbl_def_Users_y = conn.QuerySingle<Tbl_def_Users_y>(Querystring, ID, commandType: CommandType.Text);
                    return tbl_def_Users_y;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Users_y = conn.QuerySingle<Tbl_def_Users_y>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Users_y;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Users_y = conn.QuerySingle<Tbl_def_Users_y>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Users_y;
                }
            }
        }
    }
}
