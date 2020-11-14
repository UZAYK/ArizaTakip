using ArizaTakip.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ArizaTakip.Business.Interfaces
{
    public interface IGenericService<Tablo> where Tablo : class, ITablo, new()
    {

        Tablo Insert(Tablo tablo);
        void Delete(Tablo tablo);
        void Update(Tablo tablo);
        Tablo Get(Expression<Func<Tablo, bool>> where);
        List<Tablo> GetAll(Expression<Func<Tablo, bool>> where = null);

    }
}
