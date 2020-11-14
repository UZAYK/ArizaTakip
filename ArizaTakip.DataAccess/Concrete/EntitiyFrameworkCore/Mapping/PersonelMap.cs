using ArizaTakip.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Mapping
{
    public class PersonelMap : IEntityTypeConfiguration<Personel>
    {
         public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.PerAd).HasMaxLength(100).IsRequired();
            builder.Property(I => I.PerBirim).HasColumnType("ntext");
            builder.Property(I => I.Password).HasMaxLength(15).IsRequired();
        }
    }
}
