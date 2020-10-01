using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Inv_Pre_Purchases_Offers
    {
        public int ID { get; set; }
        public Nullable<long> HardCopyCode { get; set; }
        public Nullable<long> Offer_HardCopyCode { get; set; }
        public string Approved_By { get; set; }
        public string Supplier { get; set; }
        public string Item { get; set; }
        public Nullable<int> Items_Count { get; set; }
        public string Item_Code { get; set; }
        public string Item_Code_Custome { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Unit_Price { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public Nullable<decimal> Value { get; set; }
        public string Inventory { get; set; }
        public Nullable<System.DateTime> Supplied_Expected_At { get; set; }
        public string Supplied_Inventory { get; set; }
        public string Notes { get; set; }
        public Nullable<decimal> Pre_Value { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
