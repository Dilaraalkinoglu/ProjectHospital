using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Proje_Hastane
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-E8R1RBK\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;TrustServerCertificate=True"); // Add a semicolon here
            baglan.Open();
            return baglan;
        }
    }
}
