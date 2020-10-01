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
    public class Tbl_def_Courses_Types_xService : ITbl_def_Courses_Types_xService
    {
        //DataBase connection
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_def_Courses_Types_xService(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert new row to Tbl_def_Courses_Types_x Table
        public async Task<bool> Tbl_def_Courses_Types_xInsert(Tbl_def_Courses_Types_x tbl_def_Courses_Types_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pTitle_Ar", tbl_def_Courses_Types_x.Title_En, System.Data.DbType.String);
                parameters.Add("pTitle_En", tbl_def_Courses_Types_x.Title_Ar, System.Data.DbType.String);
                parameters.Add("pDescription_En", tbl_def_Courses_Types_x.Description_En, System.Data.DbType.String);
                parameters.Add("pDescription_Ar", tbl_def_Courses_Types_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("pPhoto", tbl_def_Courses_Types_x.Photo, System.Data.DbType.String);
                parameters.Add("pEnabled", tbl_def_Courses_Types_x.Enabled, System.Data.DbType.Boolean);
                parameters.Add("pNotes", tbl_def_Courses_Types_x.Notes, System.Data.DbType.String);
                //Raw sql Method
                await conn.ExecuteAsync("sp_Insert_Tbl_def_Courses_Types_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        //Update row in Tbl_def_Courses_Types_x Table
        public async Task<bool> Tbl_def_Courses_Types_xUpdate(Tbl_def_Courses_Types_x tbl_def_Courses_Types_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("pID", tbl_def_Courses_Types_x.ID, System.Data.DbType.Int32);
                parameters.Add("pTitle_Ar", tbl_def_Courses_Types_x.Title_En, System.Data.DbType.String);
                parameters.Add("pTitle_En", tbl_def_Courses_Types_x.Title_Ar, System.Data.DbType.String);
                parameters.Add("pDescription_En", tbl_def_Courses_Types_x.Description_En, System.Data.DbType.String);
                parameters.Add("pDescription_Ar", tbl_def_Courses_Types_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("pPhoto", tbl_def_Courses_Types_x.Photo, System.Data.DbType.String);
                parameters.Add("pEnabled", tbl_def_Courses_Types_x.Enabled, System.Data.DbType.Boolean);
                parameters.Add("pNotes", tbl_def_Courses_Types_x.Notes, System.Data.DbType.String);
                await conn.ExecuteAsync("sp_Update_Tbl_def_Courses_Types_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }

        //Update row in Tbl_def_Courses_Types_x Table -----------------------------------------------------------------------
        public async Task<bool> Tbl_def_Courses_Types_xDelete(int ID)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, System.Data.DbType.Int32);
                await conn.ExecuteAsync("sp_Delete_Tbl_def_Courses_Types_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //List Tbl_def_Courses_Types_x Table        
        public async Task<IEnumerable<Tbl_def_Courses_Types_x>> Tbl_def_Courses_Types_xList()
        {
            IEnumerable<Tbl_def_Courses_Types_x> tbl_def_Courses_Types_xs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_def_Courses_Types_xs = conn.Query<Tbl_def_Courses_Types_x>("sp_Select_Tbl_def_Courses_Types_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Courses_Types_xs;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Courses_Types_xs = await conn.QueryAsync<Tbl_def_Courses_Types_x>("sp_Select_Tbl_def_Courses_Types_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Courses_Types_xs;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Courses_Types_xs = await conn.QueryAsync<Tbl_def_Courses_Types_x>("sp_Select_Tbl_def_Courses_Types_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Courses_Types_xs;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //One Tbl_def_Courses_Types_x by ID        
        public Tbl_def_Courses_Types_x Tbl_def_Courses_Types_xOne(int ID)
        {
            Tbl_def_Courses_Types_x tbl_def_Courses_Types_x;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from Tbl_def_Courses_Types_x where ID=" + ID.ToString();
                Debug.WriteLine(Querystring);
                try
                {
                    tbl_def_Courses_Types_x = conn.QuerySingle<Tbl_def_Courses_Types_x>(Querystring, ID, commandType: CommandType.Text);
                    return tbl_def_Courses_Types_x;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Courses_Types_x = conn.QuerySingle<Tbl_def_Courses_Types_x>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Courses_Types_x;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Courses_Types_x = conn.QuerySingle<Tbl_def_Courses_Types_x>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Courses_Types_x;
                }
            }
        }     
    }
}
