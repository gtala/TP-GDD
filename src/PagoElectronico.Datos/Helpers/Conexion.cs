using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PagoElectronico.Datos.Helpers
{
    public class Conexion
    {

        private string ObjetoConEsquema(string nombreObjetoDb)
        {
            string esquema = ConfigurationManager.AppSettings["esquema"].ToString();
            return string.Format("{0}.{1}", esquema, nombreObjetoDb);
        }
        /// <summary>
        /// Ejecuta un store procedure
        /// </summary>
        /// <param name="nombreStoreProcedure">Nombre del procedure</param>
        /// <returns>Devuelve un data table cargado con los datos de la consulta</returns>
        public DataTable EjecutarProcedure(string nombreStoreProcedure)
        {
            DataTable miDataTable = new DataTable();
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionPagoElectronico"].ConnectionString;
                SqlConnection conexionSql = new SqlConnection(cadenaConexion);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = ObjetoConEsquema(nombreStoreProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexionSql;

                conexionSql.Open();
                miDataTable.Load(cmd.ExecuteReader());
                conexionSql.Close();

                return miDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable EjecutarProcedure(string nombreStoreProcedure, List<object> miListaObjetos)
        {
            DataTable miDataTable = new DataTable();
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionPagoElectronico"].ConnectionString;
                SqlConnection conexionSql = new SqlConnection(cadenaConexion);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = ObjetoConEsquema(nombreStoreProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexionSql;

                conexionSql.Open();
                miDataTable.Load(cmd.ExecuteReader());
                conexionSql.Close();

                return miDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
