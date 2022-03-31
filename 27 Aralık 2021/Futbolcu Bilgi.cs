using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Configuration;
using Futbol.Model;
using Futbol.DBManager;
using System.Collections.Generic;


namespace Futbol

{
    public partial class FutbolcuBilgi : Form
    {
        public FutbolcuBilgi()
        {
            InitializeComponent();
        }

        FutbolcuMN futbolcuMN = new FutbolcuMN();
        FutbolcularDB FutbolcularDB=    new FutbolcularDB();

       

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;



        public void VeriGöster() // verileri habrie yenileyerek göstermesi için bu method yazıldı ..

        {
            FutbolcularDB.BağlantıAç();
            //con.Open();
            dt = new DataTable();
            da = new SqlDataAdapter("select * from Futbolcular", FutbolcularDB.con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FutbolcularDB.BağlantıKapat();
        }

        private void VerileriTemizle()
        {
            FutbolcuAdTxt.Text = "";
            FutbolcuSoyadTxt.Text = "";
            FutbolcuIdTxt.Text = "";
            FutbolcuNoTxt.Text = "";
            FutbolcuUlkeTxt.Text = "";
            FutbolcuYaşTxt.Text = "";
            FutbolcuBonservisTxt.Text = "";
            FutbolcuResimTxt.Text = "";
            TakımIdCmbx.Text = "";
 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FutbolcuMN futbolcuMN=new FutbolcuMN();
            futbolcuMN.chargerCmbx(TakımIdCmbx);
            VeriGöster();

            //dataGridView1.DataSource = futbolcuMN.GetFutbolcu();
            //FutbolcularDB.BağlantıAç();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  Futbolcular", FutbolcularDB.con);
            //dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            this.dataGridView1.Columns["TakımID"].Visible = false;
            this.dataGridView1.Columns["FutbolcuResim"].Visible = false;
            TakımIdCmbx.SelectedIndex = 1;

            //FutbolcularDB.BağlantıAç();
            //cmd = new SqlCommand("SELECT TakımAdı,TakımID FROM Ligler L INNER JOIN Takımlar T ON L.LigID=T.LigID ", FutbolcularDB.con);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    TakımAdCmbx.Items.Add(dr["TakımAdı"]);
            //    TakımIdCmbx.Items.Add(dr["TakımID"]);
            //}
            //con.Close();


        }

        //public void chargerCmbx()
        //{
        //    dt= new DataTable("Takımlar");
        //    FutbolcularDB.BağlantıAç();
        //    cmd = new SqlCommand("SELECT TakımID,TakımAdı FROM Takımlar", FutbolcularDB.con);
        //    dr=cmd.ExecuteReader();
        //    dt.Load(dr);
        //    TakımIdCmbx.DisplayMember = "TakımAdı";
        //    TakımIdCmbx.ValueMember = "TakımID";
        //    TakımIdCmbx.DataSource= dt;
        //    TakımIdCmbx.Text = TakımIdCmbx.DisplayMember;
        //    FutbolcularDB.BağlantıKapat();



        //}

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            Futbolcular f = new Futbolcular();

            f.FutbolcuID = Convert.ToInt32(FutbolcuIdTxt.Text);
            f.FutbolcuAd = FutbolcuAdTxt.Text;
            f.FutbolcuSoyad = FutbolcuSoyadTxt.Text;
            f.FutbolcuNumara = Convert.ToInt32(FutbolcuNoTxt.Text);
            f.FutbolcuÜlke = FutbolcuUlkeTxt.Text;
            f.FutbolcuYaş = Convert.ToInt32(FutbolcuYaşTxt.Text);
            f.FutbolcuBonservis = FutbolcuBonservisTxt.Text;
            f.FutbolcuResim = FutbolcuResimTxt.Text;
            f.TakımID = Convert.ToInt32(TakımIdCmbx.SelectedValue);

            futbolcuMN.InsertFutbolcular(f);

            VeriGöster();

            //Futbolcular f = new Futbolcular();


            //f.FutbolcuID = Convert.ToInt32(FutbolcuIdTxt.Text);
            //f.FutbolcuAd = FutbolcuAdTxt.Text;
            //f.FutbolcuSoyad = FutbolcuSoyadTxt.Text;
            //f.FutbolcuNumara = Convert.ToInt32(FutbolcuNoTxt.Text);
            //f.FutbolcuÜlke = FutbolcuUlkeTxt.Text;
            //f.FutbolcuYaş = Convert.ToInt32(FutbolcuYaşTxt.Text);
            //f.FutbolcuBonservis = FutbolcuBonservisTxt.Text;
            //f.FutbolcuResim= FutbolcuResimTxt.Text;
            //f.TakımID = Convert.ToInt32(TakımIdCmbx.SelectedValue);


            //var kontrol = futbolcuMN.InsertFutbolcular(f);

            //dataGridView1.DataSource = futbolcuMN.GetFutbolcu();
            //if (kontrol)
            //{

            //    VerileriTemizle();
            //    MessageBox.Show("Futbolcu Başarıyla Eklendi.");
            //}
            //else
            //    MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");




            //List<Takımlar> takımlars = new List<Takımlar>()
            //{
            //    new Takımlar{TakımID=TakımIdCmbx.SelectedIndex, TakımAdı=TakımAdCmbx.Text }

            //};

            //TakımIdCmbx.DataSource = takımlars;
            //TakımIdCmbx.DisplayMember = "TakımAdı";
            //TakımIdCmbx.ValueMember = "TakımID";


            //VeriGöster();



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Futbolcular f = new Futbolcular();

            f.FutbolcuID = Convert.ToInt32(FutbolcuIdTxt.Text);
            f.FutbolcuAd = FutbolcuAdTxt.Text;
            f.FutbolcuSoyad = FutbolcuSoyadTxt.Text;
            f.FutbolcuNumara = Convert.ToInt32(FutbolcuNoTxt.Text);
            f.FutbolcuÜlke = FutbolcuUlkeTxt.Text;
            f.FutbolcuYaş = Convert.ToInt32(FutbolcuYaşTxt.Text);
            f.FutbolcuBonservis = FutbolcuBonservisTxt.Text;
            f.FutbolcuResim = FutbolcuResimTxt.Text;
            f.TakımID = Convert.ToInt32(TakımIdCmbx.SelectedValue);

            futbolcuMN.UpdateFutbolcular(f);

            VeriGöster();
        }
        private void button2_Click(object sender, EventArgs e) //silme işlemi ..
        {

            Futbolcular f = new Futbolcular();

            f.FutbolcuID = Convert.ToInt32(FutbolcuIdTxt.Text);
            var kontrol = futbolcuMN.DeleteFutbolcular(f);
            dataGridView1.DataSource = futbolcuMN.GetFutbolcu();
            if (kontrol)
            {
                
                VerileriTemizle();
                MessageBox.Show("Seçilen Futbolcu Başarıyla Silindi ..");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");




        }

       

        private void button1_Click(object sender, EventArgs e) // ıd ye göre futbolcu arıyoruz ...
        {

            dt.DefaultView.RowFilter = "FutbolcuId ='" + FutbolcuIdTxt.Text + "'";
            dataGridView1.DataSource = dt.DefaultView.ToTable();
          
            //con.Open();

            //cmd = new SqlCommand("SELECT * FROM Futbolcular where FutbolcuID =@id", con);
            //cmd.Parameters.AddWithValue("@id", int.Parse(FutbolcuIdTxt.Text));
            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();

            //if (dr.HasRows)
            //{
            //    FutbolcuAdTxt.Text = dr[1].ToString();
            //    FutbolcuSoyadTxt.Text = dr[2].ToString();
            //    FutbolcuNoTxt.Text = dr[3].ToString();
            //    FutbolcuUlkeTxt.Text = dr[4].ToString();
            //    FutbolcuYaşTxt.Text = dr[5].ToString();
            //    FutbolcuBonservisTxt.Text = dr[6].ToString();
            //    FutbolcuResimTxt.Text = dr[7].ToString();
            //    TakımIdCmbx.Text = (dr[8].ToString());


            //}
            //else
            //{
            //    MessageBox.Show("Aradığınız Kayıt Bulunamadı ..");
            //}

            //con.Close();

        }

        public void KadroGör()
        {

            FutbolcularDB.BağlantıAç();

            dt = new DataTable();
            da = new SqlDataAdapter("SELECT FutbolcuAd,FutbolcuSoyad,TakımAdı FROM Futbolcular F INNER JOIN Takımlar T ON F.TakımID=T.TakımID INNER JOIN Ligler L ON L.LigID=T.LigID WHERE T.TakımID=  '" + TakımIdCmbx.SelectedValue + "'", FutbolcularDB.con);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            FutbolcularDB.BağlantıKapat();



        }
        public void OyuncuGör()
        {

            FutbolcularDB.BağlantıAç();

            dt = new DataTable();
            da = new SqlDataAdapter("SELECT FutbolcuAd,FutbolcuSoyad,TakımAdı,FutbolcuÜlke  FROM  Futbolcular F INNER JOIN Takımlar T ON F.TakımID=T.TakımID INNER JOIN Ligler L ON T.LigID=L.LigID WHERE F.FutbolcuÜlke=  '" + FutbolcuUlkeTxt.Text + "'", FutbolcularDB.con);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            FutbolcularDB.BağlantıKapat();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerileriTemizle();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)  // DATAGRİDWİEV NEYE TIKLARSA ONU O HÜCRELERE EKELEDİK ..

        {


            FutbolcuIdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            FutbolcuAdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            FutbolcuSoyadTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            FutbolcuNoTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            FutbolcuUlkeTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            FutbolcuYaşTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            FutbolcuBonservisTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            FutbolcuResimTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TakımIdCmbx.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();






        }

        private void button1_Click_1(object sender, EventArgs e) // futbolcu numarasına göre büükten küçüğe doğru sırala
        {
            dt.DefaultView.Sort = "FutbolcuNumara DESC";
            dataGridView1.DataSource = dt.DefaultView.ToTable();

            //dt.DefaultView.Sort = "FutbolcuNumara DESC";
            //dataGridView1.DataSource = dt.DefaultView.ToTable();
        }

        private void button5_Click(object sender, EventArgs e) // futbolcu adına göre arama yap

        {

            dt.DefaultView.RowFilter = "FutbolcuAd ='" + FutbolcuAdTxt.Text + "'";
            dataGridView1.DataSource = dt.DefaultView.ToTable();
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            FutbolcuResimTxt.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FutbolcuIdTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FutbolcuAdTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FutbolcuSoyadTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FutbolcuNoTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FutbolcuUlkeTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            FutbolcuYaşTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            FutbolcuBonservisTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TakımIdCmbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            int numara = (int)dataGridView1.CurrentRow.Cells[0].Value;
            ds = new DataSet();
            da = new SqlDataAdapter("Select Futbolcular.FutbolcuId AS ID,FutbolcuAd AS AD,FutbolcuSoyad AS SOYAD,FutbolcuNumara AS NUMARA,FutbolcuÜlke AS ÜLKE,FutbolcuYaş AS YAŞ,TakımAdı AS [TAKIM] FROM Futbolcular JOIN  Takımlar ON Futbolcular.TakımID=Takımlar.TakımID WHERE Futbolcular.FutbolcuId=" + numara, FutbolcularDB.con);
            FutbolcularDB.BağlantıAç();
            da.Fill(ds, "Takımlar");
            dataGridView2.DataSource = ds.Tables["Takımlar"];
            FutbolcularDB.BağlantıKapat();


        }

      

        private  void btnKadroGör_Click_1(object sender, EventArgs e)
        {
            LigBilgileri ligBilgileri = new LigBilgileri();
            KadrolarıGör kadrolarıGör = new KadrolarıGör(Convert.ToInt32(TakımIdCmbx.SelectedValue));
            kadrolarıGör.TakımAdı = TakımIdCmbx.Text;
            
            kadrolarıGör.ShowDialog ();
            
          
           
            //FutbolcuMN futbolcuMN = new FutbolcuMN();
            //futbolcuMN.KadroGör(kadrolarıGör.dataGridView2,TakımIdCmbx);
         
            
            //dataGridView1.Visible = false;
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FutbolcuIdTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FutbolcuAdTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FutbolcuSoyadTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FutbolcuNoTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FutbolcuUlkeTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            FutbolcuYaşTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            FutbolcuBonservisTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TakımIdCmbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FutbolcuIdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            FutbolcuAdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            FutbolcuSoyadTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            FutbolcuNoTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            FutbolcuUlkeTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            FutbolcuYaşTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            FutbolcuBonservisTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            FutbolcuResimTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TakımIdCmbx.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


        }

        private void TakımGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            VeriGöster();
        }

        private void btnOyuncuGör_Click(object sender, EventArgs e)
        {
            OyuncuGör();
            dataGridView1.Visible = false;
        }

        private void TakımIdCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(TakımIdCmbx.SelectedValue.ToString());
        }
    }
}
