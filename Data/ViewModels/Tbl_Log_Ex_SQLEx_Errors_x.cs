using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Tables_Models
{
    public class Tbl_Log_Ex_SQLEx_Errors_x
    {
        [Key]
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Sevirty { get; set; }
        public bool ISArchived { get; set; }
        public string User_ID { get; set; }
        public string User_Full_Name { get; set; }
        public string Page_File { get; set; }
        public string Page_Title { get; set; }
        public string Block { get; set; }
        public int Line { get; set; }
        public string IP_Address { get; set; }
        public string Browser { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string Notes { get; set; }
    }
}
