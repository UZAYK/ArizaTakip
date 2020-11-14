using ArizaTakip.DataAccess.Interfaces;
using ArizaTakip.Entites.Interfaces;
using System.Collections.Generic;
using System.Linq;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Repositories
{
    public class EfGenericRepository<Tablo> : IGenericDal<Tablo> where Tablo : class, ITablo, new()
    {
        public List<Tablo> GetirHepsi()
        {

            using var context = new ArizaTakipContext();
            return context.Set<Tablo>().ToList();
        }

        public Tablo GetirIdile(int id)
        {
            using var context = new ArizaTakipContext();
            return context.Set<Tablo>().Find(id);
        }

        public void Guncelle(Tablo tablo)
        {
            using var context = new ArizaTakipContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }

        public void Kaydet(Tablo tablo)
        {
            using var context = new ArizaTakipContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();

        }

        public void Sil(Tablo tablo)
        {
            using var context = new ArizaTakipContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }
    }
}
