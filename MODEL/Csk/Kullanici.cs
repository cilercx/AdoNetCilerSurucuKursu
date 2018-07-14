using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Csk
{
    public class Kullanici
    {
        public Kullanici()
        {
            GuncellenmeTarihi = DateTime.Now;
        }

        public int Id { get; set; }

        public string KullaniciAdi { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Sifre { get; set; }

        public DateTime GuncellenmeTarihi { get; set; }

    }
}
