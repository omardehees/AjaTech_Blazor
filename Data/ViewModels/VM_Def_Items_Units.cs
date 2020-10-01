using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Items_Units
    {
        public int ID { get; set; }
        public string Unit_Title_Ar { get; set; }
        public string Unit_Title_En { get; set; }
        public string Unit_Abbreviation_Ar { get; set; }
        public string Unit_Abbreviation_En { get; set; }
        public string Unit_Type { get; set; }
        public string Description { get; set; }
        public string Activity { get; set; }
        public bool? Enabled { get; set; }
        public bool? Archived { get; set; }
        public bool? Deleted { get; set; }
    }
}
