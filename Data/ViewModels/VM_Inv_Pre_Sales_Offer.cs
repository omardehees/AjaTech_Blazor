using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Inv_Pre_Sales_Offer
    {
        public int ID { get; set; }
        public string HardCopyCode { get; set; }
        public string The_Group { get; set; }
        public string Item { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<decimal> Default_Price { get; set; }
        public Nullable<decimal> Last_Purchase_Price { get; set; }
        public Nullable<decimal> Average_Purchase_Price { get; set; }
        public Nullable<decimal> Current_Balance { get; set; }
        public string Notes { get; set; }
    }
}
