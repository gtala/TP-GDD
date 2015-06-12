using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data;

namespace PagoElectronico.Datos.Helpers
{
    public class UtilDatos
    {
        public static XDocument ArmarFiltrosXml(Dictionary<string, object> filtros)
        {
            XDocument filtrosXml = new XDocument();
            XElement elementoCabecera = new XElement("Filtros");
            XElement miElemento;

            if (filtros.Count > 0)
            {
                foreach (var item in filtros)
                {
                    miElemento = new XElement(item.Key, item.Value);
                    elementoCabecera.Add(miElemento);
                }
            }
            filtrosXml.Add(elementoCabecera);

            return filtrosXml;
        }

        public DataTable ObtenerTiposDocumento()
        {
            try
            {
                DataTable dtTiposDocumento = new DataTable();
                Conexion miConexionSql = new Conexion();
                dtTiposDocumento = miConexionSql.EjecutarConsultaSql("select * from [BrainStormers].[TipoDocumento]");
                return dtTiposDocumento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObtenerMonedas()
        {
            try
            {
                DataTable dtMonedas = new DataTable();
                Conexion miConexionSql = new Conexion();
                dtMonedas = miConexionSql.EjecutarConsultaSql("select * from [BrainStormers].[Moneda]");
                return dtMonedas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarAuditoriaLogin(string username, bool accesoCorrecto, int numeroIntento)
        {
            try
            {
                Conexion miConexionSql = new Conexion();
                XDocument auditoriaXml = new XDocument(
                new XElement("Auditoria",
                new XElement("Username", username),
                new XElement("AccesoCorrecto", accesoCorrecto),
                new XElement("NumeroIntento", numeroIntento)
                ));
                miConexionSql.EjecutarProcedure("@XmlAuditoria", "Sp_GuardarAuditoria", auditoriaXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObtenerTipoCuenta()
        {
            DataTable dtTipoCuenta = new DataTable();
            Conexion miConexionSql = new Conexion();
            dtTipoCuenta = miConexionSql.EjecutarConsultaSql("select * from [BrainStormers].[Tipo_Cuenta]");
            return dtTipoCuenta;
        }
    }
}
