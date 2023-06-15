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
            /// that for apply the configuration of Table Per Hirarechy "TPH"
            //modelBuilder.Entity<Student>().HasBaseType<Person>();
            //modelBuilder.Entity<Teacher>().HasBaseType<Person>();


            /// add Discriminator mannually from my Parent Class , and control its values based on bool , Enums ...
            //modelBuilder.Entity<Person>()
            //    .HasDiscriminator(P => P.IsEmployee)
            //    .HasValue<Teacher>(true)
            //    .HasValue<Student>(false);


            /// Add Discriminator mannually for any values genereated by me
            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("PersonType")
                .HasValue<Student>("STD")
                .HasValue<Teacher>("TCH");

            base.OnModelCreating(modelBuilder);
        }

        #region Inheritance Mapping : TPH + DbSets for Every Concrete Class
        /*
        /// When use Multiple DbSet(s) for every class by default the EF map it to TPC : Table Per Class
        /// Table for every Entity
        /// 
        /// but to take the advantage of the Inheritance Relation you should reconfigure it by your hand
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        */
        #endregion

        #region Inheritance Mapping : TPH + DbSet for Only the Hirarechy
        public virtual DbSet<Person> People { get; set; }
        #endregion

    }
}
