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
    internal class TakımMN
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
        //SqlDataAdapter da;
        //DataTable dt;
        //SqlCommand com;
        //SqlDataReader dr;


        FutbolcularDB FutbolcularDB = new FutbolcularDB();

        private const string InsertQuery = "INSERT INTO Takımlar(TakımID,TakımAdı,Stadyum,TakımResim,LigID) values (@İD,@AD,@STADYUM,@RESİM,@LİGID)";

        public bool InsertTakımlar(Takımlar t)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(FutbolcularDB.yol))
            {
                FutbolcularDB.BağlantıAç();
                Takımlar takımlar=new Takımlar();

                using (SqlCommand com = new SqlCommand(InsertQuery, FutbolcularDB.con))
                {
                    com.Parameters.AddWithValue("@İD", t.TakımID);
                    com.Parameters.AddWithValue("@AD", t.TakımAdı);
                    com.Parameters.AddWithValue("@STADYUM", t.Stadyum);
                    com.Parameters.AddWithValue("@RESİM", t.TakımResim);
                    com.Parameters.AddWithValue("@LİGID", t.LigID);
                    


                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string UpdateQuery = "UPDATE Takımlar SET TakımAdı=@AD,Stadyum=@STADYUM,TakımResim=@RESİM,LigID=@LİGID WHERE TakımID=@İD";

        public bool UpdateTakımlar(Takımlar t)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(FutbolcularDB.yol))
            {
                FutbolcularDB.BağlantıAç();
                Takımlar takımlar = new Takımlar();
                using (SqlCommand com = new SqlCommand(UpdateQuery, FutbolcularDB.con))
                {
                    com.Parameters.AddWithValue("@İD", t.TakımID);
                    com.Parameters.AddWithValue("@AD", t.TakımAdı);
                    com.Parameters.AddWithValue("@STADYUM", t.Stadyum);
                    com.Parameters.AddWithValue("@RESİM", t.TakımResim);
                    com.Parameters.AddWithValue("@LİGID", t.LigID);



                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string DeleteQuery = "Delete from Takımlar where TakımID=@İD";

        public bool DeleteTakımlar(Takımlar t)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(FutbolcularDB.yol))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, FutbolcularDB.con))
                {
                    com.Parameters.AddWithValue("@İD", t.TakımID);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }


        private const string SelectQuery = "Select * from Takımlar";

        public DataTable GetTakımlar()
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



    }
}