using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Collections.Generic;

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

        public DataTable EjecutarConsultaSql(string consultaSql)
        {
            DataTable miDataTable = new DataTable();
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionPagoElectronico"].ConnectionString;
                SqlConnection conexionSql = new SqlConnection(cadenaConexion);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = consultaSql;
                cmd.CommandType = CommandType.Text;
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

        /// <summary>
        /// Ejecuta un Store, recibe un XML y devuelve un DataTable
        /// </summary>
        /// <param name="nombreStoreProcedure"></param>
        /// <param name="nombreParametroXml"></param>
        /// <param name="valorParametroXml"></param>
        /// <returns></returns>
        public DataTable EjecutarProcedure(string nombreStoreProcedure, XDocument valorParametroXml, string nombreParametroXml)
        {
            DataTable miDataTable = new DataTable();
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionPagoElectronico"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand(ObjetoConEsquema(nombreStoreProcedure)))
                    {

                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter()
                        {
                            ParameterName = nombreParametroXml,
                            SqlDbType = SqlDbType.Xml,
                            Value = new SqlXml(valorParametroXml.CreateReader())
                        });
                        con.Open();
                        miDataTable.Load(cmd.ExecuteReader());
                        con.Close();
                    }
                }
                return miDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreStoreProcedure"></param>
        /// <param name="miParametroXml"></param>
        /// <returns></returns>
        public void EjecutarProcedure(string nombreParametroXml, string nombreStoreProcedure, XDocument valorParametroXml)
        {
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionPagoElectronico"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand(ObjetoConEsquema(nombreStoreProcedure)))
                    {

                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter()
                                                                {
                                                                    ParameterName = nombreParametroXml,
                                                                    SqlDbType = SqlDbType.Xml,
                                                                    Value = new SqlXml(valorParametroXml.CreateReader())
                                                                });
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Ejecuta un store procedure y recibe un entero como parametro.
        /// </summary>
        /// <param name="nombreStoreProcedure"></param>
        /// <param name="nombreParametro"></param>
        /// <param name="parametroValor"></param>
        public void EjecutarProcedure(string nombreStoreProcedure, string nombreParametro, int parametroValor)
        {
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionPagoElectronico"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand(ObjetoConEsquema(nombreStoreProcedure)))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter()
                        {
                            ParameterName = nombreParametro,
                            SqlDbType = SqlDbType.Int,
                            Value = parametroValor
                        });
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
