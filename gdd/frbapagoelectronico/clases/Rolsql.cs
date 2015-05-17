using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace clases
{
    public class Rolsql
    
         
    {
        

        public SqlDataAdapter obtenerRoles(Usuario usuario) 
        {
                
            SqlConnection unacon = new Conexiones().conectarse();
            SqlCommand cmd = new SqlCommand("gdd_maxi.sp_obtenerrolessegunusuario", unacon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = usuario.getusername();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            unacon.Close();
            return da;
        }

        public List<int> obtenerRolescoleccion(SqlConnection unacon) 
        {
            List<int> listadenumeros = new List<int>();
            SqlCommand cmd = new SqlCommand("select idrol from gdd_maxi.roles", unacon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int numero;
                numero = int.Parse(dr["idrol"].ToString());
                listadenumeros.Add(numero);
            }
            dr.Close();
            return listadenumeros;
        } 




    }
}
