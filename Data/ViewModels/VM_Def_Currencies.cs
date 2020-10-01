using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Currencies
    {
        public int ID { get; set; }
        public string Title_Ar { get; set; }
        public string Title_En { get; set; }
        public string Symbol_Ar { get; set; }
        public string Symbol_En { get; set; }
        public Nullable<decimal> Exchange_Rate { get; set; }
        public Nullable<bool> Is_Default { get; set; }
        public string Notes_Ar { get; set; }
        public string Notes_En { get; set; }
    }
}
