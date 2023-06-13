using Mapping_Migration02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Config.O_O.P_P
{
    public class TeacherComputerConfig : IEntityTypeConfiguration<TeacherComputer>
    {
        public void Configure(EntityTypeBuilder<TeacherComputer> builder)
        {

            /// The Key of the Table
            builder.HasKey(TC => TC.TeacherID);


            /// Foreign Keys for the two sides ONE-ONE
            builder
                .HasOne(TC => TC.Teacher)
                .WithOne(T => T.TeacherComputer)
                .HasForeignKey<TeacherComputer>(TC => TC.TeacherID)
                .IsRequired();

            builder
                .HasOne(TC => TC.Computer)
                .WithOne(Computer => Computer.TeacherComputer)
                .HasForeignKey<TeacherComputer>(TC => TC.ComputerID)
                .IsRequired();

            /// The Uniqueness of the Values
            builder
                .HasIndex(TC => TC.TeacherID)
                .IsUnique();

            builder
                .HasIndex(TC => TC.ComputerID)
                .IsUnique();
        }
    }
}
