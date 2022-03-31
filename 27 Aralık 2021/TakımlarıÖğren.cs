using Futbol.DBManager;
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
namespace Futbol
{
    public partial class TakımlarıÖğren : Form
    {
        public TakımlarıÖğren()
        {
            InitializeComponent();
        }

        TextBox text;
        public TakımlarıÖğren(TextBox box)
        {
            InitializeComponent();
            text = box;
        }
        public string LigAdı { get; set; }
        private void TakımlarıÖğren_Load(object sender, EventArgs e)
        {
            LigMN ligMN = new LigMN();
            FutbolcuBilgi futbolcuBilgi = new FutbolcuBilgi();
            ligMN.TakımÖğren(dataGridView2, text);
            lblLigAdı.Text = LigAdı;
        }

       

    }
}
