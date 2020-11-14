using ArizaTakip.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Mapping
{
    public class IletisimMap : IEntityTypeConfiguration<Iletisim>
    {
        public void Configure(EntityTypeBuilder<Iletisim> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.KullaniciAd).HasMaxLength(100).IsRequired();
            builder.Property(I => I.KullaniciMail).HasColumnType("ntext");
          
        }
    }
    
}
