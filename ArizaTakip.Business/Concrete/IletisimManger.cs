using ArizaTakip.Business.Interfaces;
using ArizaTakip.Core.UnitOfWork.EntityFrameworkCore.UnitOfWork;
using ArizaTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ArizaTakip.Business.Concrete
{
    public class IletisimManger : IIletisimService
    {
        private readonly IUnitOfWork _ctx;
        public IletisimManger(IUnitOfWork ctx)
        {
            _ctx = ctx;
        }

         Iletisim IGenericService<Iletisim>.Insert(Iletisim tablo)
        {
            try
            {
                tablo = _ctx.GetRepository<Iletisim>().Insert(tablo);
                _ctx.SaveChanges();
                return tablo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        void IGenericService<Iletisim>.Delete(Iletisim tablo)
        {
            try
            {
                _ctx.GetRepository<Iletisim>().Delete(tablo);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void IGenericService<Iletisim>.Update(Iletisim tablo)
        {
            try
            {
                _ctx.GetRepository<Iletisim>().Update(tablo);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        Iletisim IGenericService<Iletisim>.Get(Expression<Func<Iletisim, bool>> where)
        {
            return _ctx.GetRepository<Iletisim>().GetAll().FirstOrDefault(where);
        }

        List<Iletisim> IGenericService<Iletisim>.GetAll(Expression<Func<Iletisim, bool>> where)
        {
            return _ctx.GetRepository<Iletisim>().GetAll(where).ToList();
        }
    }
}
