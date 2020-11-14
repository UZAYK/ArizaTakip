using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using ArizaTakip.DataAccess.Interfaces;
using ArizaTakip.Entites.Interfaces;
using ArizaTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Repositories
{
    public class EfPersonelRepository : EfGenericRepository<Personel>, IPersonelDal
    {
       
    }
}
