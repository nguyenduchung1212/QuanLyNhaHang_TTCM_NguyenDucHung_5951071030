using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
  public  class DBconect
    {
        private string Sever = @"LAPTOP-P9V1VQSO\SQLEXPRESS";
        private string Datase = "QL_NHAHANG";
        private string Use = "GTVT3";
        private string PASS = "GTVT3";
        public SqlConnection sqlConnection()
        {
            string connString = @"Data Source=" + Sever + ";Initial Catalog="
           + Datase + ";Persist Security Info=True;User ID=" + Use + ";Password=" + PASS;
            SqlConnection sqlConnection = new SqlConnection(connString);
            return sqlConnection;
        }


    }
}
