using ArizaTakip.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Mapping
{
    public class CevapMap : IEntityTypeConfiguration<Cevap>
    {
        public void Configure(EntityTypeBuilder<Cevap> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(m => m.ArizaId);
            //builder.HasMany(I => I.).WithOne(I => I.Kullanıcı).HasForeignKey(I => I.KullaniciId);
        }
    }
}
