using Mapping_Migration02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Context
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-EF44UM4\\SQLEXPRESS;Initial Catalog=CompanyEF;Integrated Security=True;TrustServerCertificate=True");

        public override int SaveChanges()
        {
            // get all Entities that are in this Context
            var Entities = from E in ChangeTracker.Entries()
                           where E.State == EntityState.Added || E.State == EntityState.Modified
                           select E.Entity;

            // for loop through all entites and check all validations on it before SaveChanges()
            foreach (var Entity in Entities)
            {
                var validationContext = new ValidationContext(Entity);
                Validator.ValidateObject(Entity, validationContext , true);
            }


            return base.SaveChanges();
        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
