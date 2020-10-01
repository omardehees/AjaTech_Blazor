using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class NavigationMenue_Purchases
    {
        public string Text { get; set; }
        public string Value { get; set; } = "dashboard";
        public string Icon { get; set; }
        public NavigationMenue_Purchases()
        {

        }
        public NavigationMenue_Purchases(string Text, string Value, string Icon)
        {
            this.Text = Text;
            this.Value = Value;
            this.Icon = Icon;
        }
        public static List<NavigationMenue_Purchases> GetNavigationItems_Setting_Ar()
        {
            List<NavigationMenue_Purchases> data = new List<NavigationMenue_Purchases>();
            data.Add(new NavigationMenue_Purchases("العملاء", "/Customers_", "icon-preference"));
            data.Add(new NavigationMenue_Purchases("الموردين", "/Suppliers_", "icon-preference"));
            data.Add(new NavigationMenue_Purchases("عمليات الشراء", "/Purchases_Order", "icon-preference"));
            //data.Add(new NavigationMenue_Purchases("أمر توريد", "/Supply_Order", "icon-preference"));
            //data.Add(new NavigationMenue_Purchases("أمر استلام", "/Receipt_Order", "icon-preference"));
            //data.Add(new NavigationMenue_Purchases("فاتورة شراء", "/Purchase_Invoice", "icon-preference"));
            return data;
        }
        public static List<NavigationMenue_Purchases> GetNavigationItems_Setting_En()
        {
            List<NavigationMenue_Purchases> data = new List<NavigationMenue_Purchases>();
            data.Add(new NavigationMenue_Purchases("Customers", "/Customers_", "icon-preference"));
            data.Add(new NavigationMenue_Purchases("Suppliers", "/Suppliers_", "icon-preference"));
            data.Add(new NavigationMenue_Purchases("Purchase Operations", "/Purchases_Order", "icon-preference"));
            //data.Add(new NavigationMenue_Purchases("supply order", "/Supply_Order", "icon-preference"));
            //data.Add(new NavigationMenue_Purchases("Receipt order", " /Receipt_Order", "icon-preference"));
            //data.Add(new NavigationMenue_Purchases("PurchaseInvoice", "/Purchase_Invoice", "icon-preference"));
            return data;
        }
    }
}
