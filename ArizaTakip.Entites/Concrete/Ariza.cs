using ArizaTakip.Entites.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArizaTakip.Entites.Concrete
{
    public class Ariza : ITablo
    {

        public int Id { get; set; }
        public int CihazId { get; set; }
        public string ArizaTanim { get; set; }
        public string ArizaAciklama { get; set; }
        public DateTime ArizaOlusturulmaTarih { get; set; }
        public string Durum { get; set; }
        public DateTime KayitTarihi { get; set; }




    }
}
