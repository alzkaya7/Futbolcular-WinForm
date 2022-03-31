using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Futbol.Model;
using Futbol.DBManager;
using System.Configuration;

namespace Futbol.DBManager
{
    
    internal class FutbolcularDB
    {

        public string yol { get; set; }

        public SqlConnection con { get; set; }


        public FutbolcuMN Futbolcular { get; set; }
        public LigMN Ligler { get; set; }
        public TakımMN Takımlar { get; set; }



        public FutbolcularDB()
        {
            yol = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            

        }

        
        public void BağlantıAç()
        {

            con=new SqlConnection(yol);
            con.Open();

        }
        public void BağlantıKapat()
        {
            con = new SqlConnection(yol);
            con.Close();

        }

      
    }
}
