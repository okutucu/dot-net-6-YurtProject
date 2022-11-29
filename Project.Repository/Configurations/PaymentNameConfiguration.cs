using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Configurations
{
    internal class PaymentNameConfiguration : IEntityTypeConfiguration<PaymentName>
    {
        public void Configure(EntityTypeBuilder<PaymentName> builder)
        {
            builder.Property(i => i.Name).IsRequired();
        }
    }
}
