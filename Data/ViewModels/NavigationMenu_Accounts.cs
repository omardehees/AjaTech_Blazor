using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class NavigationMenu_Accounts
    {
        public string Text { get; set; }
        public string Value { get; set; } = "dashboard";
        public string Icon { get; set; }
        public NavigationMenu_Accounts()
        {

        }
        public NavigationMenu_Accounts(string Text, string Value, string Icon)
        {
            this.Text = Text;
            this.Value = Value;
            this.Icon = Icon;
        }
        public static List<NavigationMenu_Accounts> GetNavigationItems_Setting_Ar()
        {
            List<NavigationMenu_Accounts> data = new List<NavigationMenu_Accounts>();
            data.Add(new NavigationMenu_Accounts("دفع/قبض نقدي", "/PayReceive_Cash", "icon-preference"));
            data.Add(new NavigationMenu_Accounts("إعتماد دفع/قبض نقدي", "/Approval_PayReceive_Cash", "icon-preference"));
            //data.Add(new NavigationMenu_Accounts("دفع/قبض ورقي", "/PayReceive_Receipts", "icon-preference"));
            //data.Add(new NavigationMenu_Accounts("إعتماد دفع/قبض ورقي", "/Approval_PayReceive_Receipts", "icon-preference"));
            data.Add(new NavigationMenu_Accounts("نشاط حساب", "/Printing_Box", "icon-preference"));
            data.Add(new NavigationMenu_Accounts("الحسابات", "/Accounts", "icon-preference"));

            return data;
        }
        public static List<NavigationMenu_Accounts> GetNavigationItems_Setting_En()
        {
            List<NavigationMenu_Accounts> data = new List<NavigationMenu_Accounts>();
            data.Add(new NavigationMenu_Accounts("Pay/Receive Cash", "/PayReceive_Cash", "icon-preference"));
            data.Add(new NavigationMenu_Accounts("Pay/Receive Cash Approval", "/Approval_PayReceive_Cash", "icon-preference"));
            //data.Add(new NavigationMenu_Accounts("Payeceive Receipts", "/PayReceive_Receipts", "icon-preference"));
            //data.Add(new NavigationMenu_Accounts("Pay/Receive Receipts Approval", "/Approval_PayReceive_Receipts", "icon-preference"));
            data.Add(new NavigationMenu_Accounts("Account Statement", "/Printing_Box", "icon-preference"));
            data.Add(new NavigationMenu_Accounts("Accounts", "/Accounts", "icon-preference"));

            return data;
        }

    }

}
