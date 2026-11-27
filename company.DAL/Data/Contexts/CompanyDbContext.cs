using company.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace company.DAL.Data.Contexts
{
    internal class CompanyDbContext : DbContext 
    {


        public CompanyDbContext() : base()
        {

        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDb;Trusted_Connection=True;");
        }


        public DbSet<Department> Departments { get; set; }
    }
}
