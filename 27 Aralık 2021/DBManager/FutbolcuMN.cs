using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol.Model;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Futbol.DBManager;


namespace Futbol.DBManager
{
    internal class FutbolcuMN
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand com;
        SqlDataReader dr;


        FutbolcularDB FutbolcularDB = new FutbolcularDB();

        private const string InsertQuery = "INSERT INTO Futbolcular(FutbolcuId,FutbolcuAd,FutbolcuSoyad,FutbolcuNumara,FutbolcuÜlke,FutbolcuYaş,FutbolcuBonservis,FutbolcuResim,TakımID) values (@İD,@AD,@SOYAD,@NUMARA,@ÜLKE,@YAŞ,@BONSERVİS,@RESİM,@TAKIMID)";

        public void InsertFutbolcular(Futbolcular f)
        {
            FutbolcularDB.BağlantıAç();

            SqlCommand com = new SqlCommand("gp_FutbolcuEkle", FutbolcularDB.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@FutbolcuId", f.FutbolcuID);
            com.Parameters.AddWithValue("@FutbolcuAd", f.FutbolcuAd);
            com.Parameters.AddWithValue("@FutbolcuSoyad", f.FutbolcuSoyad);
            com.Parameters.AddWithValue("@FutbolcuNumara", f.FutbolcuNumara);
            com.Parameters.AddWithValue("@FutbolcuÜlke", f.FutbolcuÜlke);
            com.Parameters.AddWithValue("@FutbolcuYaş", f.FutbolcuYaş);
            com.Parameters.AddWithValue("@FutbolcuBonservis", f.FutbolcuBonservis);
            com.Parameters.AddWithValue("@FutbolcuResim", f.FutbolcuResim);
            com.Parameters.AddWithValue("@TakımID", f.TakımID);
            com.ExecuteNonQuery();

            FutbolcularDB.BağlantıKapat();

        }

        public void KadroGör(DataGridView dataGrid,int TakımID)
        {
            FutbolcuBilgi futbolcuBilgi = new FutbolcuBilgi();
            FutbolcularDB.BağlantıAç();
            
            dt = new DataTable();
            
            da = new SqlDataAdapter("SELECT FutbolcuAd,FutbolcuSoyad,FutbolcuYaş,FutbolcuÜlke FROM Futbolcular F INNER JOIN Takımlar T ON F.TakımID=T.TakımID INNER JOIN Ligler L ON L.LigID=T.LigID WHERE T.TakımID=" +TakımID, FutbolcularDB.con);
            da.Fill(dt);
            dataGrid.DataSource = dt;
            FutbolcularDB.BağlantıKapat();



        }
       
        public void chargerCmbx(ComboBox comboBox)
        {
            dt = new DataTable("Takımlar");
            FutbolcularDB.BağlantıAç();
            com = new SqlCommand("SELECT TakımID,TakımAdı FROM Takımlar", FutbolcularDB.con);
            dr = com.ExecuteReader();
            dt.Load(dr);
            comboBox.DisplayMember = "TakımAdı";
            comboBox.ValueMember = "TakımID";
            comboBox.DataSource = dt;
            comboBox.Text = comboBox.DisplayMember;
            FutbolcularDB.BağlantıKapat();



        }


        public void UpdateFutbolcular(Futbolcular f) // SAKLI PROSEDÜR KULLANDIK GÜNCELLEME İŞLEMİ İÇİN ..
        {

            FutbolcularDB.BağlantıAç();

            SqlCommand com = new SqlCommand("gp_FutbolcularGuncelle", FutbolcularDB.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@FutbolcuId", f.FutbolcuID);
            com.Parameters.AddWithValue("@FutbolcuAd", f.FutbolcuAd);
            com.Parameters.AddWithValue("@FutbolcuSoyad", f.FutbolcuSoyad);
            com.Parameters.AddWithValue("@FutbolcuNumara", f.FutbolcuNumara);
            com.Parameters.AddWithValue("@FutbolcuÜlke", f.FutbolcuÜlke);
            com.Parameters.AddWithValue("@FutbolcuYaş", f.FutbolcuYaş);
            com.Parameters.AddWithValue("@FutbolcuBonservis", f.FutbolcuBonservis);
            com.Parameters.AddWithValue("@FutbolcuResim", f.FutbolcuResim);
            com.Parameters.AddWithValue("@TakımID", f.TakımID);
            com.ExecuteNonQuery();

            FutbolcularDB.BağlantıKapat();


        }


        private const string DeleteQuery = "Delete from Futbolcular where FutbolcuId=@İD";

        public bool DeleteFutbolcular(Futbolcular f)
        {
            FutbolcularDB.BağlantıAç();
            int rows;
            using (SqlConnection con = new SqlConnection(FutbolcularDB.yol))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, FutbolcularDB.con))
                {
                    com.Parameters.AddWithValue("@İD", f.FutbolcuID);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }



        private const string SelectQuery = "Select * from Futbolcular";

        public DataTable GetFutbolcu()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(FutbolcularDB.yol))
            {
                FutbolcularDB.BağlantıAç();
                using (SqlCommand com = new SqlCommand(SelectQuery, FutbolcularDB.con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public void AdaGöreAra()
        {
            Futbolcular f = new Futbolcular();

            dt.DefaultView.RowFilter = "FutbolcuAd ='" + f.FutbolcuAd + "'";



        }

    }
}

