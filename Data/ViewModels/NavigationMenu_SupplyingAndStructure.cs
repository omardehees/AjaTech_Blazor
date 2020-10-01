using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class NavigationMenu_SupplyingAndStructure
    {
        public string Text { get; set; }
        public string Value { get; set; } = "dashboard";
        public string Icon { get; set; }
        public NavigationMenu_SupplyingAndStructure()
        {

        }
        public NavigationMenu_SupplyingAndStructure(string Text, string Value, string Icon)
        {
            this.Text = Text;
            this.Value = Value;
            this.Icon = Icon;
        }
        public static List<NavigationMenu_SupplyingAndStructure> GetNavigationItems_Setting_Ar()
        {
            List<NavigationMenu_SupplyingAndStructure> data = new List<NavigationMenu_SupplyingAndStructure>(); 
            data.Add(new NavigationMenu_SupplyingAndStructure("إذن صرف وإسترجاع مكونات", "/SupplyRecovery_Order", "icon-preference"));
            data.Add(new NavigationMenu_SupplyingAndStructure("إعتماد صرف وإسترجاع مكونات", "/SupplyRecovery_Approval", "icon-preference"));
            data.Add(new NavigationMenu_SupplyingAndStructure("مهام العمل", "/Missions", "icon-preference"));
            data.Add(new NavigationMenu_SupplyingAndStructure("إعتماد مهام العمل", "/Approval_Missions", "icon-preference"));


            return data;
        }
        public static List<NavigationMenu_SupplyingAndStructure> GetNavigationItems_Setting_En()
        {
            List<NavigationMenu_SupplyingAndStructure> data = new List<NavigationMenu_SupplyingAndStructure>();
            data.Add(new NavigationMenu_SupplyingAndStructure("Supplying Recovery Order", "/SupplyRecovery_Order", "icon-preference"));
            data.Add(new NavigationMenu_SupplyingAndStructure("Supplying Recovery Approval", "/SupplyRecovery_Approval", "icon-preference"));
            data.Add(new NavigationMenu_SupplyingAndStructure("Work Tasks", "/Missions", "icon-preference"));
            data.Add(new NavigationMenu_SupplyingAndStructure("Missions Approval", "/Approval_Missions", "icon-preference"));


            return data;
        }

    }

}
