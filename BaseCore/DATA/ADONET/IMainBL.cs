using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCore.DATA.ADONET
{
    public interface IMainBL<T> where T:class // T sadece bir class olabilir.Musteri classı yada kullanıcı claası gibi..
    {
        bool Ekle(T nesne);
        bool Sil(int Id);
        bool Guncelle(T nesne);

        List<T> ListeGetir();

        T Getir(int id);

       
    }
}
