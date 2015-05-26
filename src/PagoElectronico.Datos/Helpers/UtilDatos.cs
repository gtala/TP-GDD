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
    }
}
