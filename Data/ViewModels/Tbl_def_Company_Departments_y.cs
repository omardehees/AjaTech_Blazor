using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Tables_Models
{
    public class Tbl_def_Company_Departments_y
    {
        [Key]
        public int? ID { get; set; }
        public string Department_Title_Ar { get; set; }
        public string Department_Title_En { get; set; }
        public string Department_Company { get; set; }
        public string Department_Branch { get; set; }
        public string Department_Address_Ar { get; set; }
        public string Department_Address_En { get; set; }
        public string Department_Activities { get; set; }
        public string Department_Mobile_A { get; set; }
        public string Department_Mobile_B { get; set; }
        public string Department_Mobile_C { get; set; }
        public string Department_Mobile_D { get; set; }
        public string Department_Phone_A { get; set; }
        public string Department_Phone_B { get; set; }
        public string Department_Phone_C { get; set; }
        public string Department_Phone_D { get; set; }
        public string Department_Suggestions_Complains_Phone { get; set; }
        public string Department_Executive_Manager_Name_Ar { get; set; }
        public string Department_Sales_Manager_Name_Ar { get; set; }
        public string Department_HR_Manager_Name_Ar { get; set; }
        public string Department_Accountancy_Manager_Name_Ar { get; set; }
        public string Department_Executive_Manager_Name_En { get; set; }
        public string Department_Sales_Manager_Name_En { get; set; }
        public string Department_HR_Manager_Name_En { get; set; }
        public string Department_Accountancy_Manager_Name_En { get; set; }
        public string Department_Executive_Manager_Phone { get; set; }
        public string Department_Sales_Manager_Name_Phone { get; set; }
        public string Department_HR_Manager_Name_Phone { get; set; }
        public string Department_Accountancy_Manager_Phone { get; set; }
        public string Department_Executive_Manager_Signature { get; set; }
        public string Department_Sales_Manager_Name_Signature { get; set; }
        public string Department_HR_Manager_Name_Signature { get; set; }
        public string Department_Accountancy_Manager_Signature { get; set; }
        public TimeSpan? Open_Hour { get; set; }
        public TimeSpan? Close_Hour { get; set; }
        public string Days_Of_Week { get; set; }
        public string Operating_Licence { get; set; }
        public string Operating_Licence_From { get; set; }
        public string Operating_Licence_To { get; set; }
        public string Operating_Licence_Renew_Date { get; set; }
        public string Operating_Licence_Renew_Fine { get; set; }
        public string Operating_Licence_B { get; set; }
        public string Operating_Licence_B_From { get; set; }
        public string Operating_Licence_B_To { get; set; }
        public string Operating_Licence_Renew_B_Date { get; set; }
        public string Operating_Licence_Renew_B_Fine { get; set; }
        public string Operating_Licence_C { get; set; }
        public string Operating_Licence_C_From { get; set; }
        public string Operating_Licence_C_To { get; set; }
        public string Operating_Licence_Renew_C_Date { get; set; }
        public string Operating_Licence_Renew_C_Fine { get; set; }
        public string Department_Notes_Ar { get; set; }
        public string Department_Notes_En { get; set; }
        public bool Enabled { get; set; }
        public bool Archived { get; set; }
        public bool Deleted { get; set; }
    }
}
