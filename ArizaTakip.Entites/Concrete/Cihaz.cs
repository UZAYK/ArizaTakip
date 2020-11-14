using ArizaTakip.Entites.Interfaces;
using System;

namespace ArizaTakip.Entites.Concrete
{
    public class Cihaz : ITablo
    {
        public int Id { get; set; }
        public string CihazAd { get; set; }
        public string CihazTip { get; set; }
        //public string CihazDurum { get; set; }
        public DateTime CihazKayitTarihi { get; set; }
    }
}
