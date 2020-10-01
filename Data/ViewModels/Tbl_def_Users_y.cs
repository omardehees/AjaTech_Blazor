using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Tables_Models
{
    public class Tbl_def_Users_y
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "ID is required")]
        [StringLength(12, ErrorMessage = "غير مسموح باكثر من 12 حرف")]
        public string User_Name { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public string Full_Name { get; set; }
        [Required(ErrorMessage = "PAssword is required")]
        public string Password { get; set; }
        public string Password_hint { get; set; }
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string Language { get; set; }
        public string Start_Page { get; set; }
        public string Pages { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Default_Treasury { get; set; }
        public string job { get; set; }
        public bool Enabled { get; set; }
        public string substitutant { get; set; }
        public bool IS_Super_User { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }        
        public string Notes { get; set; }
    }
}
