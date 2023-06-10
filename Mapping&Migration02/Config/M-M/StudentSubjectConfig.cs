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
    public class StudentSubjectConfig : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(S => new { S.StudentID, S.SubjectID });

            builder
                .HasOne(S => S.Student)
                .WithMany(St => St.StudentSubjects)
                .HasForeignKey(S => S.StudentID);

            builder
                .HasOne(S => S.Subject)
                .WithMany(Subject => Subject.StudentSubjects)
                .HasForeignKey(S => S.SubjectID);
        }
    }
}
