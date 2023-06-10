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
    public class SubjectConfig : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(S => S.SubjectId);

            builder.Property(S => S.SubName).IsRequired(true).HasMaxLength(50).HasColumnName("SubjectName");

        }
    }
}
