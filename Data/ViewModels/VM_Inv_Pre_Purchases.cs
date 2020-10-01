using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Inv_Pre_Purchases
    {
        public int ID { get; set; }
        public Nullable<long> HardCopyCode { get; set; }
        public Nullable<System.DateTime> Last_At { get; set; }
        public Nullable<System.DateTime> Issuance_At { get; set; }
        public string Issuance_by { get; set; }
        public Nullable<System.DateTime> Request_Approved_At { get; set; }
        public string Request_Approved_By { get; set; }
        public Nullable<System.DateTime> Order_Approved_At { get; set; }
        public string Order_Approved_By { get; set; }
        public Nullable<System.DateTime> Pricing_Approved_At { get; set; }
        public string Pricing_Approved_By { get; set; }
        public Nullable<System.DateTime> Modified_At { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> ToInventory_At { get; set; }
        public string ToInventory_By { get; set; }
        public string Purchased_By { get; set; }
        public Nullable<System.DateTime> Purchased_At { get; set; }
        public Nullable<System.DateTime> Canceled_At { get; set; }
        public string Canceled_By { get; set; }
        public string Supplier { get; set; }
        public string Item { get; set; }
        public Nullable<long> Offer_HardCopyCode { get; set; }
        public Nullable<int> Items_Count { get; set; }
        public string Item_Code { get; set; }
        public string Item_Code_Custome { get; set; }
        public Nullable<decimal> Current_Balance { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Unit_Price { get; set; }
        public Nullable<decimal> Value { get; set; }
        public string Inventory { get; set; }
        public Nullable<System.DateTime> Supplied_At { get; set; }
        public Nullable<System.DateTime> Supplied_Expected_At { get; set; }
        public string Supplied_Inventory { get; set; }
        public string Batches { get; set; }
        public string Statement { get; set; }
        public string Notes { get; set; }

        public Nullable<decimal> Unit_Vat { get; set; }
        public bool VatIncluded { get; set; }

        //public Nullable<decimal> ItemsCount { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Vats { get; set; }



    }
}
