using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Tables_Models
{
    public class Tbl_def_Lectures_x
    {
        [Key]
        public int ID { get; set; }
        public string Title_Ar { get; set; }
        public string title_En { get; set; }
        public string Description_En { get; set; }
        public string Description_Ar { get; set; }
        public string Photo { get; set; }
        public bool Enabled { get; set; }
        public string Module_Title_Ar { get; set; }
        public string Module_Title_En { get; set; }
        public string Files { get; set; }
        public string Level_Ar { get; set; }
        public string Level_En { get; set; }
        public string Prerequests_Ar { get; set; }
        public string Prerequests_En { get; set; }
        public string Notes { get; set; }
    }
}
