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

using System.Data.SqlClient;


namespace Futbol
{
    public partial class KadrolarıGör : Form
    {
        public KadrolarıGör()
        {
            InitializeComponent();
        }

        int TakımID;

        public KadrolarıGör(int takımId)
        {
            InitializeComponent();
            TakımID = takımId;
           
        }

        public string TakımAdı { get; set; }
      
        private void KadrolarıGör_Load(object sender, EventArgs e)
        {
        
            FutbolcuMN futbolcuMN = new FutbolcuMN();
            FutbolcuBilgi futbolcuBilgi = new FutbolcuBilgi();
            futbolcuMN.KadroGör(dataGridView2,TakımID);
            lblTakımAdı.Text = TakımAdı;
            
            
        }

      
    }
}
