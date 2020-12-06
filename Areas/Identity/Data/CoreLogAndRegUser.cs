using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CoreLogAndReg.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the CoreLogAndRegUser class
    public class CoreLogAndRegUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string FName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string SName { get; set; }
    }
}
