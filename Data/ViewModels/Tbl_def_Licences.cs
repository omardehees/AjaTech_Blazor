using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class Tbl_def_Licences
    {
        public int? ID { get; set; }
        public string Licence_Title_Ar { get; set; }
        public string Licence_Title_En { get; set; }
        public string Licence_Issuer_Ar { get; set; }
        public string Licence_Issuer_En { get; set; }
        public DateTime Licence_From { get; set; }
        public DateTime Licence_To { get; set; }
        public DateTime Licence_Renew_Date { get; set; }
        public decimal Licence_Renew_Fine { get; set; }
        public decimal Licence_Renewal_Fees { get; set; }
        public bool Enabled { get; set; }
        public bool Archived { get; set; }
        public bool Deleted { get; set; }

    }
}
