using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Accounts
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Activity { get; set; }
        public string ParentAccount { get; set; }
        public int? ParentID { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> First_Debit { get; set; } = 0;
        public Nullable<decimal> First_Credit { get; set; } = 0;
        public Nullable<decimal> Debit { get; set; } = 0;
        public Nullable<decimal> Credit { get; set; } = 0;
        public Nullable<decimal> Balance { get; set; } = 0;
        public string CurrencyID { get; set; } = "ريال سعودي";
        public string Income_Statement { get; set; }
        public string Financial_Center { get; set; }
        public Nullable<int> The_Level { get; set; }
        public string Users { get; set; }
        public string Sales_Representative { get; set; }
        public Nullable<bool> Enabled { get; set; } =true;
        public string Diasbled_By { get; set; }
        public string Disabled_At { get; set; }
        public string Deleted_By { get; set; }
        public string Deleted_At { get; set; }
        public string Rating { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; } = DateTime.Now ;
        public string The_Group { get; set; }
        public Nullable<bool> Dealing_Worning { get; set; }
        public Nullable<bool> Allow_Discount { get; set; }
        public Nullable<bool> Allow_Term_Selling { get; set; }
        public Nullable<decimal> Debit_Limit { get; set; }
        public string Pricing_Policy { get; set; }
        public string language { get; set; }
        public string Religion { get; set; }
        public string National_ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string address { get; set; }
        public string MailBox { get; set; }
        public string LandLines { get; set; }
        public string Phones { get; set; }
        public string EMail { get; set; }
        public string FaceBook { get; set; }
        public string WhatsApp { get; set; }
        public string Contact_From { get; set; }
        public string Contact_To { get; set; }
        public string Sex { get; set; }
        public string Social_Status { get; set; }
        public string Car_ID { get; set; }
        public string Job { get; set; }
        public string Qualification { get; set; }
        public string Tax_Number { get; set; }
        public string Location { get; set; }
        public string Spare_C { get; set; }
        public string Notes { get; set; }
    }
}
