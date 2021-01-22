
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServerApp.Models.Models
{
    public class AppUser : IdentityUser
    {
        [Column(TypeName = "nvarchar(20)")]
        public string FullName { get; set; }

        public DateTime DOB { get; set; }

        public string CNIC { get; set; }

    }
}
