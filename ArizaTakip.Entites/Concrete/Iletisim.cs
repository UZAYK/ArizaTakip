using ArizaTakip.Entites.Concrete;
using ArizaTakip.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArizaTakip.Entities.Concrete
{
    public class Iletisim : ITablo
    {

        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciMail { get; set; }
        public string Ileti { get; set; }
        public string Fotograf { get; set; }
        public DateTime Tarih { get; set; }


    }
}
