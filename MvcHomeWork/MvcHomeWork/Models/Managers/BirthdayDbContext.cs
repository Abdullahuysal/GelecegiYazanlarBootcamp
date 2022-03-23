using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcHomeWork.Models.Managers
{
    public class BirthdayDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<participant> Participants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = localhost\SQLEXPRESS; Database = BirthdayDb; Integrated security = true");
        }
    }
}
