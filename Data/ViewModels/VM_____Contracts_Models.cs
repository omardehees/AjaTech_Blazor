using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public partial class VM_Inv_Contracts
    {
        public int ID { get; set; }
        public Nullable<int> HardCopyCode { get; set; }
        public Nullable<System.DateTime> Contract_Signed_At { get; set; }
        public string Contract_Signed_By { get; set; }
        public string Contract_Signed_Job { get; set; }
        public string Contract_PDF_Link { get; set; }
        public string Technical_Offer_hardCopyCode { get; set; }
        public string Financial_Offer_hardCopyCode { get; set; }
        public string Customer { get; set; }
        public Nullable<decimal> Total_Cost { get; set; }
        public Nullable<System.DateTime> DeliveryStart_At { get; set; }
        public Nullable<System.DateTime> DeliveryEnd_At { get; set; }
        public Nullable<System.DateTime> Close_At { get; set; }
        public Nullable<bool> Garantee_Included { get; set; }
        public Nullable<System.DateTime> Garantee_End { get; set; }
        public Nullable<bool> Maintenance_Visits_Included { get; set; }
        public Nullable<System.DateTime> Maintenance_Visits_End { get; set; }
        public string Maintenance_Visits_Schedual { get; set; }
        public string Technical_Notes { get; set; }
        public string Financial_Notes { get; set; }
        public string CustomerSupport_Notes { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public string Sanad { get; set; }
        public Nullable<decimal> Component_Cost { get; set; }
        public Nullable<decimal> Other_Cost { get; set; }
        public Nullable<decimal> Profit { get; set; }
        public Nullable<decimal> Vat { get; set; }
    }
    public partial class VM_Inv_Pre_Sales_Financial_Offer
    {
        public int ID { get; set; }
        public Nullable<long> HardCopyCode { get; set; }
        public string Issuied_By { get; set; }
        public string Issuied_At { get; set; }
        public string Valid_To { get; set; }
        public string Modified_By { get; set; }
        public string Modified_At { get; set; }
        public string Approved_By { get; set; }
        public string Approved_At { get; set; }
        public string Technical_Offer_HardCopyCode { get; set; }
        public Nullable<decimal> Technical_Offer_Total { get; set; }
        public Nullable<bool> Garantee_Included { get; set; }
        public Nullable<decimal> Garantee_Cost { get; set; }
        public Nullable<int> Garantee_Month { get; set; }
        public Nullable<bool> Maintenance_Visits_Included { get; set; }
        public Nullable<decimal> Maintenance_Visits_Cost { get; set; }
        public Nullable<int> Maintenance_Visits_Month { get; set; }
        public string Maintenance_Visits_Schedual { get; set; }
        public Nullable<decimal> Shipping_Charges { get; set; }
        public Nullable<decimal> Lefting_Charges { get; set; }
        public Nullable<decimal> Transportation_Charges { get; set; }
        public Nullable<decimal> Preparation_Charges { get; set; }
        public Nullable<decimal> Subcontractor_Cost { get; set; }
        public string Subcontractor_Statement { get; set; }
        public Nullable<decimal> Other_Charges { get; set; }
        public string Other_Charges_Statement { get; set; }
        public Nullable<decimal> Total_Cost { get; set; }
        public Nullable<decimal> Profit_Value { get; set; }
        public Nullable<decimal> Contract_Total { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public string Customer { get; set; }
        public string LegalTerms_Items { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public Nullable<decimal> Extra_Cost { get; set; }
        public string Contract_Items { get; set; }


        public Nullable<decimal> Dash_Count { get; set; }
        public Nullable<decimal> Dash_Profit { get; set; }
        public Nullable<decimal> Dash_Vat { get; set; }
        public Nullable<decimal> Dash_Value { get; set; }
        public Nullable<decimal> Dash_Total { get; set; }
        public string Dash_Date { get; set; }

    }
    public partial class VM_Inv_Pre_Sales_Financial_Offer_Payments
    {
        public int ID { get; set; }
        public string Financial_Offer_HardCopyCode { get; set; }
        public string Customer { get; set; }
        public bool Required { get; set; }
        public Nullable<decimal> Value { get; set; }
        public string Statment { get; set; }
        public Nullable<System.DateTime> Required_Date { get; set; }
        public Nullable<System.DateTime> Done_Date { get; set; }
        public string Notes { get; set; }
    }
    public partial class VM_Inv_Pre_Sales_Techical_Offer
    {
        public int ID { get; set; }
        public Nullable<long> HardCopyCode { get; set; }
        public string Issuied_By { get; set; }
        public string Issuied_At { get; set; }
        public string Valid_To { get; set; }
        public string Modified_By { get; set; }
        public string Modified_At { get; set; }
        public string Approved_By { get; set; }
        public string Approved_At { get; set; }
        public Nullable<int> Units_Count { get; set; }
        public Nullable<int> Persons { get; set; }
        public Nullable<int> Levels { get; set; }
        public Nullable<decimal> Path_Length { get; set; }
        public string Machine_Type { get; set; }
        public Nullable<int> Exterior_Entrance_Count { get; set; }
        public Nullable<int> Wires_Count { get; set; }
        public string Suspension_Type { get; set; }
        public Nullable<int> Box_Entrance_Count { get; set; }
        public string DoorType { get; set; }
        public string Door_Sensor { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Items_Count { get; set; }
        public Nullable<decimal> Total_Items_Cost { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public string Emergency_Circuit { get; set; }
        public string Well_Type { get; set; }
        public string Power { get; set; }
        public string ELevator_Title { get; set; }
        public string Contract_Items { get; set; }

    }
    public partial class VM_Inv_Pre_Sales_Techical_Offer_Details
    {
        public int ID { get; set; }
        public string HardCopyCode { get; set; }
        public string The_Group { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<decimal> Default_Price { get; set; }
        public Nullable<decimal> Last_Purchase_Price { get; set; }
        public Nullable<decimal> Average_Purchase_Price { get; set; }
        public Nullable<decimal> Current_Balance { get; set; }
        public string Notes { get; set; }
        public string Code { get; set; }
        public string Inventory { get; set; }

    }

    public partial class VM_Legal_Terms
    {
        public int ID { get; set; }
        public string Statement { get; set; }
        public string CreatedBy { get; set; }
        public string Customer { get; set; }
        public string Notes { get; set; }
    }
    public partial class VM_Inv_Contracts_Items
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }

}
