using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Csk
{//model= entitiy demek..
    public class Musteri: Base
    {

        public Musteri()
        {           
            GuncellenmeTarihi = DateTime.Now;
            KayitTarihi = DateTime.Now;
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string KaydiOlusturan { get; set; }
        public string GuncelleyenKisi { get; set; }
        


    }
}
