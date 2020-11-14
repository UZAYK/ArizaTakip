using ArizaTakip.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArizaTakip.Entites.Concrete
{
    public class CihazOzellik : ITablo
    {
        public int Id { get; set; }
        public string COzellikTanim { get; set; }
        public string COzellikDeger { get; set; }
        // foreign key 
        public int CihazId { get; set; }
       
    }
}
