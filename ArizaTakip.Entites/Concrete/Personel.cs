using ArizaTakip.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArizaTakip.Entities.Concrete
{
    public class Personel : ITablo
    {
        public int Id { get; set; }
        public string PerAd { get; set; } 
        public string PerUser { get; set; } 
        public string PerBirim { get; set; }
        public string Password { get; set; }

    }
}
