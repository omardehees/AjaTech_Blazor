using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Inv_GL
    {
        public long ID { get; set; }
        public string Type { get; set; }
        public string The_User { get; set; }
        public string Apporoved_By { get; set; } = "";
        public Nullable<System.DateTime> Approved_At { get; set; }
        public string Edited_By { get; set; } = "";
        public Nullable<System.DateTime> Edited_At { get; set; }
        public string Deleted_By { get; set; } = "";
        public Nullable<System.DateTime> Deleted_At { get; set; }
        public string Deleted_Reason { get; set; } = "";
        public string Rebound_By { get; set; } = "";
        public Nullable<System.DateTime> Rebound_At { get; set; }
        public Nullable<decimal> Rebound_Ammout { get; set; } = 0;
        public Nullable<int> HardCopyCode { get; set; }
        public string Document_ID { get; set; } = "";
        public string ProccessID { get; set; } = "";
        public string Paired_Table { get; set; } = "";
        public Nullable<long> Paired_Record_ID { get; set; } 
        public Nullable<System.DateTime> TimeStamp { get; set; } =DateTime.Now;
        public Nullable<System.DateTime> The_Date { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public string To_Inventory { get; set; }
        public string From_Inventory { get; set; }
        public string Auto_Statement { get; set; }
        public string Custom_Statement { get; set; }
        public string Item { get; set; }
        public string Item_Unit { get; set; }
        public Nullable<decimal> Unit_Price { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Item_Cost { get; set; }
        public Nullable<decimal> Item_Service_Cost { get; set; }
        public Nullable<decimal> Value { get; set; }
        public string Payment_Type { get; set; }
        public string payment_Method { get; set; }
        public Nullable<decimal> Cash_Value { get; set; }
        public Nullable<decimal> Due_Value { get; set; }
        public string Currency { get; set; }
        public string Person { get; set; }
        public string Carrier { get; set; }
        public string CostCenter { get; set; }
        public string Notes { get; set; }
        public string Item_Code { get; set; }
        public string Validation_Date { get; set; }
        public string BatchNumber { get; set; }
        public Nullable<decimal> Unit_Vat { get; set; }
        public string Contract_Type { get; set; }
        public string Contract_Code { get; set; }




        public Nullable<decimal> Total { get; set; }
        public Nullable<int> ItemsCount { get; set; }
        public Nullable<decimal> Total_Receive { get; set; }
        public Nullable<decimal> Total_Pay { get; set; }
                public Nullable<decimal> Total_Buy { get; set; }
        public Nullable<decimal> Total_BuyVat { get; set; }
        public string Dash_The_Date { get; set; }
        public string Credit_Inventory { get; set; }
        public Nullable<decimal> Credit_quantity { get; set; }
        public string Debit_Inventory { get; set; }
        public Nullable<decimal> Debit_quantity { get; set; }





    }
}
