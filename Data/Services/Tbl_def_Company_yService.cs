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
    public class Tbl_def_Company_yService : ITbl_def_Company_yService
    {
        //DataBase connection
        private readonly SqlConnectionConfiguration _configuration;
        public Tbl_def_Company_yService(SqlConnectionConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        //Insert new row to Tbl_def_Company_y Table
        public async Task<bool> Tbl_def_Company_yInsert(Tbl_def_Company_y tbl_def_Company_y)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pTitle_Ar", tbl_def_Company_y.Title_Ar, System.Data.DbType.String);
                parameters.Add("pTitle_En", tbl_def_Company_y.Title_En, System.Data.DbType.String);
                parameters.Add("pSlogan_A_Ar", tbl_def_Company_y.Slogan_A_Ar, System.Data.DbType.String);
                parameters.Add("pSlogan_A_En", tbl_def_Company_y.Slogan_A_En, System.Data.DbType.String);
                parameters.Add("pSlogan_B_Ar", tbl_def_Company_y.Slogan_B_Ar, System.Data.DbType.String);
                parameters.Add("pSlogan_B_En", tbl_def_Company_y.Slogan_B_En, System.Data.DbType.String);
                parameters.Add("pActivities_Ar", tbl_def_Company_y.Activities_Ar, System.Data.DbType.String);
                parameters.Add("pActivities_En", tbl_def_Company_y.Activities_En, System.Data.DbType.String);
                parameters.Add("pHead_Office_Address_Ar", tbl_def_Company_y.Head_Office_Address_Ar, System.Data.DbType.String);
                parameters.Add("pHead_Office_Address_En", tbl_def_Company_y.Head_Office_Address_En, System.Data.DbType.String);
                parameters.Add("pFactory_Address_Ar", tbl_def_Company_y.Factory_Address_Ar, System.Data.DbType.String);
                parameters.Add("pFactory_Address_En", tbl_def_Company_y.Factory_Address_En, System.Data.DbType.String);
                parameters.Add("pInventory_Address_Ar", tbl_def_Company_y.Inventory_Address_Ar, System.Data.DbType.String);
                parameters.Add("pInventory_Address_En", tbl_def_Company_y.Inventory_Address_En, System.Data.DbType.String);
                parameters.Add("pMail_Box", tbl_def_Company_y.Mail_Box, System.Data.DbType.String);
                parameters.Add("pWebSite_Url", tbl_def_Company_y.WebSite_Url, System.Data.DbType.String);
                parameters.Add("pFacebook", tbl_def_Company_y.Facebook, System.Data.DbType.String);
                parameters.Add("pTweeter", tbl_def_Company_y.Tweeter, System.Data.DbType.String);
                parameters.Add("pEmail", tbl_def_Company_y.Email, System.Data.DbType.String);
                parameters.Add("pMobile_A", tbl_def_Company_y.Mobile_A, System.Data.DbType.String);
                parameters.Add("pMobile_B", tbl_def_Company_y.Mobile_B, System.Data.DbType.String);
                parameters.Add("pMobile_C", tbl_def_Company_y.Mobile_C, System.Data.DbType.String);
                parameters.Add("pMobile_D", tbl_def_Company_y.Mobile_D, System.Data.DbType.String);
                parameters.Add("pPhone_A", tbl_def_Company_y.Phone_A, System.Data.DbType.String);
                parameters.Add("pPhone_B", tbl_def_Company_y.Phone_B, System.Data.DbType.String);
                parameters.Add("pPhone_C", tbl_def_Company_y.Phone_C, System.Data.DbType.String);
                parameters.Add("pPhone_D", tbl_def_Company_y.Phone_D, System.Data.DbType.String);
                parameters.Add("pLogo_Color_Big", tbl_def_Company_y.Logo_Color_Big, System.Data.DbType.String);
                parameters.Add("pLogo_Color_Small", tbl_def_Company_y.Logo_Color_Small, System.Data.DbType.String);
                parameters.Add("pLogo_Print_Big", tbl_def_Company_y.Logo_Print_Big, System.Data.DbType.String);
                parameters.Add("pLogo_Print_Small", tbl_def_Company_y.Logo_Print_Small, System.Data.DbType.String);
                parameters.Add("pSuggestions_Complains_Phone", tbl_def_Company_y.Suggestions_Complains_Phone, System.Data.DbType.String);
                parameters.Add("pBanner_Big", tbl_def_Company_y.Banner_Big, System.Data.DbType.String);
                parameters.Add("pBanner_small", tbl_def_Company_y.Banner_small, System.Data.DbType.String);

                //parameters.Add("pPrint_Technical", tbl_def_Company_y.Print_Technical, System.Data.DbType.String);
                //parameters.Add("pPrint_Financial", tbl_def_Company_y.Print_Financial, System.Data.DbType.String);
                //parameters.Add("pPrint_Managing", tbl_def_Company_y.Print_Managing, System.Data.DbType.String);
                //parameters.Add("pPrint_Inventory", tbl_def_Company_y.Print_Inventory, System.Data.DbType.String);
                //parameters.Add("pPrint_Purchases", tbl_def_Company_y.Print_Purchases, System.Data.DbType.String);
                //parameters.Add("pPrint_Sales", tbl_def_Company_y.Print_Sales, System.Data.DbType.String);

                parameters.Add("pOwner_Main", tbl_def_Company_y.Owner_Main, System.Data.DbType.String);
                parameters.Add("pOwner_A", tbl_def_Company_y.Owner_A, System.Data.DbType.String);
                parameters.Add("pOwner_B", tbl_def_Company_y.Owner_B, System.Data.DbType.String);
                parameters.Add("pOwner_C", tbl_def_Company_y.Owner_C, System.Data.DbType.String);
                parameters.Add("pOwner_D", tbl_def_Company_y.Owner_D, System.Data.DbType.String);
                parameters.Add("pTax_Registration_Number", tbl_def_Company_y.Tax_Registration_Number, System.Data.DbType.String);
                parameters.Add("pClass", tbl_def_Company_y.Class, System.Data.DbType.String);
                parameters.Add("pExecutive_Manager_Name_Ar", tbl_def_Company_y.Executive_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pSales_Manager_Name_Ar", tbl_def_Company_y.Sales_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pHR_Manager_Name_Ar", tbl_def_Company_y.HR_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pAccountancy_Manager_Name_Ar", tbl_def_Company_y.Accountancy_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pExecutive_Manager_Name_En", tbl_def_Company_y.Executive_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pSales_Manager_Name_En", tbl_def_Company_y.Sales_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pHR_Manager_Name_En", tbl_def_Company_y.HR_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pAccountancy_Manager_Name_En", tbl_def_Company_y.Accountancy_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pExecutive_Manager_Phone", tbl_def_Company_y.Executive_Manager_Phone, System.Data.DbType.String);
                parameters.Add("pSales_Manager_Name_Phone", tbl_def_Company_y.Sales_Manager_Name_Phone, System.Data.DbType.String);
                parameters.Add("pHR_Manager_Name_Phone", tbl_def_Company_y.HR_Manager_Name_Phone, System.Data.DbType.String);
                parameters.Add("pAccountancy_Manager_Phone", tbl_def_Company_y.Accountancy_Manager_Phone, System.Data.DbType.String);
                parameters.Add("pExecutive_Manager_Signature", tbl_def_Company_y.Executive_Manager_Signature, System.Data.DbType.String);
                parameters.Add("pSales_Manager_Name_Signature", tbl_def_Company_y.Sales_Manager_Name_Signature, System.Data.DbType.String);
                parameters.Add("pHR_Manager_Name_Signature", tbl_def_Company_y.HR_Manager_Name_Signature, System.Data.DbType.String);
                parameters.Add("pAccountancy_Manager_Signature", tbl_def_Company_y.Accountancy_Manager_Signature, System.Data.DbType.String);
                parameters.Add("pOpen_Hour", tbl_def_Company_y.Open_Hour, System.Data.DbType.Time);
                parameters.Add("pClose_Hour", tbl_def_Company_y.Close_Hour, System.Data.DbType.Time);
                parameters.Add("pDays_Of_Week_Ar", tbl_def_Company_y.Days_Of_Week_Ar, System.Data.DbType.String);
                parameters.Add("pDays_Of_Week_En", tbl_def_Company_y.Days_Of_Week_En, System.Data.DbType.String);
                parameters.Add("pOperating_Licence", tbl_def_Company_y.Operating_Licence, System.Data.DbType.String);
                parameters.Add("pOperating_Licence_From", tbl_def_Company_y.Operating_Licence_From, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_To", tbl_def_Company_y.Operating_Licence_To, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_Date", tbl_def_Company_y.Operating_Licence_Renew_Date, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_Fine", tbl_def_Company_y.Operating_Licence_Renew_Fine, System.Data.DbType.Decimal);
                parameters.Add("pOperating_Licence_B", tbl_def_Company_y.Operating_Licence_B, System.Data.DbType.String);
                parameters.Add("pOperating_Licence_B_From", tbl_def_Company_y.Operating_Licence_B_From, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_B_To", tbl_def_Company_y.Operating_Licence_B_To, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_B_Date", tbl_def_Company_y.Operating_Licence_Renew_B_Date, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_B_Fine", tbl_def_Company_y.Operating_Licence_Renew_B_Fine, System.Data.DbType.Decimal);
                parameters.Add("pOperating_Licence_C", tbl_def_Company_y.Operating_Licence_C, System.Data.DbType.String);
                parameters.Add("pOperating_Licence_C_From", tbl_def_Company_y.Operating_Licence_C_From, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_C_To", tbl_def_Company_y.Operating_Licence_C_To, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_C_Date", tbl_def_Company_y.Operating_Licence_Renew_C_Date, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_C_Fine", tbl_def_Company_y.Operating_Licence_Renew_C_Fine, System.Data.DbType.Decimal);
                parameters.Add("pNotes_Ar", tbl_def_Company_y.Notes_Ar, System.Data.DbType.String);
                parameters.Add("pNotes_En", tbl_def_Company_y.Notes_En, System.Data.DbType.String); //Raw sql Method
                await conn.ExecuteAsync("sp_Insert_Tbl_def_Company_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        //Update row in Tbl_def_Company_y Table
        public async Task<bool> Tbl_def_Company_yUpdate(Tbl_def_Company_y tbl_def_Company_y)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("pID", tbl_def_Company_y.ID, System.Data.DbType.Int32);
                parameters.Add("pTitle_Ar", tbl_def_Company_y.Title_Ar, System.Data.DbType.String);
                parameters.Add("pTitle_En", tbl_def_Company_y.Title_En, System.Data.DbType.String);
                parameters.Add("pSlogan_A_Ar", tbl_def_Company_y.Slogan_A_Ar, System.Data.DbType.String);
                parameters.Add("pSlogan_A_En", tbl_def_Company_y.Slogan_A_En, System.Data.DbType.String);
                parameters.Add("pSlogan_B_Ar", tbl_def_Company_y.Slogan_B_Ar, System.Data.DbType.String);
                parameters.Add("pSlogan_B_En", tbl_def_Company_y.Slogan_B_En, System.Data.DbType.String);
                parameters.Add("pActivities_Ar", tbl_def_Company_y.Activities_Ar, System.Data.DbType.String);
                parameters.Add("pActivities_En", tbl_def_Company_y.Activities_En, System.Data.DbType.String);
                parameters.Add("pHead_Office_Address_Ar", tbl_def_Company_y.Head_Office_Address_Ar, System.Data.DbType.String);
                parameters.Add("pHead_Office_Address_En", tbl_def_Company_y.Head_Office_Address_En, System.Data.DbType.String);
                parameters.Add("pFactory_Address_Ar", tbl_def_Company_y.Factory_Address_Ar, System.Data.DbType.String);
                parameters.Add("pFactory_Address_En", tbl_def_Company_y.Factory_Address_En, System.Data.DbType.String);
                parameters.Add("pInventory_Address_Ar", tbl_def_Company_y.Inventory_Address_Ar, System.Data.DbType.String);
                parameters.Add("pInventory_Address_En", tbl_def_Company_y.Inventory_Address_En, System.Data.DbType.String);
                parameters.Add("pMail_Box", tbl_def_Company_y.Mail_Box, System.Data.DbType.String);
                parameters.Add("pWebSite_Url", tbl_def_Company_y.WebSite_Url, System.Data.DbType.String);
                parameters.Add("pFacebook", tbl_def_Company_y.Facebook, System.Data.DbType.String);
                parameters.Add("pTweeter", tbl_def_Company_y.Tweeter, System.Data.DbType.String);
                parameters.Add("pEmail", tbl_def_Company_y.Email, System.Data.DbType.String);
                parameters.Add("pMobile_A", tbl_def_Company_y.Mobile_A, System.Data.DbType.String);
                parameters.Add("pMobile_B", tbl_def_Company_y.Mobile_B, System.Data.DbType.String);
                parameters.Add("pMobile_C", tbl_def_Company_y.Mobile_C, System.Data.DbType.String);
                parameters.Add("pMobile_D", tbl_def_Company_y.Mobile_D, System.Data.DbType.String);
                parameters.Add("pPhone_A", tbl_def_Company_y.Phone_A, System.Data.DbType.String);
                parameters.Add("pPhone_B", tbl_def_Company_y.Phone_B, System.Data.DbType.String);
                parameters.Add("pPhone_C", tbl_def_Company_y.Phone_C, System.Data.DbType.String);
                parameters.Add("pPhone_D", tbl_def_Company_y.Phone_D, System.Data.DbType.String);
                parameters.Add("pLogo_Color_Big", tbl_def_Company_y.Logo_Color_Big, System.Data.DbType.String);
                parameters.Add("pLogo_Color_Small", tbl_def_Company_y.Logo_Color_Small, System.Data.DbType.String);
                parameters.Add("pLogo_Print_Big", tbl_def_Company_y.Logo_Print_Big, System.Data.DbType.String);
                parameters.Add("pLogo_Print_Small", tbl_def_Company_y.Logo_Print_Small, System.Data.DbType.String);
                parameters.Add("pSuggestions_Complains_Phone", tbl_def_Company_y.Suggestions_Complains_Phone, System.Data.DbType.String);
                parameters.Add("pBanner_Big", tbl_def_Company_y.Banner_Big, System.Data.DbType.String);
                parameters.Add("pBanner_small", tbl_def_Company_y.Banner_small, System.Data.DbType.String);

                //parameters.Add("pPrint_Technical", tbl_def_Company_y.Print_Technical, System.Data.DbType.String);
                //parameters.Add("pPrint_Financial", tbl_def_Company_y.Print_Financial, System.Data.DbType.String);
                //parameters.Add("pPrint_Managing", tbl_def_Company_y.Print_Managing, System.Data.DbType.String);
                //parameters.Add("pPrint_Inventory", tbl_def_Company_y.Print_Inventory, System.Data.DbType.String);
                //parameters.Add("pPrint_Purchases", tbl_def_Company_y.Print_Purchases, System.Data.DbType.String);
                //parameters.Add("pPrint_Sales", tbl_def_Company_y.Print_Sales, System.Data.DbType.String);

                parameters.Add("pOwner_Main", tbl_def_Company_y.Owner_Main, System.Data.DbType.String);
                parameters.Add("pOwner_A", tbl_def_Company_y.Owner_A, System.Data.DbType.String);
                parameters.Add("pOwner_B", tbl_def_Company_y.Owner_B, System.Data.DbType.String);
                parameters.Add("pOwner_C", tbl_def_Company_y.Owner_C, System.Data.DbType.String);
                parameters.Add("pOwner_D", tbl_def_Company_y.Owner_D, System.Data.DbType.String);
                parameters.Add("pTax_Registration_Number", tbl_def_Company_y.Tax_Registration_Number, System.Data.DbType.String);
                parameters.Add("pClass", tbl_def_Company_y.Class, System.Data.DbType.String);
                parameters.Add("pExecutive_Manager_Name_Ar", tbl_def_Company_y.Executive_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pSales_Manager_Name_Ar", tbl_def_Company_y.Sales_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pHR_Manager_Name_Ar", tbl_def_Company_y.HR_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pAccountancy_Manager_Name_Ar", tbl_def_Company_y.Accountancy_Manager_Name_Ar, System.Data.DbType.String);
                parameters.Add("pExecutive_Manager_Name_En", tbl_def_Company_y.Executive_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pSales_Manager_Name_En", tbl_def_Company_y.Sales_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pHR_Manager_Name_En", tbl_def_Company_y.HR_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pAccountancy_Manager_Name_En", tbl_def_Company_y.Accountancy_Manager_Name_En, System.Data.DbType.String);
                parameters.Add("pExecutive_Manager_Phone", tbl_def_Company_y.Executive_Manager_Phone, System.Data.DbType.String);
                parameters.Add("pSales_Manager_Name_Phone", tbl_def_Company_y.Sales_Manager_Name_Phone, System.Data.DbType.String);
                parameters.Add("pHR_Manager_Name_Phone", tbl_def_Company_y.HR_Manager_Name_Phone, System.Data.DbType.String);
                parameters.Add("pAccountancy_Manager_Phone", tbl_def_Company_y.Accountancy_Manager_Phone, System.Data.DbType.String);
                parameters.Add("pExecutive_Manager_Signature", tbl_def_Company_y.Executive_Manager_Signature, System.Data.DbType.String);
                parameters.Add("pSales_Manager_Name_Signature", tbl_def_Company_y.Sales_Manager_Name_Signature, System.Data.DbType.String);
                parameters.Add("pHR_Manager_Name_Signature", tbl_def_Company_y.HR_Manager_Name_Signature, System.Data.DbType.String);
                parameters.Add("pAccountancy_Manager_Signature", tbl_def_Company_y.Accountancy_Manager_Signature, System.Data.DbType.String);
                parameters.Add("pOpen_Hour", tbl_def_Company_y.Open_Hour, System.Data.DbType.Time);
                parameters.Add("pClose_Hour", tbl_def_Company_y.Close_Hour, System.Data.DbType.Time);
                parameters.Add("pDays_Of_Week_Ar", tbl_def_Company_y.Days_Of_Week_Ar, System.Data.DbType.String);
                parameters.Add("pDays_Of_Week_En", tbl_def_Company_y.Days_Of_Week_En, System.Data.DbType.String);
                parameters.Add("pOperating_Licence", tbl_def_Company_y.Operating_Licence, System.Data.DbType.String);
                parameters.Add("pOperating_Licence_From", tbl_def_Company_y.Operating_Licence_From, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_To", tbl_def_Company_y.Operating_Licence_To, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_Date", tbl_def_Company_y.Operating_Licence_Renew_Date, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_Fine", tbl_def_Company_y.Operating_Licence_Renew_Fine, System.Data.DbType.Decimal);
                parameters.Add("pOperating_Licence_B", tbl_def_Company_y.Operating_Licence_B, System.Data.DbType.String);
                parameters.Add("pOperating_Licence_B_From", tbl_def_Company_y.Operating_Licence_B_From, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_B_To", tbl_def_Company_y.Operating_Licence_B_To, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_B_Date", tbl_def_Company_y.Operating_Licence_Renew_B_Date, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_B_Fine", tbl_def_Company_y.Operating_Licence_Renew_B_Fine, System.Data.DbType.Decimal);
                parameters.Add("pOperating_Licence_C", tbl_def_Company_y.Operating_Licence_C, System.Data.DbType.String);
                parameters.Add("pOperating_Licence_C_From", tbl_def_Company_y.Operating_Licence_C_From, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_C_To", tbl_def_Company_y.Operating_Licence_C_To, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_C_Date", tbl_def_Company_y.Operating_Licence_Renew_C_Date, System.Data.DbType.Date);
                parameters.Add("pOperating_Licence_Renew_C_Fine", tbl_def_Company_y.Operating_Licence_Renew_C_Fine, System.Data.DbType.Decimal);
                parameters.Add("pNotes_Ar", tbl_def_Company_y.Notes_Ar, System.Data.DbType.String);
                parameters.Add("pNotes_En", tbl_def_Company_y.Notes_En, System.Data.DbType.String); //Raw sql Method
                await conn.ExecuteAsync("sp_Update_Tbl_def_Company_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }

        //Update row in Tbl_def_Company_y Table -----------------------------------------------------------------------
        public async Task<bool> Tbl_def_Company_yDelete(int ID)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                //Debug.WriteLine(">> " + conn.ConnectionString);
                var parameters = new DynamicParameters();
                parameters.Add("pID", ID, System.Data.DbType.Int32);
                await conn.ExecuteAsync("sp_Delete_Tbl_def_Company_y", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return true;
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //List Tbl_def_Company_y Table        
        public Tbl_def_Company_y Tbl_def_Company_yList()
        {
            Tbl_def_Company_y tbl_def_Company_ys;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                try
                {
                    tbl_def_Company_ys = conn.QueryFirst<Tbl_def_Company_y>("sp_Select_Tbl_def_Company_y", commandType: CommandType.StoredProcedure);
                    return tbl_def_Company_ys;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Company_ys = conn.QueryFirst<Tbl_def_Company_y>("sp_Select_Tbl_def_Company_y", commandType: CommandType.StoredProcedure);
                    return tbl_def_Company_ys;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Company_ys = conn.QueryFirst<Tbl_def_Company_y>("sp_Select_Tbl_def_Company_y", commandType: CommandType.StoredProcedure);
                    return tbl_def_Company_ys;
                }
            }
        }
        // ----------------------------------------------------------------------- -----------------------------------
        //One Tbl_def_Company_y by ID        
        public Tbl_def_Company_y Tbl_def_Company_yOne(int ID)
        {
            Tbl_def_Company_y tbl_def_Company_y;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ID", ID, DbType.Int32);
                string Querystring = "Select top(1) * from Tbl_def_Company_y where ID=" + ID.ToString();
                Debug.WriteLine(Querystring);
                try
                {
                    tbl_def_Company_y = conn.QuerySingle<Tbl_def_Company_y>(Querystring, ID, commandType: CommandType.Text);
                    return tbl_def_Company_y;
                }
                catch (SqlException sqlEx)
                {
                    Debug.WriteLine("Errors SQl   : " + sqlEx.Message);
                    tbl_def_Company_y = conn.QuerySingle<Tbl_def_Company_y>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Company_y;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Errors   : " + ex.Message);
                    tbl_def_Company_y = conn.QuerySingle<Tbl_def_Company_y>(Querystring, commandType: CommandType.Text);
                    return tbl_def_Company_y;
                }
            }
        }
    }
}
