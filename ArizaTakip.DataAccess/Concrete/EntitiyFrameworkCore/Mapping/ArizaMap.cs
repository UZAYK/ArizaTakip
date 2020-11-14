using ArizaTakip.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Mapping
{
    public class ArizaMap : IEntityTypeConfiguration<Ariza>
    {
        
        public void Configure(EntityTypeBuilder<Ariza> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.ArizaTanim).HasMaxLength(100).IsRequired();
            builder.Property(I => I.ArizaAciklama).HasColumnType("ntext");

            //builder.HasMany(I => I.Calismalar).WithOne(I => I.Kullanıcı).HasForeignKey(I => I.KullaniciId);
        }
    }
}
