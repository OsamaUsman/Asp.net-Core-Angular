using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ServerApp.Repository.Data
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options) : base(options)
        {
                
        }
        
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
