using ArizaTakip.Business.Interfaces;
using ArizaTakip.Core.UnitOfWork.EntityFrameworkCore.UnitOfWork;
using ArizaTakip.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace ArizaTakip.Business.Concrete
{
    public class ArizaManager : IArizaService
    {

        private readonly IUnitOfWork _ctx;
        public ArizaManager(IUnitOfWork ctx)
        {
            _ctx = ctx;
        }

        public List<Ariza> GetirHepsi2()
        {
            var list1 = _ctx.GetRepository<Ariza>().GetAll(x => x.ArizaTanim == "askfd");
            var list2 = _ctx.GetRepository<Ariza>().GetAll().Where(x => x.ArizaTanim == "askfd");
            var list3 = _ctx.GetRepository<Ariza>().GetAll().Where(x => x.ArizaTanim == "askfd").FirstOrDefault();
            var list4 = _ctx.GetRepository<Ariza>().GetAll().FirstOrDefault(x => x.ArizaTanim == "askfd");

            var data = new Ariza
            {
                ArizaTanim = "test1",
                ArizaOlusturulmaTarih = DateTime.Now,
                ArizaAciklama = "test açıklaması"
            };

            _ctx.GetRepository<Ariza>().Insert(data);
            _ctx.GetRepository<Ariza>().Update(data);
            _ctx.GetRepository<Ariza>().Delete(data);
            _ctx.SaveChanges();
            var list = _ctx.FromSql<Ariza>("select * from ariza").ToList();
            return list;
        }

       
        public List<Ariza> GetAll(Expression<Func<Ariza, bool>> where)
        {
            return _ctx.GetRepository<Ariza>().GetAll(where).ToList();
        }

        public Ariza Get(Expression<Func<Ariza, bool>> where)
        {
            return _ctx.GetRepository<Ariza>().GetAll().FirstOrDefault(where);
        }

        public void Update(Ariza tablo)
        {
            try
            {
                _ctx.GetRepository<Ariza>().Update(tablo);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            //efArizaRepository.Guncelle(tablo);
        }

        public Ariza Insert(Ariza tablo)
        {
            try
            {
                tablo = _ctx.GetRepository<Ariza>().Insert(tablo);
                _ctx.SaveChanges();
                return tablo;
            }
            catch (Exception)
            {

                throw;
            }
            // efArizaRepository.Kaydet(tablo);
        }

        public void Delete(Ariza tablo)
        {
            try
            {
                _ctx.GetRepository<Ariza>().Delete(tablo);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
