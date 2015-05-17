using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace clases
{
    public class Usuariosql
    {
        private const String SP_obtenerusuario = "[gdd_maxi].sp_obtenerusuario";


        public static Usuario obtenerusuario(String username)
        {

            Usuario newuser = new Usuario();
            SqlDataReader dr;
            SqlConnection unacon = new Conexiones().conectarse();
            var cmd = new SqlCommand(SP_obtenerusuario, unacon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                

                
                dr = cmd.ExecuteReader();
                   
                if (dr.Read()) 
                {
                    newuser.setusername(dr["username"].ToString());
                    newuser.setpass(dr["pass"].ToString());
                    newuser.setfechacrea((DateTime)dr["fechacrea"]);
                    newuser.setfechaultmod((DateTime)dr["fechaultmod"]);
                    newuser.setpreguntasecreta(dr["preguntasecreta"].ToString());
                    newuser.setrespuestasecreta(dr["respuestasecreta"].ToString());
                    newuser.estado = int.Parse(dr["estado"].ToString());
                }

                unacon.Close();
                
            
            if (String.IsNullOrEmpty(newuser.getusername())) 
                {
                    newuser = null;
                }   
        
            return newuser;
        }

        public List<string> obtenerusuarios() 
        {
            List<string> listadeusuarios = new List<string>();
            SqlConnection unacon = new Conexiones().conectarse();

            
            SqlCommand cmd = new SqlCommand("select * from gdd_maxi.V_usuarios", unacon);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string cadena;
                cadena = dr["username"].ToString();
                listadeusuarios.Add(cadena);
            }
            unacon.Close();
            return listadeusuarios;
        }




    }
}
