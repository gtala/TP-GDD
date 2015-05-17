using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace clases
{
    public class Conexiones
    {
        public SqlConnection conn = new SqlConnection();

        public SqlConnection conectarse() 
        {

            conn.ConnectionString = ConfigurationSettings.AppSettings["conexion"];
            conn.Open();
            return conn;
        }

        




    }
}
