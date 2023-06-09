using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Context
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-EF44UM4\\SQLEXPRESS;Initial Catalog=CompanyEF;Integrated Security=True;TrustServerCertificate=True");
    }
}
