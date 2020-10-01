using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Tables_Models
{
    public class Tbl_def_Files_x
    {
        [Key]  
        public int ID { get; set; }
        [Required(ErrorMessage = "Title Ar is required")]
        public string Title_Ar { get; set; }
        [Required(ErrorMessage = "Title En is required")]
        public string Title_En { get; set; }
        public string Description_Ar { get; set; }
        public string Description_En { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }
        public decimal Size_KB { get; set; }
        public bool Is_Public { get; set; }
        public string Courses { get; set; }
        public string Modules { get; set; }
        public string Lectures { get; set; }
        public string Uploader { get; set; }
        public string Download_Link { get; set; }
        public bool Enabled { get; set; }
        public string Notes { get; set; }
    }
}
