using BaseCore.DATA.ADONET;
using BLL.Csk;
using CilerSurucuKursuForm.KullaniciUI;
using CilerSurucuKursuForm.MusteriUI;
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
    public partial class MainMenu : Form
    {
        public int Id { get; set; }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            MusteriBL mbl = new MusteriBL();
            var musteriListesi = mbl.ListeGetir();

            grdMusteri.DataSource = musteriListesi;
        }

        private void btnEkle_Click(object sender, EventArgs e)// yeni kisi ekleme..
        {
            MusteriEkle mform = new MusteriEkle();
            mform.ShowDialog();

           

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();

            musteri.Ad = grdMusteri.SelectedRows[0].Cells[1].Value.ToString();//var olanı musterinin verilerini burdan alıyorumm..// burda ıd göndermemizin sebebi guncelle metodunda parametre olarak nesne istenmesi...
            musteri.Soyad = grdMusteri.SelectedRows[0].Cells[2].Value.ToString();
            musteri.Tc = grdMusteri.SelectedRows[0].Cells[3].Value.ToString();
            musteri.Telefon = grdMusteri.SelectedRows[0].Cells[4].Value.ToString();
            musteri.Adres = grdMusteri.SelectedRows[0].Cells[5].Value.ToString();
            musteri.KaydiOlusturan = grdMusteri.SelectedRows[0].Cells[6].Value.ToString();
            musteri.GuncelleyenKisi = grdMusteri.SelectedRows[0].Cells[7].Value.ToString();                   
           
            MusteriGuncelle mgf = new MusteriGuncelle(musteri);
            mgf.ShowDialog();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MusteriBL musteribl = new MusteriBL();
            Id = Convert.ToInt32(grdMusteri.SelectedRows[0].Cells[1].Value);// burda ıd göndermemizin sebebi sil metodunda parametre olarak ıd istenmesi
            musteribl.Sil(Id);
        }

        private void grdMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
