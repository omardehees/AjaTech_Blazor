using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class NavigationMenuData
    {
        public string Text { get; set; }
        public string Value { get; set; } = "dashboard";
        public string Icon { get; set; }
        public NavigationMenuData()
        {

        }
        public NavigationMenuData(string Text, string Value, string Icon)
        {
            this.Text = Text;
            this.Value = Value;
            this.Icon = Icon;
        }

        public static List<NavigationMenuData> GetNavigationItems_Setting_Ar()
        {
            List<NavigationMenuData> data = new List<NavigationMenuData>();
            data.Add(new NavigationMenuData("الشركة", "/company", "icon-preference"));
            data.Add(new NavigationMenuData("الموظفين", "/employees", "icon-preference"));
            //data.Add(new NavigationMenuData("الأصناف", "/items", "icon-preference"));
            data.Add(new NavigationMenuData("العملاء", "/customers", "icon-preference"));
            data.Add(new NavigationMenuData("الموردين", "/suppliers", "icon-preference"));

            return data;
        }
        public static List<NavigationMenuData> GetNavigationItems_Setting_En()
        {
            List<NavigationMenuData> data = new List<NavigationMenuData>();
            data.Add(new NavigationMenuData("Company", "/company", "icon-preference"));
            data.Add(new NavigationMenuData("Employees", "/employees", "icon-preference"));
            //data.Add(new NavigationMenuData("Items", "/items", "icon-preference"));
            data.Add(new NavigationMenuData("Customers", "/customers", "icon-preference"));
            data.Add(new NavigationMenuData("Suppliers", "/suppliers", "icon-preference"));
            return data;
        }
    }

}
