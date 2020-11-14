using ArizaTakip.Business.Interfaces;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Repositories;
using ArizaTakip.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ArizaTakip.Business.Concrete
{
    public class CevapManager : ICevapService
    {
        private readonly EfCevapRepository efCevapRepository;
        public CevapManager()
        {
            efCevapRepository = new EfCevapRepository();
        }

        public Cevap Get(Expression<Func<Cevap, bool>> where)
        {
            return efCevapRepository.GetirIdile(0);
        }

        public void Update(Cevap tablo)
        {
            efCevapRepository.Guncelle(tablo);
        }



        public void Delete(Cevap tablo)
        {
            efCevapRepository.Sil(tablo);
        }

        public Cevap Insert(Cevap tablo)
        {
            throw new NotImplementedException();
        }

        public List<Cevap> GetAll(Expression<Func<Cevap, bool>> where = null)
        {
            throw new NotImplementedException();
        }
    }
}
