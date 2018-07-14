using BLL.Csk;
using MODEL.Csk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CilerSurucuKursuForm.KullaniciUI
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KullaniciBL kbl = new KullaniciBL();
            Kullanici kul = new Kullanici();
            kul.Ad = txtKullaniciAd.Text.Trim();
            kul.Soyad = txtSoyad.Text.Trim();
            kul.KullaniciAdi = txtKullaniciAdi.Text.Trim();
            kul.Sifre = txtSifre.Text.Trim();
            if (BosKontrol()== true)
            {
                kbl.Ekle(kul);
                MessageBox.Show("Kayıt işlemi basarılı!");

                SayfayiYenile();
            }
            else if (BosKontrol() == false)
            {

            }

        }

        private bool BosKontrol()
        {
            if (txtKullaniciAd.Text.Trim()=="" && txtSoyad.Text.Trim()=="" &&txtKullaniciAdi.Text.Trim()=="" &&txtSifre.Text.Trim()=="")
            {
                MessageBox.Show("Tüm alanları doldurunuz.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SayfayiYenile()
        {
            KullaniciEkle kef = new KullaniciEkle();
            kef.Close();

            KMainMenu kmainmenu = new KMainMenu();
            kmainmenu.ShowDialog();
        }
      
    }
}

