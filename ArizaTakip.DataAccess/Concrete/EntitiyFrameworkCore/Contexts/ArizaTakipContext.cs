using Microsoft.EntityFrameworkCore;
using ArizaTakip.Entites.Concrete;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Mapping;
using Microsoft.EntityFrameworkCore.Design;
using ArizaTakip.Entities.Concrete;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Contexts
{
   public class ArizaTakipContext : DbContext
    {
        public ArizaTakipContext()
        {
        }

        public ArizaTakipContext(DbContextOptions<ArizaTakipContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=DESKTOP-39JJ5DA\\SQLSERVER; database=ArizaTakipDatabase; integrated security= true;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArizaMap());
            modelBuilder.ApplyConfiguration(new CevapMap());
            modelBuilder.ApplyConfiguration(new CihazMap());
            modelBuilder.ApplyConfiguration(new CihazOzellikMap());
            modelBuilder.ApplyConfiguration(new PersonelMap());
            modelBuilder.ApplyConfiguration(new IletisimMap());

        }

        public DbSet<Ariza> Ariza { get; set; }
        public DbSet<Cevap> Cevap { get; set; }
        public DbSet<Cihaz> Cihaz { get; set; }
        public DbSet<CihazOzellik> CihazOzellik { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
    
    }
    public class ArizaTakipContextFactory : IDesignTimeDbContextFactory<ArizaTakipContext>
    {
        ArizaTakipContext IDesignTimeDbContextFactory<ArizaTakipContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ArizaTakipContext>();
            optionsBuilder.UseSqlServer("server=DESKTOP-39JJ5DA\\SQLSERVER; database=ArizaTakipDatabase; integrated security= true;");

            return new ArizaTakipContext(optionsBuilder.Options);
        }
    }
}
