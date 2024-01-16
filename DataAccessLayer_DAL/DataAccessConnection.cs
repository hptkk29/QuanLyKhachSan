using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class DataAccessConnection
    {
        private static string DATABASE_URL = "Data Source=DESKTOP-5HLH4RJ\\SQLEXPRESS;Initial Catalog=qlks;Persist Security Info=True;User ID=sa;Password=123456";
        public static SqlConnection getConnection()
        {
            SqlConnection conn = null; ;
            conn = new SqlConnection(DATABASE_URL);

            return conn;
        }

    }
}
