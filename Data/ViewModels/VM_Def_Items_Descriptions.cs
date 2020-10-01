using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Items_Descriptions
    {
        public int ID { get; set; }
        public string Title_Ar { get; set; }
        public string Title_En { get; set; }
        public string Description_Ar { get; set; }
        public string Description_En { get; set; }
        public string Activity { get; set; }
        public string Notes { get; set; }
        public bool Enabled { get; set; }
        public bool Archived { get; set; }
        public bool Deleted { get; set; }
    }
}
