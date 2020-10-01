using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class VM_Def_Items_Certificates
    {
public int ID { get; set; }
public string Title_Ar { get; set; }
public string Title_En { get; set; }
public string Issuer_Ar { get; set; }
public string Issuer_En { get; set; }
public string Issuer_Country_Ar { get; set; }
public string Issuer_Country_En { get; set; }
public string Certificate_Description_Ar { get; set; }
public string Certificate_Description_En { get; set; }
public string image { get; set; }
public string Activity { get; set; }
public bool Enabled { get; set; }
public bool Archived { get; set; }
public bool Deleted { get; set; }
public string Notes { get; set; }

    }
}
