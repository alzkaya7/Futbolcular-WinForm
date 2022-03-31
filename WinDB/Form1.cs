using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinDB.Model;
using WinDB.DBManager;
using System.Data.SqlClient;

namespace WinDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // BAĞLANTILI YÖNTEM İLE LİSTBOX A VERİLERİ EKLEME ..
        {
            //Ado.Net Providers
            //OleDB..
            //SQL (Tercihen)
            //Oracle


            string strConn = "Data Source=KARAKARTAL\\SQLEXPRESS;Initial Catalog=Calısma;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Musteri",conn);
            

            SqlDataReader dr = cmd.ExecuteReader();

            string strSatir="";

            while (dr.Read())
            {
                //listBox1.Items.Add(dr[0] + " " + dr[1] + " " + dr[2]);

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    strSatir += dr.GetValue(i)+" ";
                }
                listBox1.Items.Add(strSatir);
                strSatir = "";

            }
           


            conn.Close();





        }

        private void btnKaydet_Click(object sender, EventArgs e) // Kaydetme , veri ekleme , insert işlemleri ..
        {
            
            SqlConnection conn = new SqlConnection("Data Source=KARAKARTAL\\SQLEXPRESS;Initial Catalog=Calısma;Integrated Security=True");
            conn.Open();

            //Kulkanmayınız .. Bu şekilde kullanmak güvenlik açısından sıkıntılı ..
            //SqlCommand cmd = new SqlCommand("Insert into Musteri(MusteriID,MusAd,MusSoyad) values (" +int.Parse(textBox1.Text) + " ,'"  + textBox2.Text + "','" + textBox3.Text + "')",conn);

          
            SqlCommand cmd = new SqlCommand("INSERT INTO Musteri VALUES (@id,@ad,@soyad)", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@ad", textBox2.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox3.Text);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e) // güncelleme ,update işlemleri ..
        {

           
            string strConn = "Data Source=KARAKARTAL\\SQLEXPRESS;Initial Catalog=Calısma;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
       
            SqlCommand cmd=new SqlCommand("update Musteri set MusAd=@ad,MusSoyad=@soyad where  MusteriID=@id", conn);

          cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
          cmd.Parameters.AddWithValue("@ad", textBox2.Text);
          cmd.Parameters.AddWithValue("@soyad", textBox3.Text);
            
            cmd.ExecuteNonQuery ();
            conn.Close ();



        }

        private void button4_Click(object sender, EventArgs e) // ıd ye göre arama yapma ..
        {
       
            SqlConnection conn = new SqlConnection("Data Source=KARAKARTAL\\SQLEXPRESS;Initial Catalog=Calısma;Integrated Security=True");
            conn.Open();
           
             SqlCommand cmd=new SqlCommand("SELECT * FROM Musteri where MusteriID =@id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();

                panel1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Aradığınız Kayıt Bulunamadı ..");
            }
           
         




            conn.Close();

        }

        private void BtnSil_Click(object sender, EventArgs e) // silme , veri kaldırma , delete işlemleri ..
        {
            string strConn = "Data Source=KARAKARTAL\\SQLEXPRESS;Initial Catalog=Calısma;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            DialogResult dr = MessageBox.Show("Kaydı Silmek İstiyor musunuz", "UYARI", MessageBoxButtons.YesNo);

            if (dr==DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Musteri where MusteriID=@id", conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));


                cmd.ExecuteNonQuery();
                conn.Close();
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string strConn = "Data Source=KARAKARTAL\\SQLEXPRESS;Initial Catalog=Calısma;Integrated Security=True";
            //SqlDataAdapter da=new SqlDataAdapter();
            //da.SelectCommand = new SqlCommand("SELECT * FROM Musteri");
            //da.SelectCommand.Connection.ConnectionString = "";

            SqlDataAdapter da=new SqlDataAdapter("SELECT * FROM Musteri",strConn);

            DataTable dt = new DataTable();
            da.Fill(dt);

          DataRow satir=  dt.NewRow();
            satir[0] = "1233";
            satir[1] = "cevdettt";
            satir[2] = "korkmazzz";
            //dt.Rows.Add(satir);

            dt.Rows[0][1] = "yeni";
            dt.Rows[0][2] = "yeni";
           
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Update(dt);
            textBox4.Text = scb.GetUpdateCommand().CommandText;

            dataGridView1.DataSource = dt;




            string strSatir = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    strSatir += dt.Rows[i][j].ToString() + " ";
                }
                listBox1.Items.Add(strSatir+dt.Rows[i].RowState);
                
                strSatir = " ";
            }
           





            //MessageBox.Show(dt.Rows.Count.ToString());


        }

        private void button3_Click(object sender, EventArgs e) // DATAGRİEDWİEW E DİREKT VERİLERİN LİSTELENMESİ ..
        {
            
            SqlConnection conn = new SqlConnection("Data Source=KARAKARTAL\\SQLEXPRESS;Initial Catalog=Calısma;Integrated Security=True");
            conn.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM Musteri ", conn);
            DataTable tbl = new DataTable();
            
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PersonelDB db=new PersonelDB();
          
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();

            conn.InitialCatalog = "";
            conn.DataSource = "";
            conn.IntegratedSecurity = true;
            MessageBox.Show(conn.ConnectionString);
        }
    }
}
