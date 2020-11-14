using ArizaTakip.Business.Interfaces;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Repositories;
using ArizaTakip.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ArizaTakip.Business.Concrete
{
    public class CihazOzellikManager : ICihazOzellikService
    {
        private readonly EfCihazOzellikRepository efCihazOzellikRepository;
        public CihazOzellikManager()
        {
            efCihazOzellikRepository = new EfCihazOzellikRepository();
        }

        public void Update(CihazOzellik tablo)
        {
            efCihazOzellikRepository.Guncelle(tablo);
        }

        public void Delete(CihazOzellik tablo)
        {
            efCihazOzellikRepository.Sil(tablo);
        }

        public CihazOzellik Insert(CihazOzellik tablo)
        {
            throw new NotImplementedException();
        }

        public List<CihazOzellik> GetAll(Expression<Func<CihazOzellik, bool>> where = null)
        {
            throw new NotImplementedException();
        }

        public CihazOzellik Get(Expression<Func<CihazOzellik, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
