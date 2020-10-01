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
    public class Tbl_def_Company_Braches_yService : ITbl_def_Company_Braches_yService
    {
        //DataBase connection
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_def_Company_Braches_yService(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert new row to Tbl_def_Company_Braches_y Table
        public async Task<bool> Tbl_def_Company_Braches_yInsert(Tbl_def_Company_Braches_y tbl_def_Company_Braches_y)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {

                    //Debug.WriteLine(">> " + conn.ConnectionString);
                    var parameters = new DynamicParameters();
                    //parameters.Add("pID", tbl_def_Company_Braches_y.ID, System.Data.DbType.String);
                    parameters.Add("pBranch_Title_Ar", tbl_def_Company_Braches_y.Branch_Title_Ar, System.Data.DbType.String);
                    parameters.Add("pBranch_Title_En", tbl_def_Company_Braches_y.Branch_Title_En, System.Data.DbType.String);
                    parameters.Add("pBranch_Activities", tbl_def_Company_Braches_y.Branch_Activities, System.Data.DbType.String);
                    parameters.Add("pAddress_Ar", tbl_def_Company_Braches_y.Address_Ar, System.Data.DbType.String);
                    parameters.Add("pAddress_En", tbl_def_Company_Braches_y.Address_En, System.Data.DbType.String);
                    parameters.Add("pBranch_Mobile_A", tbl_def_Company_Braches_y.Branch_Mobile_A, System.Data.DbType.String);
                    parameters.Add("pBranch_Mobile_B", tbl_def_Company_Braches_y.Branch_Mobile_B, System.Data.DbType.String);
                    parameters.Add("pBranch_Mobile_C", tbl_def_Company_Braches_y.Branch_Mobile_C, System.Data.DbType.String);
                    parameters.Add("pBranch_Mobile_D", tbl_def_Company_Braches_y.Branch_Mobile_D, System.Data.DbType.String);
                    parameters.Add("pBranch_Phone_A", tbl_def_Company_Braches_y.Branch_Phone_A, System.Data.DbType.String);
                    parameters.Add("pBranch_Phone_B", tbl_def_Company_Braches_y.Branch_Phone_B, System.Data.DbType.String);
                    parameters.Add("pBranch_Phone_C", tbl_def_Company_Braches_y.Branch_Phone_C, System.Data.DbType.String);
                    parameters.Add("pBranch_Phone_D", tbl_def_Company_Braches_y.Branch_Phone_D, System.Data.DbType.String);
                    parameters.Add("pBranch_Suggestions_Complains_Phone", tbl_def_Company_Braches_y.Branch_Suggestions_Complains_Phone, System.Data.DbType.String);
                    parameters.Add("pBranch_Executive_Manager_Name_Ar", tbl_def_Company_Braches_y.Branch_Executive_Manager_Name_Ar, System.Data.DbType.String);
                    parameters.Add("pBranch_Sales_Manager_Name_Ar", tbl_def_Company_Braches_y.Branch_Sales_Manager_Name_Ar, System.Data.DbType.String);
                    parameters.Add("pBranch_HR_Manager_Name_Ar", tbl_def_Company_Braches_y.Branch_HR_Manager_Name_Ar, System.Data.DbType.String);
                    parameters.Add("pBranch_Accountancy_Manager_Name_Ar", tbl_def_Company_Braches_y.Branch_Accountancy_Manager_Name_Ar, System.Data.DbType.String);
                    parameters.Add("pBranch_Executive_Manager_Name_En", tbl_def_Company_Braches_y.Branch_Executive_Manager_Name_En, System.Data.DbType.String);
                    parameters.Add("pBranch_Sales_Manager_Name_En", tbl_def_Company_Braches_y.Branch_Sales_Manager_Name_En, System.Data.DbType.String);
                    parameters.Add("pBranch_HR_Manager_Name_En", tbl_def_Company_Braches_y.Branch_HR_Manager_Name_En, System.Data.DbType.String);
                    parameters.Add("pBranch_Accountancy_Manager_Name_En", tbl_def_Company_Braches_y.Branch_Accountancy_Manager_Name_En, System.Data.DbType.String);
                    parameters.Add("pBranch_Executive_Manager_Phone", tbl_def_Company_Braches_y.Branch_Executive_Manager_Phone, System.Data.DbType.String);
                    parameters.Add("pBranch_Sales_Manager_Name_Phone", tbl_def_Company_Braches_y.Branch_Sales_Manager_Name_Phone, System.Data.DbType.String);
                    parameters.Add("pBranch_HR_Manager_Name_Phone", tbl_def_Company_Braches_y.Branch_HR_Manager_Name_Phone, System.Data.DbType.String);
                    parameters.Add("pBranch_Accountancy_Manager_Phone", tbl_def_Company_Braches_y.Branch_Accountancy_Manager_Phone, System.Data.DbType.String);
                    parameters.Add("pBranch_Executive_Manager_Signature", tbl_def_Company_Braches_y.Branch_Executive_Manager_Signature, System.Data.DbType.String);
                    parameters.Add("pBranch_Sales_Manager_Name_Signature", tbl_def_Company_Braches_y.Branch_Sales_Manager_Name_Signature, System.Data.DbType.String);
                    parameters.Add("pBranch_HR_Manager_Name_Signature", tbl_def_Company_Braches_y.Branch_HR_Manager_Name_Signature, System.Data.DbType.String);
                    parameters.Add("pBranch_Accountancy_Manager_Signature", tbl_def_Company_Braches_y.Branch_Accountancy_Manager_Signature, System.Data.DbType.String);
                    parameters.Add("pOpen_Hour", tbl_def_Company_Braches_y.Open_Hour, System.Data.DbType.Time);
                    parameters.Add("pClose_Hour", tbl_def_Company_Braches_y.Close_Hour, System.Data.DbType.Time);
                    parameters.Add("pDays_Of_Week", tbl_def_Company_Braches_y.Days_Of_Week, System.Data.DbType.String);
                    parameters.Add("pOperating_Licence", tbl_def_Company_Braches_y.Operating_Licence, System.Data.DbType.String);
                    parameters.Add("pOperating_Licence_From", tbl_def_Company_Braches_y.Operating_Licence_From, System.Data.DbType.Date);
                    parameters.Add("pOperating_Licence_To", tbl_def_Company_Braches_y.Operating_Licence_To, System.Data.DbType.Date);
                    parameters.Add("pOperating_Licence_Renew_Date", tbl_def_Company_Braches_y.Operating_Licence_Renew_Date, System.Data.DbType.Date);
                    parameters.Add("pOperating_Licence_Renew_Fine", tbl_def_Company_Braches_y.Operating_Licence_Renew_Fine, System.Data.DbType.Decimal);
                    parameters.Add("pOperating_Licence_B", tbl_def_Company_Braches_y.Operating_Licence_B, System.Data.DbType.String);
                    parameters.Add("pOperating_Licence_B_From", tbl_def_Company_Braches_y.Operating_Licence_B_From, System.Data.DbType.Date);
                    parameters.Add("pOperating_Licence_B_To", tbl_def_Company_Braches_y.Operating_Licence_B_To, System.Data.DbType.Date);
                    parameters.Add("pOperating_Licence_Renew_B_Date", tbl_def_Company_Braches_y.Operating_Licence_Renew_B_Date, System.Data.DbType.Date);
                    parameters.Add("pOperating_Licence_Renew_B_Fine", tbl_def_Company_Braches_y.Operating_Licence_Renew_B_Fine, System.Data.DbType.Decimal);
                    parameters.Add("pOperating_Licence_C", tbl_def_Company_Braches_y.Operating_Licence_C, System.Data.DbType.String);
                    parameters.Add("pOperating_Licence_C_From", tbl_def_Company_Braches_y.Operating_Licence_C_From, System.Data.DbType.Date);
                    parameters.Add("pOperating_Licence_C_To", tbl_def_Company_Braches_y.Operating_Licence_C_To, System.Data.DbType.Date);
                    parameters.Add("pOperating_Licence_Renew_C_Date", tbl_def_Company_Braches_y.Operating_Licence_Renew_C_Date, System.Data.DbType.Date);
                    parameters.Add("pOperating_Licence_Renew_C_Fine", tbl_def_Company_Braches_y.Operating_Licence_Renew_C_Fine, System.Data.DbType.Decimal);
                    parameters.Add("pBranch_Notes_Ar", tbl_def_Company_Braches_y.Branch_Notes_Ar, System.Data.DbType.String);
                    parameters.Add("pBranch_Notes_En", tbl_def_Company_Braches_y.Branch_Notes_En, System.Data.DbType.String);
                    parameters.Add("pBranch_Enabled", tbl_def_Company_Braches_y.Enabled, System.Data.DbType.Boolean);
                    parameters.Add("pBranch_Archived", tbl_def_Company_Braches_y.Archived, System.Data.DbType.Boolean);
                    parameters.Add("pBranch_Deleted", tbl_def_Company_Braches_y.Deleted, System.Data.DbType.Boolean);

                    //Raw sql Method
                    await conn.ExecuteAsync("sp_Insert_Tbl_def_Company_Branches_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
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
        //Update row in Tbl_def_Company_Braches_y Table
        public async Task<bool> Tbl_def_Company_Braches_yUpdate(Tbl_def_Company_Braches_y tbl_def_Company_Braches_y)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                { 
                var parameters = new DynamicParameters();
                parameters.Add("pID", tbl_def_Company_Braches_y.ID, System.Data.DbType.String);
                parameters.Add("pBranch_Title_Ar", tbl_def_Company_Braches_y.Branch_Title_Ar, System.Data.DbType.String);
                parameters.Add("pBranch_Title_En", tbl_def_Company_Braches_y.Branch_Title_En, System.Data.DbType.String);
                parameters.Add("pBranch_Activities", tbl_def_Company_Braches_y.Branch_Activities, System.Data.DbType.String);
                parameters.Add("pAddress_Ar", tbl_def_Company_Braches_y.Address_Ar, System.Data.DbType.String);
                parameters.Add("pAddress_En", tbl_def_Company_Braches_y.Address_En, System.Data.DbType.String);
                parameters.Add("pBranch_Mobile_A", tbl_def_Company_Braches_y.Branch_Mobile_A, System.Data.DbType.String);
                parameters.Add("pBranch_Mobile_B", tbl_def_Company_Braches_y.Branch_Mobile_B, System.Data.DbType.String);
                parameters.Add("pBranch_Mobile_C", tbl_def_Company_Braches_y.Branch_Mobile_C, System.Data.DbType.String);
                parameters.Add("pBranch_Mobile_D", tbl_def_Company_Braches_y.Branch_Mobile_D, System.Data.DbType.String);
                parameters.Add("pBranch_Phone_A", tbl_def_Company_Braches_y.Branch_Phone_A, System.Data.DbType.String);
                parameters.Add("pBranch_Phone_B", tbl_def_Company_Braches_y.Branch_Phone_B, System.Data.DbType.String);
                parameters.Add("pBranch_Phone_C", tbl_def_Company_Braches_y.Branch_Phone_C, System.Data.DbType.String);
                parameters.Add("pBranch_Phone_D", tbl_def_Company_Braches_y.Branch_Phone_D, System.Data.DbType.String);
                parameters.Add("pBranch_Suggestions_Complains_Phone", tbl_def_Company_Braches_y.Branch_Suggestions_Complains_Phone, System.Data.DbType.String);
                parameters.Add("pBranch_Executive_Manager_Name_Ar", tbl_def_Company_Braches_y.Branch_Executive_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pBranch_Sales_Manager_Name_Ar", tbl_def_Company_Braches_y.Branch_Sales_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pBranch_HR_Manager_Name_Ar", tbl_def_Company_Braches_y.Branch_HR_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pBranch_Accountancy_Manager_Name_Ar", tbl_def_Company_Braches_y.Branch_Accountancy_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pBranch_Executive_Manager_Name_En", tbl_def_Company_Braches_y.Branch_Executive_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pBranch_Sales_Manager_Name_En", tbl_def_Company_Braches_y.Branch_Sales_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pBranch_HR_Manager_Name_En", tbl_def_Company_Braches_y.Branch_HR_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pBranch_Accountancy_Manager_Name_En", tbl_def_Company_Braches_y.Branch_Accountancy_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pBranch_Executive_Manager_Phone", tbl_def_Company_Braches_y.Branch_Executive_Manager_Phone, System.Data.DbType.String);
                parameters.Add("pBranch_Sales_Manager_Name_Phone", tbl_def_Company_Braches_y.Branch_Sales_Manager_Name_Phone, System.Data.DbType.String);
                parameters.Add("pBranch_HR_Manager_Name_Phone", tbl_def_Company_Braches_y.Branch_HR_Manager_Name_Phone, System.Data.DbType.String);
                parameters.Add("pBranch_Accountancy_Manager_Phone", tbl_def_Company_Braches_y.Branch_Accountancy_Manager_Phone, System.Data.DbType.String);
                parameters.Add("pBranch_Executive_Manager_Signature", tbl_def_Company_Braches_y.Branch_Executive_Manager_Signature, System.Data.DbType.String);
                parameters.Add("pBranch_Sales_Manager_Name_Signature", tbl_def_Company_Braches_y.Branch_Sales_Manager_Name_Signature, System.Data.DbType.String);
                parameters.Add("pBranch_HR_Manager_Name_Signature", tbl_def_Company_Braches_y.Branch_HR_Manager_Name_Signature, System.Data.DbType.String);
                parameters.Add("pBranch_Accountancy_Manager_Signature", tbl_def_Company_Braches_y.Branch_Accountancy_Manager_Signature, System.Data.DbType.String);
                parameters.Add("pOpen_Hour", tbl_def_Company_Braches_y.Open_Hour, System.Data.DbType.Time);
                parameters.Add("pClose_Hour", tbl_def_Company_Braches_y.Close_Hour, System.Data.DbType.Time);
                parameters.Add("pDays_Of_Week", tbl_def_Company_Braches_y.Days_Of_Week, System.Data.DbType.String);
                parameters.Add("pOperating_Licence", tbl_def_Company_Braches_y.Operating_Licence, System.Data.DbType.String);
                parameters.Add("pOperating_Licence_From", tbl_def_Company_Braches_y.Operating_Licence_From, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_To", tbl_def_Company_Braches_y.Operating_Licence_To, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_Date", tbl_def_Company_Braches_y.Operating_Licence_Renew_Date, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_Fine", tbl_def_Company_Braches_y.Operating_Licence_Renew_Fine, System.Data.DbType.Decimal);
                parameters.Add("pOperating_Licence_B", tbl_def_Company_Braches_y.Operating_Licence_B, System.Data.DbType.String);
                parameters.Add("pOperating_Licence_B_From", tbl_def_Company_Braches_y.Operating_Licence_B_From, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_B_To", tbl_def_Company_Braches_y.Operating_Licence_B_To, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_B_Date", tbl_def_Company_Braches_y.Operating_Licence_Renew_B_Date, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_B_Fine", tbl_def_Company_Braches_y.Operating_Licence_Renew_B_Fine, System.Data.DbType.Decimal);
                parameters.Add("pOperating_Licence_C", tbl_def_Company_Braches_y.Operating_Licence_C, System.Data.DbType.String);
                parameters.Add("pOperating_Licence_C_From", tbl_def_Company_Braches_y.Operating_Licence_C_From, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_C_To", tbl_def_Company_Braches_y.Operating_Licence_C_To, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_C_Date", tbl_def_Company_Braches_y.Operating_Licence_Renew_C_Date, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_C_Fine", tbl_def_Company_Braches_y.Operating_Licence_Renew_C_Fine, System.Data.DbType.Decimal);
                parameters.Add("pBranch_Notes_Ar", tbl_def_Company_Braches_y.Branch_Notes_Ar, System.Data.DbType.String);
                parameters.Add("pBranch_Notes_En", tbl_def_Company_Braches_y.Branch_Notes_En, System.Data.DbType.String);
                    parameters.Add("pBranch_Enabled", tbl_def_Company_Braches_y.Enabled, System.Data.DbType.Boolean);
                    parameters.Add("pBranch_Archived", tbl_def_Company_Braches_y.Archived, System.Data.DbType.Boolean);
                    parameters.Add("pBranch_Deleted", tbl_def_Company_Braches_y.Deleted, System.Data.DbType.Boolean);
                    //Raw sql Method

                    await conn.ExecuteAsync("sp_Update_Tbl_def_Company_Braches_y", parameters, commandType: System.Data.CommandType.StoredProcedure);

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

        //Delete row in Tbl_def_Company_Braches_y Table -----------------------------------------------------------------------
        public async Task<bool> Tbl_def_Company_Braches_yDelete(int ID)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, System.Data.DbType.Int32);
                await conn.ExecuteAsync("sp_Delete_Tbl_def_Company_Braches_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //List Tbl_def_Company_Braches_y Table        
        public IEnumerable<Tbl_def_Company_Braches_y> Tbl_def_Company_Braches_yList()
        {
            IEnumerable<Tbl_def_Company_Braches_y> tbl_def_Company_Braches_ys;
            //Tbl_def_Company_Braches_y tbl_def_Company_Braches_ys;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_def_Company_Braches_ys = conn.Query<Tbl_def_Company_Braches_y>("sp_Select_Tbl_def_Company_Braches_y", commandType: CommandType.StoredProcedure);
                    return tbl_def_Company_Braches_ys;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Company_Braches_ys = conn.Query<Tbl_def_Company_Braches_y>("sp_Select_Tbl_def_Company_Braches_y", commandType: CommandType.StoredProcedure);
                    return tbl_def_Company_Braches_ys;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Company_Braches_ys = conn.Query<Tbl_def_Company_Braches_y>("sp_Select_Tbl_def_Company_Braches_y", commandType: CommandType.StoredProcedure);
                    return tbl_def_Company_Braches_ys;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //One Tbl_def_Company_Braches_y by ID        
        public Tbl_def_Company_Braches_y Tbl_def_Company_Braches_yOne(int ID)
        {
            Tbl_def_Company_Braches_y tbl_def_Company_Braches_y;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from Tbl_def_Company_Braches_y where ID=" + ID.ToString();
                Debug.WriteLine(Querystring);
                try
                {
                    tbl_def_Company_Braches_y = conn.QuerySingle<Tbl_def_Company_Braches_y>(Querystring, ID, commandType: CommandType.Text);
                    return tbl_def_Company_Braches_y;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Company_Braches_y = conn.QuerySingle<Tbl_def_Company_Braches_y>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Company_Braches_y;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Company_Braches_y = conn.QuerySingle<Tbl_def_Company_Braches_y>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Company_Braches_y;
                }
            }
        }
    }
}
