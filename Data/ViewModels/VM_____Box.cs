using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
        public partial class VM_Inv_Checks
        {
            public long ID { get; set; }
            public Nullable<long> HardCopyCode { get; set; }
            public string Type { get; set; }
            public Nullable<System.DateTime> TimeStamp { get; set; }
            public Nullable<System.DateTime> Issuied_Date { get; set; }
            public Nullable<System.DateTime> Due_Date { get; set; }
            public string Account { get; set; }
            public string BankAccount { get; set; }
            public string Check_Number { get; set; }
            public Nullable<decimal> Value { get; set; }
            public string Statement { get; set; }
            public string GL_ID { get; set; }
            public string Current_Status { get; set; }
            public Nullable<System.DateTime> Current_Status_Date { get; set; }
            public string Current_Status_By { get; set; }
            public string Current_Status_Notes { get; set; }
        }


}
