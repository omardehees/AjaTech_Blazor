using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class NavigationMenue_DashBoard
    {
        public string Text { get; set; }
        public string Value { get; set; } = "dashboard";
        public string Icon { get; set; }
        public NavigationMenue_DashBoard()
        {

        }
        public NavigationMenue_DashBoard(string Text, string Value, string Icon)
        {
            this.Text = Text;
            this.Value = Value;
            this.Icon = Icon;
        }
        public static List<NavigationMenue_DashBoard> GetNavigationItems_Setting_Ar()
        {
            List<NavigationMenue_DashBoard> data = new List<NavigationMenue_DashBoard>();
            data.Add(new NavigationMenue_DashBoard("النعاقدات", "/DashContracting", "icon-preference"));
            data.Add(new NavigationMenue_DashBoard("الصندوق", "/DashBox", "icon-preference"));
            data.Add(new NavigationMenue_DashBoard("المهام", "/DashMissions", "icon-preference"));
            data.Add(new NavigationMenue_DashBoard("المخازن", "/DashInventories", "icon-preference"));
            data.Add(new NavigationMenue_DashBoard("إحصائيات عامة", "/Staticses", "icon-preference"));

            return data;
        }
        public static List<NavigationMenue_DashBoard> GetNavigationItems_Setting_En()
        {
            List<NavigationMenue_DashBoard> data = new List<NavigationMenue_DashBoard>();
            data.Add(new NavigationMenue_DashBoard("Contracting", "/DashContracting", "icon-preference"));
            data.Add(new NavigationMenue_DashBoard("Box", "/DashBox", "icon-preference"));
            data.Add(new NavigationMenue_DashBoard("Missions", "/DashMissions", "icon-preference"));
            data.Add(new NavigationMenue_DashBoard("Inventories", "/DashInventories", "icon-preference"));
            data.Add(new NavigationMenue_DashBoard("Public Staticses", "/Staticses", "icon-preference"));

            return data;
        }
        
    }
}
