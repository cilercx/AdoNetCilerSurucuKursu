using CilerSurucuKursuForm.KullaniciUI;
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

namespace CilerSurucuKursuForm
{
    public partial class KMainMenu : Form
    {
        public KMainMenu()
        {
            InitializeComponent();
        }

        private void btnKEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle kform = new KullaniciEkle();
            kform.ShowDialog();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();

            kullanici.Ad = grdKullanici.SelectedRows[0].Cells[1].Value.ToString();//var olanı musterinin verilerini burdan alıyorumm..// burda ıd göndermemizin sebebi guncelle metodunda parametre olarak nesne istenmesi...
            kullanici.Soyad = grdKullanici.SelectedRows[0].Cells[2].Value.ToString();
            kullanici.Sifre = grdKullanici.SelectedRows[0].Cells[3].Value.ToString();
            kullanici.KullaniciAdi = grdKullanici.SelectedRows[0].Cells[4].Value.ToString();

            KullaniciGuncelle kgf = new KullaniciGuncelle(kullanici);                          
            kgf.ShowDialog();
        } 
    }
}
