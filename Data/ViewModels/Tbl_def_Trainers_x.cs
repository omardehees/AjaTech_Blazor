using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.Tables_Models
{
    public class Tbl_def_Trainers_x
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name Ar is required")]
        public string Name_Ar { get; set; }
        [Required(ErrorMessage = "Name En is required")]
        public string Name_En { get; set; }
        public string sex { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Photo { get; set; }
        [Required(ErrorMessage = "Certificates are required")]
        public string Certificates { get; set; }
        public string Certificates_Photoes { get; set; }
        public DateTime RegDate { get; set; }
        public bool Enabled { get; set; }
        public string languages { get; set; }
        public string Mothor_Tong { get; set; }
        public DateTime Available_From { get; set; }
        public DateTime Available_To { get; set; }
        public bool Dealing_Worning { get; set; }
        public string Pricing_Policy { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string address { get; set; }
        public string LandLines { get; set; }
        [Required(ErrorMessage = "Pnones are Required")]
        public string Pnones { get; set; }
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string EMail { get; set; }
        public string FaceBook { get; set; }
        public string Job { get; set; }
        public string Gender { get; set; }
        public string Notes { get; set; }
    }
}
