using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Tables_Models
{
    public class Tbl_Log_Activities_y
    {
        [Key]
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Job { get; set; }
        public string User_Department { get; set; }
        public bool User_Can_Navigate { get; set; }
        public string Page_Name { get; set; }
        public string Page_Title { get; set; }
        public string HRDW { get; set; }
        public string IP { get; set; }
        public string Device { get; set; }
        public string Action { get; set; }
        public string Action_Code { get; set; }
        public string Action_description { get; set; }
        public string Action_QueryString { get; set; }
        public string ProccessID { get; set; }
        public string Affected_tables { get; set; }
        public string Notes { get; set; }

    }
}
