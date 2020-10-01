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
using AjaTech_Blazor.Data;

namespace AjaTech_Blazor.Data.IServices
{
    public class Tbl_def_Trainers_xService : ITbl_def_Trainers_xService
    {
        //DataBase connection
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_def_Trainers_xService(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert new row to tbl_def_Trainers_x Table
        public async Task<bool> Tbl_def_Trainers_xInsert(Tbl_def_Trainers_x tbl_def_Trainers_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", tbl_def_Trainers_x.ID, System.Data.DbType.Int32);
                parameters.Add("pName_Ar", tbl_def_Trainers_x.Name_Ar, System.Data.DbType.String);
                parameters.Add("pName_En", tbl_def_Trainers_x.Name_En, System.Data.DbType.String);
                parameters.Add("psex", tbl_def_Trainers_x.sex, System.Data.DbType.String);
                parameters.Add("pBirth_Date", tbl_def_Trainers_x.Birth_Date, System.Data.DbType.DateTime);
                parameters.Add("pPhoto", tbl_def_Trainers_x.Photo, System.Data.DbType.String);
                parameters.Add("pCertificates", tbl_def_Trainers_x.Certificates, System.Data.DbType.String);
                parameters.Add("pCertificates_Photoes", tbl_def_Trainers_x.Certificates_Photoes, System.Data.DbType.String);
                parameters.Add("pRegDate", tbl_def_Trainers_x.RegDate, System.Data.DbType.DateTime);
                parameters.Add("pEnabled", tbl_def_Trainers_x.Enabled, System.Data.DbType.Boolean);
                parameters.Add("planguages", tbl_def_Trainers_x.languages, System.Data.DbType.String);
                parameters.Add("pMothor_Tong", tbl_def_Trainers_x.Mothor_Tong, System.Data.DbType.String);
                parameters.Add("pAvailable_From", tbl_def_Trainers_x.Available_From, System.Data.DbType.DateTime);
                parameters.Add("pAvailable_To", tbl_def_Trainers_x.Available_To, System.Data.DbType.DateTime);
                parameters.Add("pDealing_Worning", tbl_def_Trainers_x.Dealing_Worning, System.Data.DbType.String);
                parameters.Add("pPricing_Policy", tbl_def_Trainers_x.Pricing_Policy, System.Data.DbType.String);
                parameters.Add("pCountry", tbl_def_Trainers_x.Country, System.Data.DbType.String);
                parameters.Add("pCity", tbl_def_Trainers_x.City, System.Data.DbType.String);
                parameters.Add("paddress", tbl_def_Trainers_x.address, System.Data.DbType.String);
                parameters.Add("pLandLines", tbl_def_Trainers_x.LandLines, System.Data.DbType.String);
                parameters.Add("pPnones", tbl_def_Trainers_x.Pnones, System.Data.DbType.String);
                parameters.Add("pEMail", tbl_def_Trainers_x.EMail, System.Data.DbType.String);
                parameters.Add("pFaceBook", tbl_def_Trainers_x.FaceBook, System.Data.DbType.String);
                parameters.Add("pJob", tbl_def_Trainers_x.Job, System.Data.DbType.String);
                parameters.Add("pGender", tbl_def_Trainers_x.Gender, System.Data.DbType.String);
                parameters.Add("pNotes", tbl_def_Trainers_x.Notes, System.Data.DbType.String);     //Raw sql Method
                await conn.ExecuteAsync("sp_Insert_tbl_def_Trainers_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        //Update row in tbl_def_Trainers_x Table
        public async Task<bool> Tbl_def_Trainers_xUpdate(Tbl_def_Trainers_x tbl_def_Trainers_x)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                Debug.WriteLine("############################");
                Debug.WriteLine(">> " + tbl_def_Trainers_x.ID);
                var parameters = new DynamicParameters();
                parameters.Add("pID", tbl_def_Trainers_x.ID, System.Data.DbType.Int32);
                parameters.Add("pName_Ar", tbl_def_Trainers_x.Name_Ar, System.Data.DbType.String);
                parameters.Add("pName_En", tbl_def_Trainers_x.Name_En, System.Data.DbType.String);
                parameters.Add("psex", tbl_def_Trainers_x.sex, System.Data.DbType.String);
                parameters.Add("pBirth_Date", tbl_def_Trainers_x.Birth_Date, System.Data.DbType.DateTime);
                parameters.Add("pPhoto", tbl_def_Trainers_x.Photo, System.Data.DbType.String);
                parameters.Add("pCertificates", tbl_def_Trainers_x.Certificates, System.Data.DbType.String);
                parameters.Add("pCertificates_Photoes", tbl_def_Trainers_x.Certificates_Photoes, System.Data.DbType.String);
                parameters.Add("pRegDate", tbl_def_Trainers_x.RegDate, System.Data.DbType.DateTime);
                parameters.Add("pEnabled", tbl_def_Trainers_x.Enabled, System.Data.DbType.Boolean);
                parameters.Add("planguages", tbl_def_Trainers_x.languages, System.Data.DbType.String);
                parameters.Add("pMothor_Tong", tbl_def_Trainers_x.Mothor_Tong, System.Data.DbType.String);
                parameters.Add("pAvailable_From", tbl_def_Trainers_x.Available_From, System.Data.DbType.DateTime);
                parameters.Add("pAvailable_To", tbl_def_Trainers_x.Available_To, System.Data.DbType.DateTime);
                parameters.Add("pDealing_Worning", tbl_def_Trainers_x.Dealing_Worning, System.Data.DbType.String);
                parameters.Add("pPricing_Policy", tbl_def_Trainers_x.Pricing_Policy, System.Data.DbType.String);
                parameters.Add("pCountry", tbl_def_Trainers_x.Country, System.Data.DbType.String);
                parameters.Add("pCity", tbl_def_Trainers_x.City, System.Data.DbType.String);
                parameters.Add("paddress", tbl_def_Trainers_x.address, System.Data.DbType.String);
                parameters.Add("pLandLines", tbl_def_Trainers_x.LandLines, System.Data.DbType.String);
                parameters.Add("pPnones", tbl_def_Trainers_x.Pnones, System.Data.DbType.String);
                parameters.Add("pEMail", tbl_def_Trainers_x.EMail, System.Data.DbType.String);
                parameters.Add("pFaceBook", tbl_def_Trainers_x.FaceBook, System.Data.DbType.String);
                parameters.Add("pJob", tbl_def_Trainers_x.Job, System.Data.DbType.String);
                parameters.Add("pGender", tbl_def_Trainers_x.Gender, System.Data.DbType.String);
                parameters.Add("pNotes", tbl_def_Trainers_x.Notes, System.Data.DbType.String);
                Debug.WriteLine(">>----------- " + tbl_def_Trainers_x.Name_En);
                await conn.ExecuteAsync("sp_Update_tbl_def_Trainers_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
                Debug.WriteLine("############################");
                Debug.WriteLine(">> " + parameters.Get<int>("pID"));
                  }
            return true;
        }
        //Update row in tbl_def_Trainers_x Table -----------------------------------------------------------------------
        public async Task<bool> Tbl_def_Trainers_xDelete(int ID)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, System.Data.DbType.Int32);
                await conn.ExecuteAsync("sp_Delete_tbl_def_Trainers_x", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //List tbl_def_Trainers_x Table        
        public async Task<IEnumerable<Tbl_def_Trainers_x>> Tbl_def_Trainers_xList()
        {
            IEnumerable<Tbl_def_Trainers_x> tbl_def_Trainers_xs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    Debug.WriteLine(conn.ConnectionString);
                    Debug.WriteLine(conn.State);
                    conn.Open();
                    Debug.WriteLine(conn.State);
                    Debug.WriteLine("AAAAAAAAAAA");

                    tbl_def_Trainers_xs =  conn.Query<Tbl_def_Trainers_x>("sp_Select_tbl_def_Trainers_x", commandType: CommandType.StoredProcedure);
                    Debug.WriteLine("scaler : " + conn.ExecuteScalar("sp_Select_tbl_def_Trainers_x", commandType: CommandType.StoredProcedure).ToString());
                    //tbl_def_Trainers_xs = await conn.QueryAsync<Tbl_def_Trainers_x>("sp_Select_tbl_def_Trainers_x", commandType: CommandType.StoredProcedure);
                    Debug.WriteLine(conn.State);
                    Debug.WriteLine("AAAAAAAAAAA_________"); 
                    return tbl_def_Trainers_xs;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Trainers_xs = await conn.QueryAsync<Tbl_def_Trainers_x>("sp_Select_tbl_def_Trainers_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Trainers_xs;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Trainers_xs = await conn.QueryAsync<Tbl_def_Trainers_x>("sp_Select_tbl_def_Trainers_x", commandType: CommandType.StoredProcedure);
                    return tbl_def_Trainers_xs;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //One tbl_def_Trainers_x by ID        
        public Tbl_def_Trainers_x Tbl_def_Trainers_xOne(int ID)
        {
            Tbl_def_Trainers_x tbl_def_Trainers_x;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from tbl_def_Trainers_x where ID=" + ID.ToString();
                try
                {
                    tbl_def_Trainers_x = conn.QuerySingle<Tbl_def_Trainers_x>(Querystring, ID, commandType: CommandType.Text);
                    return tbl_def_Trainers_x;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Trainers_x = conn.QuerySingle<Tbl_def_Trainers_x>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Trainers_x;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Trainers_x = conn.QuerySingle<Tbl_def_Trainers_x>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Trainers_x;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------

        public async Task<IEnumerable<string>> Tbl_def_Trainers_xList_Jobs()
        {
            IEnumerable<string> tbl_def_Trainers_x_Jobs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_def_Trainers_x_Jobs = conn.Query<string>("sp_Select_tbl_def_Trainers_x_Jobs", commandType: CommandType.StoredProcedure);
                    return tbl_def_Trainers_x_Jobs;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Trainers_x_Jobs = await conn.QueryAsync<string>("sp_Select_tbl_def_Trainers_x_Jobs", commandType: CommandType.StoredProcedure);
                    return tbl_def_Trainers_x_Jobs;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Trainers_x_Jobs = await conn.QueryAsync<string>("sp_Select_tbl_def_Trainers_x_Jobs", commandType: CommandType.StoredProcedure);
                    return tbl_def_Trainers_x_Jobs;
                }
            }
        }       
    }
}
