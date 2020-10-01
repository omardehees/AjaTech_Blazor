using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class NavigationMenu_Inventories
    {
        public string Text { get; set; }
        public string Value { get; set; } = "dashboard";
        public string Icon { get; set; }
        public NavigationMenu_Inventories()
        {

        }
        public NavigationMenu_Inventories(string Text, string Value, string Icon)
        {
            this.Text = Text;
            this.Value = Value;
            this.Icon = Icon;
        }
        public static List<NavigationMenu_Inventories> GetNavigationItems_Setting_Ar()
        {
            List<NavigationMenu_Inventories> data = new List<NavigationMenu_Inventories>(); 
            data.Add(new NavigationMenu_Inventories("الأصناف", "/Items", "icon-preference"));
            data.Add(new NavigationMenu_Inventories("حركة الصنف", "/Shortfalls", "icon-preference"));


            return data;
        }
        public static List<NavigationMenu_Inventories> GetNavigationItems_Setting_En()
        {
            List<NavigationMenu_Inventories> data = new List<NavigationMenu_Inventories>();
            data.Add(new NavigationMenu_Inventories("Items", "/Items", "icon-preference"));
            data.Add(new NavigationMenu_Inventories("Item Movment", "/Shortfalls", "icon-preference"));


            return data;
        }

    }
}
