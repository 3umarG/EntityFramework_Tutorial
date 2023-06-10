using Mapping_Migration02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Config.M_M
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(S => S.StudentId)
                //.HasName("StudentId")       // to determine the Name of Key in the DB
                ;

           
            builder
                .Property(S => S.SName)
                .HasColumnName("StudentName")
                .IsRequired(true)
                .HasMaxLength(50);


        }
    }
}
