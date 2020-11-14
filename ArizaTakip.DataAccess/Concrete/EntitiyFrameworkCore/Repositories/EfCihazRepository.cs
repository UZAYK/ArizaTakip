using System;
using System.Collections.Generic;
using ArizaTakip.DataAccess.Interfaces;
using ArizaTakip.Entites.Concrete;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;

namespace ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Repositories
{
   public class EfCihazRepository : EfGenericRepository<Cihaz>, ICihazDal
    {
        
    }
}
