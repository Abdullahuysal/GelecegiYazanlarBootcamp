using EntityFrameworkHomeWork.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHomeWork.Data
{
    public class CompanyDbContext:DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department>Departments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CompanyDb;Integrated security=true");
        }

    }
}
