using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using clases;


namespace clases
{
    public class funcionalidadsql
    {

        public SqlDataAdapter obtenerFuncionalidades(Usuario usuario)
        {

            SqlConnection unacon = new Conexiones().conectarse();
            SqlCommand cmd = new SqlCommand("gdd_maxi.sp_obtenerfuncionalidadesderol", unacon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idrol", SqlDbType.Int).Value = usuario.getrol();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            unacon.Close();
            return da;
        }

        public SqlDataAdapter traerFuncionalidades()
        {

            SqlConnection unacon = new Conexiones().conectarse();
            SqlCommand cmd = new SqlCommand("gdd_maxi.sp_traerfuncionalidades", unacon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            unacon.Close();
            return da;
        } 

    }
}
