using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        protected static SqlConnection con;
        public static SqlConnection Connection()
        {
            string conStr = ConfigurationManager.ConnectionStrings["QLTaiXe"].ToString();
            con = new SqlConnection(conStr);
            con.Open();
            return con;
        }
        public static SqlConnection Disconnection()
        {
            con.Close();
            return con;
        }
    }
}
