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
    public partial class MusteriGuncelle : Form
    {
        public Musteri Must;//yeni olusturalan Musteri tipinde Must nesnesinin bilgileri diğer mainmenüden gelen Musteri tipinde musteri nesnesinin  buraya doldu..
        public MusteriGuncelle(Musteri Mus)//mus yazmamızın sebebi aracı oldugu için..mus adı önemli değil..abc yazılabilir.
        {
            InitializeComponent();
            // bir nesne new lendiğinde ctor calışır.
            txtMusteriAdi.Text = Mus.Ad;// contructor parametre olarak içindeki verileri alıp doldurduk.
            txtMusteriSoyadi.Text = Mus.Soyad;
            txtMusteriTc.Text = Mus.Tc;
            txtMusteriTelefon.Text = Mus.Telefon;
            txtMusteriAdres.Text = Mus.Adres;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MusteriBL musteribl = new MusteriBL();//guncellemek için metodumuzu cağırdık newledik.

            Musteri Must = new Musteri();//yeni oluşturduğumuz Must nesnemizi newledik.

            Must.Ad = txtMusteriAdi.Text.Trim();// içine artık yeni verileri doldurduk..
            Must.Soyad = txtMusteriSoyadi.Text.Trim();
            Must.Tc = txtMusteriTc.Text.Trim();
            Must.Telefon = txtMusteriTelefon.Text.Trim();
            Must.Adres = txtMusteriAdres.Text.Trim();

            if (musteribl.Guncelle(Must))// musteribl metodumuzdan guncelleyi çağırıp içerisine yeni içi dolu metodu gönderdik.
            {
                MessageBox.Show("Güncelleme başarılı");
                this.Close();
            }
        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxMusteriBilgileri_Enter(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAktifMi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelUrunAdi_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAktifMi_Click(object sender, EventArgs e)
        {

        }
    }
}

