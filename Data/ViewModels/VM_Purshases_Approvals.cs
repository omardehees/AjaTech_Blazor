using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Purshases_Approvals
    {
        public Nullable<long> HardCopyCode { get; set; }
        public int ItemsCount { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Vats { get; set; }
        public Nullable<System.DateTime> Last_At { get; set; }
        public Nullable<System.DateTime> Issuance_At { get; set; }
        public string Issuance_by { get; set; }
        public string Request_Approved_By { get; set; }
        public Nullable<System.DateTime> Request_Approved_At { get; set; }
        public string Canceled_By { get; set; }
        public Nullable<System.DateTime> Canceled_At { get; set; }


    }
}
