using ArizaTakip.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArizaTakip.Entites.Concrete
{
    public class Cevap : ITablo
    {
        public int Id { get; set; }
        public string CevapAciklama { get; set; }
        public int ArizaId { get; set; }
    }
}
