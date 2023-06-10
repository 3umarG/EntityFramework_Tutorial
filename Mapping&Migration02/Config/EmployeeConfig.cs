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
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.ID);

            builder
                .HasOne(E => E.Project)
                .WithMany(P => P.Employees)
                .HasForeignKey(E => E.ProjId)
                .HasConstraintName("Employee_ProjectNumber_FK")
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            builder
                .HasOne(E => E.Department)
                .WithMany(D => D.Employees)
                .HasForeignKey(E => E.DeptID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
