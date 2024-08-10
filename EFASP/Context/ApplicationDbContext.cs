using EFASP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASP.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9CNL793\\SQLEXPRESS;Database=ASP9_EF;Trusted_Connection=True;TrustServerCertificate=True");

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
