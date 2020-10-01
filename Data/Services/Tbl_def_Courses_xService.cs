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
    public class Tbl_def_Courses_xService : ITbl_def_Courses_xService
    {
        //DataBase connection
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_def_Courses_xService(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert new row to Tbl_def_Courses_x Table
        public async Task<bool> Tbl_def_Courses_xInsert(Tbl_def_Courses_x tbl_def_Courses_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pTitle_Ar", tbl_def_Courses_x.Title_En, System.Data.DbType.String);
                parameters.Add("pTitle_En", tbl_def_Courses_x.Title_Ar, System.Data.DbType.String);
                parameters.Add("pDescription_En", tbl_def_Courses_x.Description_En, System.Data.DbType.String);
                parameters.Add("pDescription_Ar", tbl_def_Courses_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("pPhoto", tbl_def_Courses_x.Photo, System.Data.DbType.String);
                parameters.Add("pEnabled", tbl_def_Courses_x.Enabled, System.Data.DbType.Boolean);
                parameters.Add("pCourse_Type_En", tbl_def_Courses_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("pCourse_Type_Ar", tbl_def_Courses_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("pNotes", tbl_def_Courses_x.Notes, System.Data.DbType.String);
                //Raw sql Method
                await conn.ExecuteAsync("sp_Insert_Tbl_def_Courses_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        //Update row in Tbl_def_Courses_x Table
        public async Task<bool> Tbl_def_Courses_xUpdate(Tbl_def_Courses_x tbl_def_Courses_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                Debug.WriteLine(tbl_def_Courses_x.ID);
                var parameters = new DynamicParameters();
                parameters.Add("pID", tbl_def_Courses_x.ID, System.Data.DbType.Int32);
                parameters.Add("pTitle_Ar", tbl_def_Courses_x.Title_En, System.Data.DbType.String);
                parameters.Add("pTitle_En", tbl_def_Courses_x.Title_Ar, System.Data.DbType.String);
                parameters.Add("pDescription_En", tbl_def_Courses_x.Description_En, System.Data.DbType.String);
                parameters.Add("pDescription_Ar", tbl_def_Courses_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("pPhoto", tbl_def_Courses_x.Photo, System.Data.DbType.String);
                parameters.Add("pEnabled", tbl_def_Courses_x.Enabled, System.Data.DbType.Boolean);
                parameters.Add("pCourse_Type_En", tbl_def_Courses_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("pCourse_Type_Ar", tbl_def_Courses_x.Description_Ar, System.Data.DbType.String);
                parameters.Add("pNotes", tbl_def_Courses_x.Notes, System.Data.DbType.String);
                await conn.ExecuteAsync("sp_Update_Tbl_def_Courses_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
                Debug.WriteLine("Done . . .");
            }
            return true;
        }

        //Update row in Tbl_def_Courses_x Table -----------------------------------------------------------------------
        public async Task<bool> Tbl_def_Courses_xDelete(int ID)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, System.Data.DbType.Int32);
                await conn.ExecuteAsync("sp_Delete_Tbl_def_Courses_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //List Tbl_def_Courses_x Table        
        public async Task<IEnumerable<Tbl_def_Courses_x>> Tbl_def_Courses_xList()
        {
            IEnumerable<Tbl_def_Courses_x> tbl_def_Courses_xs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_def_Courses_xs = conn.Query<Tbl_def_Courses_x>("sp_Select_Tbl_def_Courses_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Courses_xs;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Courses_xs = await conn.QueryAsync<Tbl_def_Courses_x>("sp_Select_Tbl_def_Courses_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Courses_xs;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Courses_xs = await conn.QueryAsync<Tbl_def_Courses_x>("sp_Select_Tbl_def_Courses_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Courses_xs;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //One Tbl_def_Courses_x by ID        
        public Tbl_def_Courses_x Tbl_def_Courses_xOne(int ID)
        {
            Tbl_def_Courses_x tbl_def_Courses_x;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from Tbl_def_Courses_x where ID=" + ID.ToString();
                Debug.WriteLine(Querystring);
                try
                {
                    tbl_def_Courses_x = conn.QuerySingle<Tbl_def_Courses_x>(Querystring, ID, commandType: CommandType.Text);
                    return tbl_def_Courses_x;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Courses_x = conn.QuerySingle<Tbl_def_Courses_x>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Courses_x;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Courses_x = conn.QuerySingle<Tbl_def_Courses_x>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Courses_x;
                }
            }
        }
    }
}
