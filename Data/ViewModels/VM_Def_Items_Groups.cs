using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Items_Groups
    {
        public int ID { get; set; }
        public string Title_Ar { get; set; }
        public string Title_En { get; set; }
        public string Prefix { get; set; }
        public string Description { get; set; }
        public string Activity { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public Nullable<bool> Archived { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string Notes { get; set; }
        public string Parents { get; set; }


    }
}
