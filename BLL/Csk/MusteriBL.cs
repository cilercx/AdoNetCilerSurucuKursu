using BaseCore.DATA.ADONET;
using DataCore.Csk;
using MODEL.Csk;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Csk
{
    public class MusteriBL : BaseBL, IMainBL<Musteri>//BaseBL den kalıtıp(inherit ediyorum..), IMainBL den metodları implement ediyorum hangi classı gönderdiysem onunla..
    {
        public bool Ekle(Musteri nesne)
        {
            bool result = false;
            try
            {
                using (CskHelper h = new CskHelper())
                {

                    SqlParameter[] p =
                    {
                        new SqlParameter("@Ad",nesne.Ad),
                        new SqlParameter("@Soyad",nesne.Soyad),
                        new SqlParameter("@Tc",nesne.Tc),
                        new SqlParameter("@Telefon",nesne.Telefon),
                        new SqlParameter("@Adres",nesne.Adres),
                        new SqlParameter("@KaydiOlusturan",nesne.KaydiOlusturan),
                        new SqlParameter("@GuncelleyenKisi",nesne.GuncelleyenKisi),
                        new SqlParameter("@KayitTarihi",nesne.KayitTarihi),
                        new SqlParameter("@GuncellenmeTarihi",nesne.GuncellenmeTarihi)

                    };
                    result = h.ExecuteCommand("Insert into Musteri values(@Ad,@Soyad,@Tc,@Telefon,@Adres,@KaydiOlusturan,@GuncelleyenKisi,@KayitTarihi,@GuncellenmeTarihi)", p) > 0;// executecommand int döndüğü için sonucun 0'dan büyük olup olmadığı kontrol edilir.
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }       

        public void Guncelle()
        {
            throw new NotImplementedException();
        }

        public Musteri Getir(int id)
        {
            Musteri mus = new Musteri();//propertyleri almak için newledik..
            try
            {
                using (CskHelper h = new CskHelper())
                {
                    SqlParameter[] p =
                    {
                        new SqlParameter("@id",id)
                    };
                    SqlDataReader rd = h.GetData("Select * from Musteri where Id=@id", p);
                    if (rd.HasRows)
                    {
                        if (rd.Read())
                        {
                            mus.Ad = rd["Ad"].ToString();
                            mus.Soyad = rd["Soyad"].ToString();
                            mus.Tc = rd["Tc"].ToString();
                            mus.Telefon =rd["Telefon"].ToString();
                            mus.Adres = rd["Adres"].ToString();
                            mus.KaydiOlusturan = rd["KaydiOlusturan"].ToString();
                            mus.GuncelleyenKisi = rd["GuncelleyenKisi"].ToString();
                            mus.KayitTarihi = Convert.ToDateTime(rd["KayitTarihi"]);
                            mus.GuncellenmeTarihi = Convert.ToDateTime(rd["GuncellenmeTarihi"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return mus;
        }

        public bool Guncelle(Musteri nesne)//Ekle metodu gibi ama Id eklenerek geliyor sadece..
        {
            bool result = false;
            try
            {
                using (CskHelper h = new CskHelper())
                {

                    SqlParameter[] p =
                    {
                        new SqlParameter("@Id",nesne.Id),
                        new SqlParameter("@Ad",nesne.Ad),
                        new SqlParameter("@Soyad",nesne.Soyad),
                        new SqlParameter("@Tc",nesne.Tc),
                        new SqlParameter("@Telefon",nesne.Telefon),
                        new SqlParameter("@Adres",nesne.Adres),  
                        new SqlParameter("@KayitTarihi",nesne.KayitTarihi),
                        new SqlParameter("@GuncellenmeTarihi",nesne.GuncellenmeTarihi)                        
                     };
                    result = h.ExecuteCommand("Update Musteri Set Ad=@Ad,Soyad=@Soyad,Tc=@Tc,Telefon=@Telefon,Adres=@Adres,KayitTarihi=@KayitTarihi,GuncellenmeTarihi=@GuncellenmeTarihi where Id=@Id", p) > 0;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public List<Musteri> ListeGetir()// getir metodu gibi..burda tek bir nesne dönmeyeceği için list<> döneceği için list<> kullanılır..
        {
            List<Musteri> clients = new List<Musteri>();
            try
            {
                using (CskHelper h = new CskHelper())//bağlantıyı kuruyorum burda..
                {

                    SqlDataReader rd = h.GetData("Select * from Musteri");//bütün müsteri listemi okuyor.."Select * from Musteri" getdatanın parametresidir.
                    if (rd.HasRows)//tabloda satır varsa..
                    {
                        while (rd.Read())// if değil bu sefer 1 satır yok cünkü birden fazla satır oldugu için satırları okudukca dönsün diyoruz..
                        {

                            Musteri clnt = new Musteri();// okunan satır için bir tane clnt nesnesi olustur, onların değerlerini data baseden al,bunu listeye ekle ardından tekrar yeni satırı oku..
                            clnt.Id = Convert.ToInt32(rd["Id"]);
                            clnt.Ad = rd["Ad"].ToString();
                            clnt.Soyad = rd["Soyad"].ToString();
                            clnt.Tc = rd["Tc"].ToString();
                            clnt.Telefon = rd["Telefon"].ToString();
                            clnt.Adres = rd["Adres"].ToString();
                            clnt.KaydiOlusturan = rd["KaydiOlusturan"].ToString();
                            clnt.GuncelleyenKisi = rd["GuncelleyenKisi"].ToString();
                            clnt.KayitTarihi = Convert.ToDateTime(rd["KayitTarihi"]);
                            clnt.GuncellenmeTarihi = Convert.ToDateTime(rd["GuncellenmeTarihi"]);
                            clients.Add(clnt);// eklediğim tüm (clnt) leri (clients) listeme ekliyorum..
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return clients;
        }

        public bool Sil(int Id)
        {
            bool result = false;
            try
            {
                using (CskHelper h = new CskHelper())
                {
                    SqlParameter[] p ={ new SqlParameter("@id",Id)};
                   result= h.ExecuteCommand("Delete from Musteri where id=@id", p)>0;                    
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}
