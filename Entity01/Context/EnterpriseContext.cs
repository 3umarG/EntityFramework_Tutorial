using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity01
{
    /// This class has the work of Adapter in the ADO , it is the class that connect to Database
    /// Calling , Creating , Storing , CRUD Operations
    /// all these functions impelemented through this class
    public class EnterpriseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Create the Database it self
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-EF44UM4\SQLEXPRESS;Initial Catalog=EnterpriseDB;Integrated Security=true;TrustServerCertificate=True");
        }

        // References to all Tables in the Database
        // Table = DBSet 
        // The Schema of the DB based on the prop. of the class
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

    }
}
