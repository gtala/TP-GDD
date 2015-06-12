using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using PagoElectronico.Datos.Helpers;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.Datos.Clases
{
    public class TransferenciaDatos
    {
        private Conexion miConexionSql;

        ///// <summary>
        ///// Devuelve un listado de Transferencias
        ///// </summary>
        ///// <returns></returns>
        //public List<Transferencia> ObtenerTransferencias(Dictionary<string, object> filtros)
        //{
        //    try
        //    {
        //        DataTable dtTransferencias = new DataTable();
        //        miConexionSql = new Conexion();
        //        XDocument filtrosXml = UtilDatos.ArmarFiltrosXml(filtros);
        //        dtTransferencias = miConexionSql.EjecutarProcedure("Sp_ObtenerTransferencias", filtrosXml, "@filtrosXml");
        //        List<Transferencia> lstTransferencias = MapearDataTableLista(dtTransferencias);

        //        return lstTransferencias;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void GuardarTransferencia(Transferencia transferencia)
        {
            try
            {
                XDocument transferenciaXml = ObtenerTransferenciaXml(transferencia);
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("@XmlTransferencia", "Sp_GuardarTransferencia", transferenciaXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public void EliminarTransferencia(int codigoTransferencia)
        //{
        //    try
        //    {
        //        miConexionSql = new Conexion();
        //        miConexionSql.EjecutarProcedure("Sp_EliminarTransferencia", "@Codigo", codigoTransferencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //private List<Transferencia> MapearDataTableLista(DataTable dtTransferencias)
        //{
        //    List<Transferencia> lstTransferencias = new List<Transferencia>();

        //    try
        //    {
        //        lstTransferencias = (from x in dtTransferencias.AsEnumerable()
        //                    select new Transferencia
        //                    {
        //                        Codigo = Convert.ToInt32(Convert.ToString(x["Transferencia_Codigo"])),
        //                        Nombre = Convert.ToString(x["Transferencia_Nombre"]),
        //                        Estado = Convert.ToBoolean(x["Transferencia_Estado"])
        //                    }).ToList();

        //        lstTransferencias = lstTransferencias.GroupBy(a => a.Codigo).Select(g => g.First()).ToList();

        //        //Cargo las funcionalidades de cada Transferencia
        //        foreach (Transferencia r in lstTransferencias)
        //        {
        //            List<Funcionalidad> lstFuncionalidades = new List<Funcionalidad>();

        //            lstFuncionalidades = (from x in dtTransferencias.AsEnumerable()
        //                                  where Convert.ToInt32(Convert.ToString(x["Transferencia_Codigo"])) == r.Codigo
        //                                       && x["Func_Codigo"] != DBNull.Value
        //                                  select new Funcionalidad
        //                                  {
        //                                      Codigo = Convert.ToInt32(Convert.ToString(x["Func_Codigo"])),
        //                                      Nombre = Convert.ToString(x["Func_Desc"])
        //                                  }).ToList();

        //            r.Funcionalidades = lstFuncionalidades;
        //        }
        //        return lstTransferencias;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        private XDocument ObtenerTransferenciaXml(Transferencia transferencia)
        {
            
            XDocument transferenciaXml = new XDocument(
                new XElement("Transferencia",
                new XElement("NroOperacion", transferencia.NroOperacion),
                new XElement("Importe", transferencia.Importe),
                new XElement("Costo", transferencia.Costo),
                new XElement("CuentaDestino", transferencia.CuentaDestino),
                new XElement("CuentaOrigen", transferencia.CuentaOrigen),
                new XElement("Fecha", transferencia.Fecha.ToString())
                ));
            return transferenciaXml;
        }
    }
}
