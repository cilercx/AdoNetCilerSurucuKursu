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
    public class KullaniciBL : BaseBL, IMainBL<Kullanici>
    {
        public bool Ekle(Kullanici kNesne)
        {
            bool result = false;
            try
            {
                using (CskHelper h = new CskHelper())//bağlantıyı kuruyorum burda..
                {
                    SqlParameter[] p =
                       {
                          new SqlParameter("@KullaniciAdi",kNesne.KullaniciAdi),
                          new SqlParameter("@Ad",kNesne.Ad),
                          new SqlParameter("@Soyad",kNesne.Soyad),
                          new SqlParameter("@Sifre",kNesne.Sifre)
                    };

                    result = h.ExecuteCommand("Insert into Kullanici values(@KullaniciAdi,@Ad,@Soyad,@Sifre)", p) > 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public Kullanici Getir(int id)
        {
            Kullanici kul = new Kullanici();
            try
            {
                using (CskHelper h = new CskHelper())
                {
                    SqlParameter[] p =
                    {
                        new SqlParameter("@id",id)
                    };
                    SqlDataReader rd = h.GetData("Select * from Kullanici where @id=id", p);
                    if (rd.HasRows)
                    {
                        if (rd.Read())
                        {
                            kul.KullaniciAdi = rd["KullaniciAdi"].ToString();
                            kul.Ad = rd["Ad"].ToString();
                            kul.Soyad = rd["Soyad"].ToString();
                            kul.Sifre = rd["Sifre"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return kul;
        }

        public bool Guncelle(Kullanici knesne)
        {
            bool result = false;
            try
            {
                using (CskHelper h = new CskHelper())//bağlantıyı kuruyorum burda..
                {
                    SqlParameter[] p =
                    {
                        new SqlParameter("@id",knesne.Id),
                        new SqlParameter("@KullaniciAdi",knesne.KullaniciAdi),
                        new SqlParameter("@Ad",knesne.Ad),
                        new SqlParameter("Soyad",knesne.Soyad),
                        new SqlParameter("Sifre",knesne.Sifre)
                    };
                    result = h.ExecuteCommand("Update Kullanici Set KullaniciAdi=@KullaniciAdi,Ad=@Ad,Soyad=@Soyad,Sifre=@Sifre", p) > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<Kullanici> ListeGetir()
        {
            List<Kullanici> kullanici = new List<Kullanici>();
            try
            {
                using (CskHelper h = new CskHelper()) 
                {
                    SqlDataReader rd = h.GetData("Select * from Kullanici");
                    if (rd.HasRows)
                    {
                        if (rd.Read())
                        {
                            Kullanici kul = new Kullanici();
                            kul.KullaniciAdi = rd["KullaniciAdi"].ToString();
                            kul.Ad = rd["Ad"].ToString();
                            kul.Soyad = rd["Soyad"].ToString();
                            kul.Sifre = rd["Sifre"].ToString();
                            kullanici.Add(kul);// eklediğim tüm (kul) leri (kullanici) listeme ekliyorum..                            
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return kullanici;            
        }

        public bool Sil(int Id)
        {
            bool result = false;
            try
            {
                using (CskHelper h = new CskHelper())
                {
                    SqlParameter[] p = { new SqlParameter("@id", Id) };
                    result = h.ExecuteCommand("Delete from Musteri where id=@id", p) > 0;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public Kullanici KullaniciDogrula(string KullaniciAdi, string Sifre)
        {
            Kullanici kullanici = null;
            try
            {
                using (CskHelper h = new CskHelper())
                {
                    SqlParameter[] p =
                    {
                        new SqlParameter("@KullaniciAdi",kullanici.KullaniciAdi),
                        new SqlParameter("@Sifre",kullanici.Sifre)
                    };
                    SqlDataReader rd = h.GetData("KullaniciDogrula", p);
                    if (rd.HasRows)
                    {
                        rd.Read();
                        kullanici = new Kullanici();
                        kullanici.Id = Convert.ToInt32(rd["Id"]);
                        kullanici.Ad = rd["Ad"].ToString();
                        kullanici.Soyad = rd["Soyad"].ToString();
                        kullanici.KullaniciAdi = rd["KullaniciAdi"].ToString();
                        kullanici.Sifre = rd["Sifre"].ToString();
                    }
                        
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return kullanici;

        }

    }
}
