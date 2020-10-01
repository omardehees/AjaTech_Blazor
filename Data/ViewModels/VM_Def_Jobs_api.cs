using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Jobs_api
    {
        public int ID { get; set; }
        public string Type_Ar { get; set; }
        public string type_En { get; set; }
        public string Job_Title_Ar { get; set; }
        public string Job_Title_En { get; set; }
        public string Job_Description_Ar { get; set; }
        public string Job_Description_En { get; set; }
        public string Departmets_ID { get; set; }
        public string Notes_Ar { get; set; }
        public string Notes_En { get; set; }
        public bool Enabled { get; set; }
        public bool Archived { get; set; }
        public bool Deleted { get; set; }
    }
}
