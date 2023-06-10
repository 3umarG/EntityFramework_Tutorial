using Mapping_Migration02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Config.O_O.P_T
{
    public class PaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder
                .HasKey(P => P.ID);

            builder
            .Property(P => P.ID)
            .ValueGeneratedOnAdd();

            /// to Apply the ONE - ONE Relationship from the two sides
            /// IsRequired() ===> for announce the Payment Side is Totally Participant 
            builder
                .HasOne(P => P.Order)
                .WithOne(O => O.Payment)
                .HasForeignKey<Payment>(P => P.OrderID)
                .HasConstraintName("FK_Payment_Order_OrderID")
                .IsRequired();
        }
    }
}
