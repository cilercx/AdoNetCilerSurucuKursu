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

namespace CilerSurucuKursuForm
{
    public partial class Login : Form
    {
        public static Kullanici Kullanici;
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciBL bl = new KullaniciBL();
            Kullanici = bl.KullaniciDogrula(txtKulAdi.Text.Trim(), txtSifre.Text.Trim());
            if (Kullanici!= null)
            {
                KMainMenu kmainmenu = new KMainMenu();
                kmainmenu.Text= "Hoşgeldin" + " " + Kullanici.KullaniciAdi;
                this.Hide();
                kmainmenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanici Adi yada Sifre Hatali");
            }
        }
    }
}
