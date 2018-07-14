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
    public partial class KullaniciGuncelle : Form
    {
        public Kullanici kul;
        public KullaniciGuncelle(Kullanici kul)
        {
            InitializeComponent();
            txtKulAdi.Text = kul.Ad;
            txtKullaniciSoyadi.Text = kul.Soyad;
            txtKullaniciAdi.Text = kul.KullaniciAdi;
            txtSif.Text = kul.Sifre;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            KullaniciBL kulbl = new KullaniciBL();

            Kullanici kul = new Kullanici();
            kul.Ad = txtKulAdi.Text.Trim();
            kul.Soyad = txtKullaniciSoyadi.Text.Trim();
            kul.KullaniciAdi = txtKullaniciAdi.Text.Trim();
            kul.Sifre = txtSif.Text.Trim();

            if (kulbl.Guncelle(kul))
            {
                MessageBox.Show("Güncelleme başarılı");
                this.Close();
            }
        }
    }
}
