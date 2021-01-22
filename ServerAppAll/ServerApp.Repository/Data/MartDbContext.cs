using Microsoft.EntityFrameworkCore;
using ServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerApp.Repository.Data
{
    public class MartDbContext : DbContext
    {
        public MartDbContext(DbContextOptions<MartDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
