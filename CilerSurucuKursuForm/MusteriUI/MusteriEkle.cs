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

namespace CilerSurucuKursuForm.MusteriUI
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MusteriBL musteribl = new MusteriBL();
            Musteri mus = new Musteri();
            mus.Ad = txtMusteriAdi.Text.Trim();
            mus.Soyad = txtMusteriSoyadi.Text.Trim();
            mus.Tc = txtMusteriTc.Text.Trim();
            mus.Telefon = txtMusteriTelefon.Text.Trim();
            mus.Adres = txtMusteriAdres.Text.Trim();
            mus.KaydiOlusturan = "ali.sahin";
            mus.GuncelleyenKisi = "ali.sahin";
            if (BosKontrol() == true)
            {
                musteribl.Ekle(mus);
                MessageBox.Show("Kayıt işlemi basarılı!");

                SayfayiYenile();


            }
            else if (BosKontrol() == false)
            {

            }


        }

        private bool BosKontrol()
        {

            if (txtMusteriAdi.Text.Trim() == "" && txtMusteriSoyadi.Text.Trim() == "" && txtMusteriTc.Text.Trim() == "" && txtMusteriTelefon.Text.Trim() == "" && txtMusteriAdres.Text.Trim() == "")
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
            MusteriEkle mef = new MusteriEkle();
            mef.Close();

            MainMenu mmf = new MainMenu();
            mmf.ShowDialog();

            //MusteriBL mbl = new MusteriBL();
            //var musterilistesi = mbl.ListeGetir();

        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
