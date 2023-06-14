using Inheritance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Context
{
    public class InheritanceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EF44UM4\\SQLEXPRESS;Initial Catalog=InheritanceEF;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // that for apply the configuration of Table Per Hirarechy "TPH"
            modelBuilder.Entity<Student>().HasBaseType<Person>();
            modelBuilder.Entity<Teacher>().HasBaseType<Person>();
        }

        #region Inheritance Mapping
        /// When use Multiple DbSet(s) for every class by default the EF map it to TPC : Table Per Class
        /// Table for every Entity
        /// 
        /// but to take the advantage of the Inheritance Relation you should reconfigure it by your hand
        #endregion
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
