using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Futbol.Model;
using Futbol.DBManager;

namespace Futbol
{
    public partial class LiglerdekiFutbolcular : Form
    {
        public LiglerdekiFutbolcular()
        {
            InitializeComponent();
        }

        TextBox text;

        public LiglerdekiFutbolcular(TextBox box)
        {
            InitializeComponent();
            text = box;
        }

        public string LigAdı { get; set; }

        private void LiglerdekiFutbolcular_Load(object sender, EventArgs e)
        {
            LigMN ligMN = new LigMN();
            FutbolcuBilgi futbolcuBilgi = new FutbolcuBilgi();
            ligMN.OyuncuÖğren(dataGridView2, text);
            lblLigAdı.Text = LigAdı;
            //ligMN.DataGridviewSetting(dataGridView2);

        }
    }
}
