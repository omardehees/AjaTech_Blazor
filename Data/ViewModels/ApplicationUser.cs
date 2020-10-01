using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaTech_Blazor.Data.ViewModels
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Language { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }


    }
}
