using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Items_Preservaition
    {
        public int ID { get; set; }
        public string Title_Ar { get; set; }
        public string Title_En { get; set; }
        public string Preservation_Description_Ar { get; set; }
        public string Preservation_Description_En { get; set; }
        public string image { get; set; }
        public string Activity { get; set; }
        public bool Enabled { get; set; }
        public bool Archived { get; set; }
        public bool Deleted { get; set; }
        public string Notes { get; set; }
    }
}
