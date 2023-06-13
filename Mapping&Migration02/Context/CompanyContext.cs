using Mapping_Migration02.Config;
using Mapping_Migration02.Config.M_M;
using Mapping_Migration02.Config.O_O.P_P;
using Mapping_Migration02.Config.O_O.P_T;
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

        /// To enforce Validation in Run time that implemented by using Data Annotation . 
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
                Validator.ValidateObject(Entity, validationContext, true);
            }


            return base.SaveChanges();
        }

        /// To Use Fleunt API for Mapping as third way :
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // to use fluent API from configuration classes for each Entity
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());

            // Configuration for Many-Many Relation
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new SubjectConfig());
            modelBuilder.ApplyConfiguration(new StudentSubjectConfig());

            // Configuration for One-One Relation
            // Partial-Total
            modelBuilder.ApplyConfiguration(new PaymentConfig());

            // Partial-Partial
            modelBuilder.ApplyConfiguration(new TeacherComputerConfig());


            #region You can use this approach or you can split the configuration of each Entity by using Configuration Classes for every Entity
            /*
            modelBuilder.Entity<Department>(
                EB =>
                {
                    EB.HasKey(D => D.DeptID);

                    EB.Property(D => D.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false); // varchar instead of nvarchar

                    EB.Property(D => D.YearOfCreation)
                    .HasDefaultValue(DateTime.Now.Year);
                }
                );
            */
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Payment> Payments { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<TeacherComputer> TeachersComputers { get; set; }
    }
}
