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
    public partial class TakımBilgileri : Form
    {
        public TakımBilgileri()
        {
            InitializeComponent();
        }

       TakımMN takımMN=new TakımMN();
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
            da = new SqlDataAdapter("select * from Takımlar", FutbolcularDB.con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FutbolcularDB.BağlantıKapat();
        }


        private void VerileriTemizle()
        {
            TakımIdtxt.Text = "";
            TakımAdıTxt.Text = "";
            StadyumTxt.Text = "";
            TakımResimtxt.Text = "";
            LigAdıcmbx.Text = "";
            


        }
        public void chargerCmbx()
        {
            dt = new DataTable("Ligler");
            FutbolcularDB.BağlantıAç();
            cmd = new SqlCommand("SELECT LigID,LigAdı FROM Ligler", FutbolcularDB.con);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            LigAdıcmbx.DisplayMember = "LigAdı";
            LigAdıcmbx.ValueMember = "LigID";
            LigAdıcmbx.DataSource = dt;
            LigAdıcmbx.Text = LigAdıcmbx.DisplayMember;
            FutbolcularDB.BağlantıKapat();



        }
        private void BtnTakımEkle_Click(object sender, EventArgs e)
        {
         
            Takımlar t=new Takımlar();

            t.TakımID= Convert.ToInt32(TakımIdtxt.Text);
            t.TakımAdı = TakımAdıTxt.Text;
            t.Stadyum = StadyumTxt.Text;
            t.TakımResim = TakımResimtxt.Text;
            t.LigID=Convert.ToInt32(LigAdıcmbx.SelectedValue);

            var kontrol = takımMN.InsertTakımlar(t);

            dataGridView1.DataSource = takımMN.GetTakımlar();
            if (kontrol)
            {

                VerileriTemizle();
                MessageBox.Show("Takım Bilgileri Başarıyla Eklendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");

            VeriGöster();




        }


        private void btnTakımGüncelle_Click(object sender, EventArgs e)
        {

            Takımlar t = new Takımlar();

            t.TakımID = Convert.ToInt32(TakımIdtxt.Text);
            t.TakımAdı = TakımAdıTxt.Text;
            t.Stadyum = StadyumTxt.Text;
            t.TakımResim = TakımResimtxt.Text;
            t.LigID = Convert.ToInt32(LigAdıcmbx.SelectedValue);

            var kontrol = takımMN.UpdateTakımlar(t);

            dataGridView1.DataSource = takımMN.GetTakımlar();
            if (kontrol)
            {

                VerileriTemizle();
                MessageBox.Show("Takım Bilgileri Başarıyla Güncellendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");

            VeriGöster();


        }

        private void btnResimler_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            TakımResimtxt.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        
        private void TakımBilgileri_Load(object sender, EventArgs e)
        {
            chargerCmbx();
            //dataGridView1.DataSource = takımMN.GetTakımlar();
            FutbolcularDB.BağlantıAç();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  Takımlar", FutbolcularDB.con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;




            this.dataGridView1.Columns["LigID"].Visible = false;
            this.dataGridView1.Columns["TakımResim"].Visible = false;


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TakımIdtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TakımAdıTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            StadyumTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //TakımResimtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            LigAdıcmbx.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnTakımSil_Click(object sender, EventArgs e)
        {

            Takımlar t = new Takımlar();
            t.TakımID = Convert.ToInt32(TakımIdtxt.Text);
            var kontrol = takımMN.DeleteTakımlar(t);
            dataGridView1.DataSource = takımMN.GetTakımlar();
            if (kontrol)
            {

                VerileriTemizle();
                MessageBox.Show("Seçilen Takım Başarıyla Silindi ..");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }

       
       

        private void btnVeriTemizle_Click(object sender, EventArgs e)
        {
            VerileriTemizle();
        }

        private void btnİsmeGöre_Click(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "TakımAdı ='" + TakımAdıTxt.Text + "'";
            dataGridView1.DataSource = dt.DefaultView.ToTable();


        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            VeriGöster();
        }
    }
}
