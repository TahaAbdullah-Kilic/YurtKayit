using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtKayit
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=Nonentity\SQLEXPRESS;Initial Catalog=yurtotomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}
