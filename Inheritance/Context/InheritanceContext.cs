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


            #region Inheritance
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

            #endregion

            #region Owned Entity



            /// if I use this format EF will map the Owned Entity to Multiple Columns in the Table as Composite Attribue  
            //modelBuilder.Entity<Store>()
            //    .OwnsOne(St => St.FullAddress);

            /// If I want to Apply Normalization and make new Table for this Composite Attributes , I only add ToTable()
            /// but in that case I prefer the Joins than the Normalization , If I want any information about FullAddress
            /// I should make Join
            modelBuilder.Entity<Store>()
                .OwnsOne(St => St.FullAddress)
                .ToTable("FullAddress");
            #endregion
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
        public virtual DbSet<Store> Stores { get; set; }
        #endregion

    }
}
