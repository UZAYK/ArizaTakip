using ArizaTakip.Business.Interfaces;
using ArizaTakip.Core.UnitOfWork.EntityFrameworkCore.UnitOfWork;
using ArizaTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakip.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {

        private readonly IUnitOfWork _ctx;
        public PersonelManager(IUnitOfWork ctx)
        {
            _ctx = ctx;
        }
        public void Delete(Personel tablo)
        {
            try
            {
                _ctx.GetRepository<Personel>().Delete(tablo);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Personel Get(Expression<Func<Personel, bool>> where)
        {
            return _ctx.GetRepository<Personel>().GetAll().FirstOrDefault(where);
        }

        public List<Personel> GetAll(Expression<Func<Personel, bool>> where)
        {
            return _ctx.GetRepository<Personel>().GetAll(where).ToList();
        }

        public Personel Insert(Personel tablo)
        {
            throw new NotImplementedException();
        }

        public void Update(Personel tablo)
        {
            try
            {
                _ctx.GetRepository<Personel>().Update(tablo);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
          
        }


        //public List<Personel> GetirHepsi2()
        //{
        //    var list1 = _ctx.GetRepository<Personel>().GetAll(x => x.ArizaTanim == "askfd");
        //    var list2 = _ctx.GetRepository<Personel>().GetAll().Where(x => x.ArizaTanim == "askfd");
        //    var list3 = _ctx.GetRepository<Personel>().GetAll().Where(x => x.ArizaTanim == "askfd").FirstOrDefault();
        //    var list4 = _ctx.GetRepository<Personel>().GetAll().FirstOrDefault(x => x.ArizaTanim == "askfd");

        //    //var data = new Personel
        //    //{
        //    //    ArizaTanim = "test1",
        //    //    ArizaOlusturulmaTarih = DateTime.Now,
        //    //    ArizaAciklama = "test açıklaması"
        //    //};

        //    //_ctx.GetRepository<Personel>().Insert(data);
        //    //_ctx.GetRepository<Personel>().Update(data);
        //    //_ctx.GetRepository<Personel>().Delete(data);
        //    //_ctx.SaveChanges();
        //    //var list = _ctx.FromSql<Ariza>("select * from ariza").ToList();
        //    //return list;
        //}

    }      
}
