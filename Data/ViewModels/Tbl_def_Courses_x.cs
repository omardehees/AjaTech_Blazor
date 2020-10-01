using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Tables_Models
{
    public class Tbl_def_Modules_x
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Title Ar is required")]
        public string Title_Ar { get; set; }
        [Required(ErrorMessage = "Title En is required")]
        public string Title_En { get; set; }
        public string Description_En { get; set; }
        public string Description_Ar { get; set; }
        public string Course_Title_Ar { get; set; }
        public string Course_Title_En { get; set; }
        public string Photo { get; set; }
        public bool Enabled { get; set; }
        public string Notes { get; set; }
    }
}
