using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13_11_23.Models;
using Microsoft.EntityFrameworkCore;

namespace _13_11_23.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=TX;database=Sigmas;trusted_connection=true;integrated security=true;encrypt=false;");
        }

        public DbSet<Student> Students { get; set; }


    }
}
