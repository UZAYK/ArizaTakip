
using System.Collections.Generic;
using ArizaTakip.DataAccess.Interfaces;
using ArizaTakip.Entites.Concrete;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using System.Linq;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Repositories
{
    public class EfArizaRepository : EfGenericRepository<Ariza>, IArizaDal
    {
        //public List<Ariza> GetirHepsi()
        //{
        //    using var context = new ArizaTakipContext();
        //    return context.Ariza.ToList();
        //}

        //public Ariza GetirIdile(int id)
        //{
        //    using var context = new ArizaTakipContext();
        //    return context.Ariza.Find(id);
        //}

        //public void Guncelle(Ariza tablo)
        //{
        //    using var context = new ArizaTakipContext();
        //    context.Ariza.Update(tablo);
        //    context.SaveChanges();
        //}

        //public void Kaydet(Ariza tablo)
        //{
        //        using var context = new ArizaTakipContext();
        //        context.Ariza.Add(tablo);
        //        context.SaveChanges();
            
        //}

        //public void Sil(Ariza tablo)
        //{
        //    using var context = new ArizaTakipContext();
        //    context.Ariza.Remove(tablo);
        //    context.SaveChanges();
        //}
    }
}
