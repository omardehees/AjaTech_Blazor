using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_ItemBasicData
    {
        public int ID { get; set; }
        public string Item { get; set; }
        public string Item_Code { get; set; }
        public string Item_Group { get; set; }
        public string Item_Unit { get; set; }
        public string To_Inventory_Inventory { get; set; }
        public Boolean Is_Service { get; set; } = false;
        public double To_Inventory_Minimum_Stock { get; set; }
        public double To_Inventory_Maximum_Stock { get; set; }
        public double Quantity_In { get; set; }
        public double Quantity_Out { get; set; }
        public double Current_Quantity { get; set; }
        public double Seeked_Quantity { get; set; }
        public string Last_In_Date { get; set; } = "";
        public string Last_In_Type { get; set; } = "";
        public string Last_In_User { get; set; } = "";
        public double Last_In_Quantity { get; set; } = 0;
        public double Last_In_Unit_Price { get; set; } = 0;
        public string Last_Out_Date { get; set; } = "xxxxxxxxxxx";
        public string Last_Out_Type { get; set; } = "";
        public string Last_Out_User { get; set; } = "";
        public double Last_Out_Quantity { get; set; } = 0;
        public double Last_Out_Unit_Price { get; set; } = 0;
        public double Value_In { get; set; }
        public double Value_Out { get; set; }
        public double Current_Value { get; set; }
        public double Sales_Profit_Absolute { get; set; }
        public double Sales_Profit_Percentage { get; set; }
        public List<VM_Item_One_Batch> itemBatches { get; set; }
    }
}