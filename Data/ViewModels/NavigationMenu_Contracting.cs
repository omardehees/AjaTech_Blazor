using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class NavigationMenu_Contracting
    {
        public string Text { get; set; }
        public string Value { get; set; } = "dashboard";
        public string Icon { get; set; }
        public NavigationMenu_Contracting()
        {

        }
        public NavigationMenu_Contracting(string Text, string Value, string Icon)
        {
            this.Text = Text;
            this.Value = Value;
            this.Icon = Icon;
        }
        public static List<NavigationMenu_Contracting> GetNavigationItems_Setting_Ar()
        {
            List<NavigationMenu_Contracting> data = new List<NavigationMenu_Contracting>();
            data.Add(new NavigationMenu_Contracting("العملاء", "/TheCustomers", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("العرض الفني", "/TechnicalOffer", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("اعتماد العرض الفني", "/EditApproval_TechnicalOffer", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("العرض المالي", "/FinancialOffer", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("اعتماد العرض المالي", "/EditApproval_FinancialOffer", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("التعاقدات", "/Contracts", "icon-preference"));

            return data;
        }
        public static List<NavigationMenu_Contracting> GetNavigationItems_Setting_En()
        {
            List<NavigationMenu_Contracting> data = new List<NavigationMenu_Contracting>();
            data.Add(new NavigationMenu_Contracting("Customers", "/TheCustomers", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("Technical Offer", "/TechnicalOffer", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("Technical Offer Approval", "/EditApproval_TechnicalOffer", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("Financial Offer", "/FinancialOffer", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("Financial Offer Approval", "/EditApproval_FinancialOffer", "icon-preference"));
            data.Add(new NavigationMenu_Contracting("Contracting", "/Contracts", "icon-preference"));

            return data;
        }

    }
}