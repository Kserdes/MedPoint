using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedPoint.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedPoint.Data
{
    public class AppUserConfiguration : IEntityTypeConfiguration<IdentityAccount>
    {

        public void Configure(EntityTypeBuilder<IdentityAccount> builder)
        {
            builder.Property(p => p.FirstName).HasMaxLength(20);
            builder.Property(p => p.LastName).HasMaxLength(20);
            builder.Property(p => p.PhoneNumber).HasMaxLength(9);

        }
    }
}