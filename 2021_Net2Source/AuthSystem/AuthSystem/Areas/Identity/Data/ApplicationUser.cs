using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Areas.Identity.Data
{
    public class ApplicationUser:IdentityUser
    {
        [PersonalData]
        [column(TypeName="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

    }
}
