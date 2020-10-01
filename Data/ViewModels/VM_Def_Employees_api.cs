using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Employees_api
    {
        public int ID { get; set; }
        public int? Parent_ID { get; set; }
        public string Name_Ar { get; set; }
        public string Name_En { get; set; }
        public string Tree_Code { get; set; }
        public string Boss_Name { get; set; }
        public string Boss_Code { get; set; }
        public string Peer_Name { get; set; }
        public string Peer_Code { get; set; }
        public string Alias { get; set; }
        public string Sex { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public bool? Is_Super_Admin { get; set; }
        public string Job { get; set; }
        public string Job_Description { get; set; }
        public string Department { get; set; }
        public string Branch { get; set; }
        public string Job_Number { get; set; }
        public string Social_Status { get; set; }
        public string Image_Path { get; set; }
        public decimal? Evaluation { get; set; }
        public string Evaluation_Icon_Path { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Religon { get; set; }
        public string Language { get; set; }
        public string ID_Type { get; set; }
        public string ID_Number { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string Phones { get; set; }
        public string Job_Address { get; set; }
        public DateTime? Job_From { get; set; }
        public decimal? Job_Sallary { get; set; }
        public string Notes { get; set; }
        public bool Archived { get; set; }
        public bool Deleted { get; set; }

    }
}
