using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace OtobüsBiletRezarvasyon
{
    class Db
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.;Initial Catalog=DbOtobus;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
