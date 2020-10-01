using AjaTech_Blazor.Data.IServices;
using AjaTech_Blazor.Data.ViewModels;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Services
{
    public class Tbl_def_Licences_Services : ITbl_def_Licences
    {
        // Data Base 
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_def_Licences_Services(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        // Delete
        public async Task<bool> Tbl_def_Licences_Delete(int ID)
        {
            using (var con = new SqlConnection(_configuration.Value))
            {
                var Parameter = new DynamicParameters();
                Parameter.Add("pID", ID, System.Data.DbType.Int32);
                await con.ExecuteAsync("sp_Delete_Tbl_def_Licences",Parameter,commandType:System.Data.CommandType.StoredProcedure);
            }
            return true ;
            }

        //  Insert
        public async Task<bool> Tbl_def_Licences_Insert(Tbl_def_Licences tbl_def_Licences)
        {
            using (var con = new SqlConnection(_configuration.Value))
            {
                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("pLicence_Title_Ar", tbl_def_Licences.Licence_Title_Ar , System.Data.DbType.String);
                    parameters.Add("pLicence_Title_En", tbl_def_Licences.Licence_Title_En, System.Data.DbType.String);
                    parameters.Add("pLicence_Issuer_Ar", tbl_def_Licences.Licence_Issuer_Ar , System.Data.DbType.String);
                    parameters.Add("pLicence_Issuer_En", tbl_def_Licences.Licence_Issuer_En, System.Data.DbType.String);
                    parameters.Add("pLicence_From", tbl_def_Licences.Licence_From, System.Data.DbType.String);
                    parameters.Add("pLicence_To", tbl_def_Licences.Licence_To, System.Data.DbType.String);
                    parameters.Add("pLicence_Renew_Date", tbl_def_Licences.Licence_Renew_Date, System.Data.DbType.String);
                    parameters.Add("pLicence_Renew_Fine", tbl_def_Licences.Licence_Renew_Fine, System.Data.DbType.String);
                    parameters.Add("pLicence_Renewal_Fees", tbl_def_Licences.Licence_Renewal_Fees, System.Data.DbType.String);
                    parameters.Add("pLicence_Enabled", tbl_def_Licences.Enabled, System.Data.DbType.Boolean);
                    parameters.Add("pLicence_Archived", tbl_def_Licences.Archived, System.Data.DbType.Boolean);
                    parameters.Add("pLicence_Deleted", tbl_def_Licences.Deleted, System.Data.DbType.Boolean);
                    // Execute StoredProcedure
                    await con.ExecuteAsync("sp_Insert_Tbl_def_Licences", parameters, commandType: System.Data.CommandType.StoredProcedure);
                }
                catch (SqlException SQALex)
                {
                    Debug.WriteLine(SQALex.Message);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return true;
        }
        // List
        public IEnumerable<Tbl_def_Licences> Tbl_def_Licences_List()
        {
            IEnumerable<Tbl_def_Licences> tbl_Def_Licences;
            using (var con =new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_Def_Licences = con.Query<Tbl_def_Licences>("sp_Select_Tbl_def_Licences", commandType: CommandType.StoredProcedure);
                    return tbl_Def_Licences;

                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_Def_Licences = con.Query<Tbl_def_Licences>("sp_Select_Tbl_def_Licences", commandType: CommandType.StoredProcedure);
                    return tbl_Def_Licences;
                }
                catch (Exception Ex)
                {
                    Debug.WriteLine("Errors SQl   : " + Ex.Message);
                    tbl_Def_Licences = con.Query<Tbl_def_Licences>("sp_Select_Tbl_def_Licences", commandType: CommandType.StoredProcedure);
                    return tbl_Def_Licences;
                }
            }
        }
        //  Select One
        public Tbl_def_Licences Tbl_def_Licences_One(int ID)
        {
            Tbl_def_Licences Tbl_def_Licences;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from Tbl_def_Licences where ID=" + ID.ToString();
                Debug.WriteLine(Querystring);
                try
                {
                    Tbl_def_Licences = conn.QuerySingle<Tbl_def_Licences>(Querystring, ID, commandType: CommandType.Text);
                    return Tbl_def_Licences;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    Tbl_def_Licences = conn.QuerySingle<Tbl_def_Licences>(Querystring, commandType: CommandType.Text);
                    return Tbl_def_Licences;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    Tbl_def_Licences = conn.QuerySingle<Tbl_def_Licences>(Querystring, commandType: CommandType.Text);
                    return Tbl_def_Licences;
                }
            }
        }

        public async Task<bool> _Tbl_def_Licences_Update(Tbl_def_Licences tbl_def_Licences)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("pID", tbl_def_Licences.ID, System.Data.DbType.Int32);
                    parameters.Add("pLicence_Title_Ar", tbl_def_Licences.Licence_Title_Ar, System.Data.DbType.String);
                    parameters.Add("pLicence_Title_En", tbl_def_Licences.Licence_Title_En, System.Data.DbType.String);
                    parameters.Add("pLicence_Issuer_Ar", tbl_def_Licences.Licence_Issuer_Ar, System.Data.DbType.String);
                    parameters.Add("pLicence_Issuer_En", tbl_def_Licences.Licence_Issuer_En, System.Data.DbType.String);
                    parameters.Add("pLicence_From", tbl_def_Licences.Licence_From, System.Data.DbType.String);
                    parameters.Add("pLicence_To", tbl_def_Licences.Licence_To, System.Data.DbType.String);
                    parameters.Add("pLicence_Renew_Date", tbl_def_Licences.Licence_Renew_Date, System.Data.DbType.String);
                    parameters.Add("pLicence_Renew_Fine", tbl_def_Licences.Licence_Renew_Fine, System.Data.DbType.String);
                    parameters.Add("pLicence_Renewal_Fees", tbl_def_Licences.Licence_Renewal_Fees, System.Data.DbType.String);
                    parameters.Add("pLicence_Enabled", tbl_def_Licences.Enabled, System.Data.DbType.Boolean);
                    parameters.Add("pLicence_Archived", tbl_def_Licences.Archived, System.Data.DbType.Boolean);
                    parameters.Add("pLicence_Deleted", tbl_def_Licences.Deleted, System.Data.DbType.Boolean);

                    // Execute StoredProcedure
                    await conn.ExecuteAsync("sp_Update_Tbl_def_Licences", parameters, commandType: System.Data.CommandType.StoredProcedure);
                }
                catch (SqlException SQALex)
                {
                    Debug.WriteLine(SQALex.Message);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

            }
            return true;
        }
    }
}
