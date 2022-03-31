using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol.Model;
using Futbol.DBManager;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace Futbol.DBManager
{
    internal class LigMN
    {
        
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand com;
        SqlDataReader dr;


        FutbolcularDB FutbolcularDB = new FutbolcularDB();

        
        public void OyuncuÖğren(DataGridView dataGrid,TextBox text)
        {
            FutbolcularDB.BağlantıAç();

            dt = new DataTable();
            da = new SqlDataAdapter("SELECT FutbolcuAd,FutbolcuSoyad,TakımAdı  FROM  Futbolcular F INNER JOIN Takımlar T ON F.TakımID=T.TakımID INNER JOIN Ligler L ON T.LigID=L.LigID WHERE L.LigAdı='" + text.Text + "'", FutbolcularDB.con);
            da.Fill(dt);
            dataGrid.DataSource = dt;
            FutbolcularDB.BağlantıKapat();



        }


        public void TakımÖğren(DataGridView dataGrid,TextBox text)
        {

            FutbolcularDB.BağlantıAç();

            dt = new DataTable();
            da = new SqlDataAdapter("SELECT LigAdı,TakımAdı FROM Ligler L INNER JOIN Takımlar T ON L.LigID=T.LigID WHERE L.LigAdı= '" + text.Text + "'", FutbolcularDB.con);
            da.Fill(dt);
            dataGrid.DataSource = dt;
            FutbolcularDB.BağlantıKapat();


        }
        //public void DataGridviewSetting(DataGridView dataGrid)
        //{
        //    //dataGrid.RowHeadersVisible = false;
        //    //dataGrid.BorderStyle = BorderStyle.None;
        //    dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 70, 30);
        //    dataGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 40, 30);
        //    dataGrid.DefaultCellStyle.SelectionForeColor = Color.White;
        //    dataGrid.EnableHeadersVisualStyles = false;
        //    dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        //    dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 40, 30);
        //    dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



        //}

        private const string InsertQuery = "INSERT INTO Ligler(LigID,LigAdı,LigÜlkesi,LigResmi,ÜlkeResmi) values (@İD,@AD,@ÜLKE,@LİGRESİM,@ÜLKERESİM)";


        public bool InsertLigler(Ligler l)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(FutbolcularDB.yol))
            {
                FutbolcularDB.BağlantıAç();
                Ligler ligler = new Ligler();

                using (SqlCommand com = new SqlCommand(InsertQuery, FutbolcularDB.con))
                {
                    com.Parameters.AddWithValue("@İD", l.LigID);
                    com.Parameters.AddWithValue("@AD", l.LigAdı);
                    com.Parameters.AddWithValue("@ÜLKE", l.LigÜlkesi); 
                    com.Parameters.AddWithValue("@LİGRESİM", l.LigResmi);
                    com.Parameters.AddWithValue("@ÜLKERESİM",l.ÜlkeResmi);


                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string UpdateQuery = "UPDATE Ligler SET LigAdı=@AD,LigÜlkesi=@ÜLKE,LigResmi=@LİGRESİM,ÜlkeResmi=@ÜlkeResim WHERE LigID=@İD";

        public bool UpdateLigler(Ligler l)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(FutbolcularDB.yol))
            {
                FutbolcularDB.BağlantıAç();
                Ligler ligler = new Ligler();

                using (SqlCommand com = new SqlCommand(UpdateQuery, FutbolcularDB.con))
                {

                    com.Parameters.AddWithValue("@İD", l.LigID);
                    com.Parameters.AddWithValue("@AD", l.LigAdı);
                    com.Parameters.AddWithValue("@ÜLKE", l.LigÜlkesi);
                    com.Parameters.AddWithValue("@LİGRESİM", l.LigResmi);
                    com.Parameters.AddWithValue("@ÜLKERESİM", l.ÜlkeResmi);


                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string DeleteQuery = "Delete from Ligler where FutbolcuId=@İD";

        public bool DeleteLigler(Ligler l)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(FutbolcularDB.yol))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, FutbolcularDB.con))
                {
                    com.Parameters.AddWithValue("@İD", l.LigID);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }


        private const string SelectQuery = "Select * from Ligler";

        public DataTable GetLigler()
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
        //public void AdaGöreAra()
        //{
        //    Ligler l=new Ligler();

        //    dt.DefaultView.RowFilter = "LigAdı ='" + l.LigAdı + "'";



        //}

    }
}
