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
using System.Configuration;


namespace Futbol
{
    public partial class LigBilgileri : Form
    {
        public LigBilgileri()
        {
            InitializeComponent();
        }

        LigMN LigMN = new LigMN();
        FutbolcularDB FutbolcularDB = new FutbolcularDB();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        SqlDataReader dr;

        private void VeriGöster() // verileri habrie yenileyerek göstermesi için bu method yazıldı ..

        {
            FutbolcularDB.BağlantıAç();
            //con.Open();
            dt = new DataTable();
            da = new SqlDataAdapter("select * from Ligler", FutbolcularDB.con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FutbolcularDB.BağlantıKapat();
        }


        private void VerileriTemizle()
        {
            LigIdtxt.Text = "";
            ligAdııtxt.Text = "";
            LigÜlkesitxt.Text = "";
            LigResmitxt.Text = "";
            ÜlkeResmitxt.Text = "";
            



        }
      
        //public void TakımÖğren()
        //{

        //    FutbolcularDB.BağlantıAç();

        //    dt = new DataTable();
        //    da = new SqlDataAdapter("SELECT LigAdı,TakımAdı FROM Ligler L INNER JOIN Takımlar T ON L.LigID=T.LigID WHERE L.LigAdı= '" + ligAdııtxt.Text + "'", FutbolcularDB.con);
        //    da.Fill(dt);
        //    dataGridView2.DataSource = dt;
        //    FutbolcularDB.BağlantıKapat();


        //}

       
        private void LigBilgileri_Load(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = LigMN.GetLigler();
            FutbolcularDB.BağlantıAç();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  Ligler", FutbolcularDB.con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
            this.dataGridView1.Columns["LigResmi"].Visible = false;
            this.dataGridView1.Columns["ÜlkeResmi"].Visible = false;
        }
      
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Ligler l=new Ligler();

            l.LigID=Convert.ToInt32(LigIdtxt.Text);
            l.LigAdı = ligAdııtxt.Text;
            l.LigAdı=ligAdııtxt.Text;
            l.LigÜlkesi = LigÜlkesitxt.Text;
            l.LigResmi = LigResmitxt.Text;
            l.ÜlkeResmi = ÜlkeResmitxt.Text;
         


            var kontrol = LigMN.InsertLigler(l);

            dataGridView1.DataSource = LigMN.GetLigler();
            if (kontrol)
            {

                VerileriTemizle();
                MessageBox.Show("Lig Bilgileri Başarıyla Eklendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Ligler l = new Ligler();


            l.LigID = Convert.ToInt32(LigIdtxt.Text);
            l.LigAdı = ligAdııtxt.Text;
            l.LigAdı = ligAdııtxt.Text;
            l.LigÜlkesi = LigÜlkesitxt.Text;
            l.LigResmi = LigResmitxt.Text;
            l.ÜlkeResmi = ÜlkeResmitxt.Text;


            var kontrol = LigMN.UpdateLigler(l);

            dataGridView1.DataSource = LigMN.GetLigler();
            if (kontrol)
            {

                VerileriTemizle();
                MessageBox.Show("Lig Bilgileri Başarıyla Güncellendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");

            VeriGöster();

        }

        private void btnLigResmi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            LigResmitxt.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void btnÜlkeResmi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            ÜlkeResmitxt.Text = dosyayolu;
            pictureBox2.ImageLocation = dosyayolu;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LigIdtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ligAdııtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LigÜlkesitxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pictureBox2.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            VerileriTemizle();

        }

        private void btnLigTakımları_Click(object sender, EventArgs e)
        {
            TakımlarıÖğren takımlarıÖğren=new TakımlarıÖğren(ligAdııtxt);
            takımlarıÖğren.LigAdı = ligAdııtxt.Text;
            takımlarıÖğren.ShowDialog();

          
        }

        private void btnLigGetir_Click(object sender, EventArgs e)
        {
            VeriGöster();
        }

        private void btnOyuncular_Click(object sender, EventArgs e)
        {
            LiglerdekiFutbolcular liglerdekiFutbolcular = new LiglerdekiFutbolcular(ligAdııtxt);
            liglerdekiFutbolcular.LigAdı = ligAdııtxt.Text;
            liglerdekiFutbolcular.ShowDialog();
            
        }

        private void btnLigAdınaGöre_Click(object sender, EventArgs e)
        {

            dt.DefaultView.RowFilter = "LigAdı ='" + ligAdııtxt.Text + "'";
            dataGridView1.DataSource = dt.DefaultView.ToTable();
        }
    }
}
