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
    public partial class GenelEkran : Form
    {
        public GenelEkran()
        {
            InitializeComponent();
        }

        private void btnMusIslemleri_Click(object sender, EventArgs e)
        {
            MainMenu mmainmenu = new MainMenu();
            mmainmenu.ShowDialog();

        }

        private void btnKulIslemleri_Click(object sender, EventArgs e)
        {
            KMainMenu kmainmenu = new KMainMenu();
            kmainmenu.ShowDialog();

            

        }
    }
}
