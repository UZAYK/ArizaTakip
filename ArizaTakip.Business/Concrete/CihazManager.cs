using ArizaTakip.Business.Interfaces;
using ArizaTakip.Core.UnitOfWork.EntityFrameworkCore.UnitOfWork;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Repositories;
using ArizaTakip.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ArizaTakip.Business.Concrete
{
    public class CihazManager : ICihazService
    {

        private readonly IUnitOfWork _ctxx;
        public CihazManager(IUnitOfWork ctx)
        {
            _ctxx = ctx;
        }

        public List<Cihaz> GetirHepsi2()
        {
            var list1 = _ctxx.GetRepository<Cihaz>().GetAll(x => x.CihazAd == "askfd");
            var list2 = _ctxx.GetRepository<Cihaz>().GetAll().Where(x => x.CihazAd == "askfd");
            var list3 = _ctxx.GetRepository<Cihaz>().GetAll().Where(x => x.CihazAd == "askfd").FirstOrDefault();
            var list4 = _ctxx.GetRepository<Cihaz>().GetAll().FirstOrDefault(x => x.CihazAd == "askfd");

            var data = new Cihaz
            {
                CihazAd = "test1",
                CihazTip = "test1",
            };

            _ctxx.GetRepository<Cihaz>().Insert(data);
            _ctxx.GetRepository<Cihaz>().Update(data);
            _ctxx.GetRepository<Cihaz>().Delete(data);
            _ctxx.SaveChanges();
            var list = _ctxx.FromSql<Cihaz>("select * from ariza").ToList();
            return list;
        }


        public List<Cihaz> GetAll(Expression<Func<Cihaz, bool>> where)
        {
            return _ctxx.GetRepository<Cihaz>().GetAll(where).ToList();
        }

        public Cihaz Get(Expression<Func<Cihaz, bool>> where)
        {
            return _ctxx.GetRepository<Cihaz>().GetAll().FirstOrDefault(where);
        }

        public void Update(Cihaz tablo)
        {
            try
            {
                _ctxx.GetRepository<Cihaz>().Update(tablo);
                _ctxx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            //efArizaRepository.Guncelle(tablo);
        }

        public Cihaz Insert(Cihaz tablo)
        {
            try
            {
                tablo = _ctxx.GetRepository<Cihaz>().Insert(tablo);
                _ctxx.SaveChanges();
                return tablo;
            }
            catch (Exception)
            {

                throw;
            }
            // efArizaRepository.Kaydet(tablo);
        }

        public void Delete(Cihaz tablo)
        {
            try
            {
                _ctxx.GetRepository<Cihaz>().Delete(tablo);
                _ctxx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
