using ArizaTakip.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Mapping
{
    public class CihazOzellikMap : IEntityTypeConfiguration<CihazOzellik>
    {
        public void Configure(EntityTypeBuilder<CihazOzellik> builder)
        {
            builder.HasKey(I => I.Id);

            //builder.HasMany(I => I.).WithOne(I => I.Kullanıcı).HasForeignKey(I => I.KullaniciId);
        }
    }
}
