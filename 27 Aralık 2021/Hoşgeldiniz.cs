using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbol

{
    public partial class Hoşgeldiniz : Form
    {
        public Hoşgeldiniz()
        {
            InitializeComponent();
        }

        private void Hoşgeldiniz_Load(object sender, EventArgs e)
        {
            


        }

        private void btnFutbolcular_Click(object sender, EventArgs e)
        {
            FutbolcuBilgi futbolcular = new FutbolcuBilgi();
            futbolcular.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TakımBilgileri takımlar=  new TakımBilgileri(); 
            takımlar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LigBilgileri ligBilgileri = new LigBilgileri();
            ligBilgileri.Show();

        }
    }
}
