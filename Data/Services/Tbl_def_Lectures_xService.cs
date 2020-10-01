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
    public class Tbl_def_Lectures_xService : ITbl_def_Lectures_xService
    {
        //DataBase connection
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_def_Lectures_xService(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert new row to Tbl_def_Lectures_x Table
        public async Task<bool> Tbl_def_Lectures_xInsert(Tbl_def_Lectures_x tbl_def_Lectures_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();               
                parameters.Add("Title_Ar", tbl_def_Lectures_x.Title_Ar, System.Data.DbType.String);
                parameters.Add("title_En", tbl_def_Lectures_x.title_En, System.Data.DbType.String);
                parameters.Add("Description_En", tbl_def_Lectures_x.Description_En, System.Data.DbType.String);
                parameters.Add("Description_Ar", tbl_def_Lectures_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("Photo", tbl_def_Lectures_x.Photo, System.Data.DbType.String);
                parameters.Add("Enabled", tbl_def_Lectures_x.Enabled, System.Data.DbType.Boolean);
                parameters.Add("Module_Title_Ar", tbl_def_Lectures_x.Module_Title_Ar, System.Data.DbType.String);
                parameters.Add("Module_Title_En", tbl_def_Lectures_x.Module_Title_En, System.Data.DbType.String);
                parameters.Add("Files", tbl_def_Lectures_x.Files, System.Data.DbType.String);
                parameters.Add("Level_Ar", tbl_def_Lectures_x.Level_Ar, System.Data.DbType.String);
                parameters.Add("Level_En", tbl_def_Lectures_x.Level_En, System.Data.DbType.String);
                parameters.Add("Prerequests_Ar", tbl_def_Lectures_x.Prerequests_Ar, System.Data.DbType.String);
                parameters.Add("Prerequests_Ar", tbl_def_Lectures_x.Prerequests_En, System.Data.DbType.String);
                parameters.Add("Notes", tbl_def_Lectures_x.Notes, System.Data.DbType.String);   //Raw sql Method
                await conn.ExecuteAsync("sp_Insert_Tbl_def_Lectures_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        //Update row in Tbl_def_Lectures_x Table
        public async Task<bool> Tbl_def_Lectures_xUpdate(Tbl_def_Lectures_x tbl_def_Lectures_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                Debug.WriteLine(tbl_def_Lectures_x.ID);
                var parameters = new DynamicParameters();
                parameters.Add("ID", tbl_def_Lectures_x.ID, System.Data.DbType.String);
                parameters.Add("Title_Ar", tbl_def_Lectures_x.Title_Ar, System.Data.DbType.String);
                parameters.Add("title_En", tbl_def_Lectures_x.title_En, System.Data.DbType.String);
                parameters.Add("Description_En", tbl_def_Lectures_x.Description_En, System.Data.DbType.String);
                parameters.Add("Description_Ar", tbl_def_Lectures_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("Photo", tbl_def_Lectures_x.Photo, System.Data.DbType.String);
                parameters.Add("Enabled", tbl_def_Lectures_x.Enabled, System.Data.DbType.Boolean);
                parameters.Add("Module_Title_Ar", tbl_def_Lectures_x.Module_Title_Ar, System.Data.DbType.String);
                parameters.Add("Module_Title_En", tbl_def_Lectures_x.Module_Title_En, System.Data.DbType.String);
                parameters.Add("Files", tbl_def_Lectures_x.Files, System.Data.DbType.String);
                parameters.Add("Level_Ar", tbl_def_Lectures_x.Level_Ar, System.Data.DbType.String);
                parameters.Add("Level_En", tbl_def_Lectures_x.Level_En, System.Data.DbType.String);
                parameters.Add("Prerequests_Ar", tbl_def_Lectures_x.Prerequests_Ar, System.Data.DbType.String);
                parameters.Add("Prerequests_Ar", tbl_def_Lectures_x.Prerequests_En, System.Data.DbType.String);
                parameters.Add("Notes", tbl_def_Lectures_x.Notes, System.Data.DbType.String);   //Raw sql Method
                await conn.ExecuteAsync("sp_Update_Tbl_def_Lectures_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
                Debug.WriteLine("Done . . .");
            }
            return true;
        }

        //Update row in Tbl_def_Lectures_x Table -----------------------------------------------------------------------
        public async Task<bool> Tbl_def_Lectures_xDelete(int ID)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, System.Data.DbType.Int32);
                await conn.ExecuteAsync("sp_Delete_Tbl_def_Lectures_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //List Tbl_def_Lectures_x Table        
        public async Task<IEnumerable<Tbl_def_Lectures_x>> Tbl_def_Lectures_xList()
        {
            IEnumerable<Tbl_def_Lectures_x> tbl_def_Lectures_xs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_def_Lectures_xs = conn.Query<Tbl_def_Lectures_x>("sp_Select_Tbl_def_Lectures_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Lectures_xs;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Lectures_xs = await conn.QueryAsync<Tbl_def_Lectures_x>("sp_Select_Tbl_def_Lectures_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Lectures_xs;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Lectures_xs = await conn.QueryAsync<Tbl_def_Lectures_x>("sp_Select_Tbl_def_Lectures_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Lectures_xs;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //One Tbl_def_Lectures_x by ID        
        public Tbl_def_Lectures_x Tbl_def_Lectures_xOne(int ID)
        {
            Tbl_def_Lectures_x tbl_def_Lectures_x;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from Tbl_def_Lectures_x where ID=" + ID.ToString();
                Debug.WriteLine(Querystring);
                try
                {
                    tbl_def_Lectures_x = conn.QuerySingle<Tbl_def_Lectures_x>(Querystring, ID, commandType: CommandType.Text);
                    return tbl_def_Lectures_x;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Lectures_x = conn.QuerySingle<Tbl_def_Lectures_x>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Lectures_x;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Lectures_x = conn.QuerySingle<Tbl_def_Lectures_x>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Lectures_x;
                }
            }
        }
    }
}
