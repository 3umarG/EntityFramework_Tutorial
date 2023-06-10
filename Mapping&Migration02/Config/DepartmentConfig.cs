using Mapping_Migration02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Config
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.DeptID);

            builder 
                    .Property(D => D.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false); // varchar instead of nvarchar;

            builder
                    .Property(D => D.YearOfCreation)
                    .IsRequired(true);
        }
    }
}
