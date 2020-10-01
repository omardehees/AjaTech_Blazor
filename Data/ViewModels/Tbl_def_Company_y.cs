using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Tables_Models
{
    public class Tbl_def_Company_y
    {
        [Key]
        public int ID { get; set; }
        public string Title_Ar { get; set; }
        public string Title_En { get; set; }
        public string Slogan_A_Ar { get; set; }
        public string Slogan_A_En { get; set; }
        public string Slogan_B_Ar { get; set; }
        public string Slogan_B_En { get; set; }
        public string Activities_Ar { get; set; }
        public string Activities_En { get; set; }
        public string Head_Office_Address_Ar { get; set; }
        public string Head_Office_Address_En { get; set; }
        public string Factory_Address_Ar { get; set; }
        public string Factory_Address_En { get; set; }
        public string Inventory_Address_Ar { get; set; }
        public string Inventory_Address_En { get; set; }
        public string Mail_Box { get; set; }
        public string WebSite_Url { get; set; }
        public string Facebook { get; set; }
        public string Tweeter { get; set; }
        public string Email { get; set; }
        public string Mobile_A { get; set; }
        public string Mobile_B { get; set; }
        public string Mobile_C { get; set; }
        public string Mobile_D { get; set; }
        public string Phone_A { get; set; }
        public string Phone_B { get; set; }
        public string Phone_C { get; set; }
        public string Phone_D { get; set; }
        public string Logo_Color_Big { get; set; }
        public string Logo_Color_Small { get; set; }
        public string Logo_Print_Big { get; set; }
        public string Logo_Print_Small { get; set; }
        public string Suggestions_Complains_Phone { get; set; }
        public string Banner_Big { get; set; }
        public string Banner_small { get; set; }

        //public string Print_Technical { get; set; }
        //public string Print_Financial { get; set; }
        //public string Print_Managing { get; set; }
        //public string Print_Inventory { get; set; }
        //public string Print_Purchases { get; set; }
        //public string Print_Sales { get; set; }


        public string Owner_Main { get; set; }
        public string Owner_A { get; set; }
        public string Owner_B { get; set; }
        public string Owner_C { get; set; }
        public string Owner_D { get; set; }
        public string Tax_Registration_Number { get; set; }
        public string Class { get; set; }
        public string Executive_Manager_Name_Ar { get; set; }
        public string Sales_Manager_Name_Ar { get; set; }
        public string HR_Manager_Name_Ar { get; set; }
        public string Accountancy_Manager_Name_Ar { get; set; }
        public string Executive_Manager_Name_En { get; set; }
        public string Sales_Manager_Name_En { get; set; }
        public string HR_Manager_Name_En { get; set; }
        public string Accountancy_Manager_Name_En { get; set; }
        public string Executive_Manager_Phone { get; set; }
        public string Sales_Manager_Name_Phone { get; set; }
        public string HR_Manager_Name_Phone { get; set; }
        public string Accountancy_Manager_Phone { get; set; }
        public string Executive_Manager_Signature { get; set; }
        public string Sales_Manager_Name_Signature { get; set; }
        public string HR_Manager_Name_Signature { get; set; }
        public string Accountancy_Manager_Signature { get; set; }
        public TimeSpan Open_Hour { get; set; }
        public TimeSpan Close_Hour { get; set; }
        public string Days_Of_Week_Ar { get; set; }
        public string Days_Of_Week_En { get; set; }
        public string Operating_Licence { get; set; }
        public DateTime Operating_Licence_From { get; set; }
        public DateTime Operating_Licence_To { get; set; }
        public DateTime Operating_Licence_Renew_Date { get; set; }
        public decimal Operating_Licence_Renew_Fine { get; set; }
        public string Operating_Licence_B { get; set; }
        public DateTime Operating_Licence_B_From { get; set; }
        public DateTime Operating_Licence_B_To { get; set; }
        public DateTime Operating_Licence_Renew_B_Date { get; set; }
        public decimal Operating_Licence_Renew_B_Fine { get; set; }
        public string Operating_Licence_C { get; set; }
        public DateTime Operating_Licence_C_From { get; set; }
        public DateTime Operating_Licence_C_To { get; set; }
        public DateTime Operating_Licence_Renew_C_Date { get; set; }
        public decimal Operating_Licence_Renew_C_Fine { get; set; }
        public string Notes_Ar { get; set; }
        public string Notes_En { get; set; }
        public bool Enabled { get; set; }
        public bool Archived { get; set; }
        public bool Deleted { get; set; }
    }
}
