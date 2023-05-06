using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernMartApplication
{
    class DBConnect
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PQ90T80;Initial Catalog=ModernMartDBS;Integrated Security=True");
        public SqlConnection GetCon()
        {
            return con;
        }
        public void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
