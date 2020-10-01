using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Item_One_Batch
    {
        public string Item { get; set; }
        public string Item_Code { get; set; }
        public string Item_Group { get; set; }
        public string Item_Unit { get; set; }
        public string BatchNumber { get; set; }
        public double Quantity_In { get; set; }
        public double Unit_Price_In { get; set; }
        public string To_Inventory { get; set; }
        public double Quantity_Out { get; set; }
        public double Unit_Price_Out { get; set; }
        public string From_Inventory { get; set; }
        public double Balance { get; set; }
    }
}