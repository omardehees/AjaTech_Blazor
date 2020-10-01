using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public partial class VM_SupplyInstall_Items_Transfere
    {
        public long ID { get; set; }
        public Nullable<long> HardCopyCode { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<System.DateTime> The_Date { get; set; }
        public string Customer { get; set; }
        public string Contract_Type { get; set; }
        public string Contract_HardCopyCode { get; set; }
        public string Job_Type { get; set; }
        public string Inventory { get; set; }
        public string Inventory_Employee { get; set; }
        public string Boss_Employee { get; set; }
        public string Stage { get; set; }
        public string Issued_By { get; set; }
        public Nullable<System.DateTime> Issued_At { get; set; }
        public string Approved_By { get; set; }
        public Nullable<System.DateTime> Approved_At { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_At { get; set; }
        public string Deleted_By { get; set; }
        public Nullable<System.DateTime> Deleted_At { get; set; }
        public string Issue_Notes { get; set; }
        public string Inventory_Employee_Notes { get; set; }
        public string Mostakhlas_Employee_Notes { get; set; }
        public string Approve_Notes { get; set; }
        public string Delete_Notes { get; set; }
        public string Modify_Notes { get; set; }


        public string MissionName { get; set; }
        public Nullable<long> MissionConunt { get; set; }

    }

    public partial class VM_SupplyInstall_Items_Transfere_Details
    {
        public long ID { get; set; }
        public Nullable<long> HardCopyCode { get; set; }
        public string Item { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Contract_Quantity { get; set; }
        public Nullable<decimal> Supplied_Quantity { get; set; }
        public Nullable<decimal> Rebound_Quantity { get; set; }
        public Nullable<decimal> Remaining_Quantity { get; set; }
        public Nullable<decimal> Supply_Percentage { get; set; }
        public string Statment { get; set; }
    }

    public partial class VM_SupplyInstall_Items_Transfere_Types
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Direction { get; set; }
        public string Notes { get; set; }
    }

    public partial class VM_SupplyInstall_Missions
    {
        public long ID { get; set; }
        public Nullable<long> HardCopyCode { get; set; }
        public string Customer { get; set; }
        public string Contract_Type { get; set; }
        public string Contract_HardCopyCode { get; set; }
        public Nullable<long> HardCopyCode_Items_Transfere { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<System.DateTime> The_date { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> Finishing_Date { get; set; }
        public string Mission_Type { get; set; }
        public string Mission_Subject { get; set; }
        public string Boss { get; set; }
        public string Workers { get; set; }
        public string Cars { get; set; }
        public Nullable<decimal> Transportation_Cost { get; set; }
        public Nullable<decimal> Shipping_Cost { get; set; }
        public Nullable<decimal> SubContractor_Cost { get; set; }
        public string SubContractor_Statement { get; set; }
        public Nullable<decimal> Completion_Rate_Before { get; set; }
        public Nullable<decimal> Completion_Rate_After { get; set; }
        public string Completion_Rate_Statement { get; set; }
        public string Boss_Notes { get; set; }
        public string Customer_Notes { get; set; }
        public string Technical_Department_Notes { get; set; }
        public string Financial_Department_Notes { get; set; }
        public string Management_Notes { get; set; }
        public string Approved_By { get; set; }
        public Nullable<System.DateTime> Approved_At { get; set; }
        public string Edit_By { get; set; }
        public Nullable<System.DateTime> Edit_At { get; set; }
        public string Deleted_By { get; set; }
        public Nullable<System.DateTime> Deleted_At { get; set; }
    }

    public partial class VM_SupplyInstall_Missions_Types
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Direction { get; set; }
        public string Notes { get; set; }
    }

}
