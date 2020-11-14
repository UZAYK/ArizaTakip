using ArizaTakip.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Mapping
{
    public class CihazMap : IEntityTypeConfiguration<Cihaz>
    {
        public void Configure(EntityTypeBuilder<Cihaz> builder)
        {
            builder.HasKey(I => I.Id);
            //builder.Property(I => I.CihazId).UseIdentityColumn();
        }
    }
}
