using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Items
    {
        public int ID { get; set; }
        public string Item_Title_Ar { get; set; }
        public string Item_Title_En { get; set; }
        public string Item_Group { get; set; }
        public string Activity { get; set; }
        public string Item_Unit { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> VAT { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Thickness { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public Nullable<int> Validation_Period { get; set; }
        public Nullable<int> Preparation_Period { get; set; }
        public Nullable<int> Garantee_Period { get; set; }
        public string Packaging { get; set; }
        public string Material { get; set; }
        public string Preservation { get; set; }
        public Nullable<bool> To_Inventory_allow_Buy { get; set; }
        public Nullable<bool> To_Inventory_allow_Fractions { get; set; }
        public Nullable<bool> To_Inventory_allow_Frabrications { get; set; }
        public Nullable<bool> To_Inventory_allow_Rebounds { get; set; }
        public Nullable<bool> To_Inventory_allow_Free_Samples { get; set; }
        public Nullable<decimal> To_Inventory_Maximum_Stock { get; set; }
        public string To_Inventory_Inventory { get; set; }
        public string To_Inventory_Supplier { get; set; }
        public Nullable<decimal> To_Inventory_Buy_Price { get; set; }
        public Nullable<decimal> To_Inventory_BOP { get; set; }
        public Nullable<bool> From_Inventory_allow_Sell { get; set; }
        public Nullable<bool> From_Inventory_allow_Fractions { get; set; }
        public Nullable<bool> From_Inventory_allow_term_sales { get; set; }
        public Nullable<bool> From_Inventory_allow_Frabrications { get; set; }
        public Nullable<bool> From_Inventory_allow_Rebounds { get; set; }
        public Nullable<bool> From_Inventory_allow_Free_Samples { get; set; }
        public Nullable<decimal> From_Inventory_Sell_Price { get; set; }
        public Nullable<decimal> From_Inventory_SemiWholeSales_Price { get; set; }
        public Nullable<decimal> From_Inventory_WholeSales_Price { get; set; }
        public Nullable<decimal> From_Inventory_Term_Sell_Price { get; set; }
        public string From_Inventory_Inventory { get; set; }
        public string From_Inventory_Customer { get; set; }
        public string From_Inventory_Sales_Representative { get; set; }
        public Nullable<decimal> From_Inventory_Sales_Representative_Commession { get; set; }
        public Nullable<bool> From_Inventory_allow_Discount { get; set; }
        public string Code_At_Supplier { get; set; }
        public string Supplier_Country { get; set; }
        public Nullable<decimal> Ampere { get; set; }
        public Nullable<decimal> Volt { get; set; }
        public Nullable<decimal> Power { get; set; }
        public Nullable<int> Persons { get; set; }
        public Nullable<int> Color_r { get; set; }
        public Nullable<int> Color_g { get; set; }
        public Nullable<int> Color_b { get; set; }
        public string Touch { get; set; }
        public string Transperancy { get; set; }
        public string Shining { get; set; }
        public Nullable<decimal> Diameter { get; set; }
        public string Nature { get; set; }
        public string Main_Property { get; set; }
        public string Class { get; set; }
        public string Parent_Group { get; set; }
        public Nullable<int> Pre_Validation_End_Warning_Period { get; set; }
        public Nullable<decimal> First_Balance { get; set; }
        public Nullable<decimal> Debit_Balance { get; set; }
        public Nullable<decimal> Credit_Balance { get; set; }
        public Nullable<decimal> Current_Balance { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public Nullable<bool> Archived { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string Certificates { get; set; }
        public string Image { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> Is_Service { get; set; }
        public Nullable<decimal> To_Inventory_Minimum_Stock { get; set; }
    }
}
