using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PagoElectronico.Datos.Helpers;
using PagoElectronico.Entidades.Clases;
using System.Xml.Linq;

namespace PagoElectronico.Datos.Clases
{
    public class CuentaDatos
    {
        private Conexion miConexionSql;

        /// <summary>
        /// Devuelve un listado de Cuentas
        /// </summary>
        /// <returns></returns>
        public List<Cuenta> ObtenerCuentas(Dictionary<string, object> filtros)
        {
            try
            {
                DataTable dtCuentas = new DataTable();
                miConexionSql = new Conexion();
                XDocument filtrosXml = UtilDatos.ArmarFiltrosXml(filtros);
                dtCuentas = miConexionSql.EjecutarProcedure("Sp_ObtenerCuentas", filtrosXml, "@filtrosXml");
                List<Cuenta> lstCuentas = MapearDataTableLista(dtCuentas);

                return lstCuentas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Cuenta> MapearDataTableLista(DataTable dtCuentas)
        {
            List<Cuenta> lstCuentas = new List<Cuenta>();

            try
            {
                lstCuentas = (from x in dtCuentas.AsEnumerable()
                            select new Cuenta
                            {
                                Codigo = Convert.ToInt32(Convert.ToString(x["Cuenta_Codigo"])),
                                Nombre = Convert.ToString(x["Cuenta_Nombre"]),
                                Estado = Convert.ToBoolean(x["Cuenta_Estado"])
                            }).ToList();

                lstCuentas = lstCuentas.GroupBy(a => a.Codigo).Select(g => g.First()).ToList();

                //Cargo las funcionalidades de cada Cuenta
                foreach (Cuenta r in lstCuentas)
                {
                    List<Funcionalidad> lstFuncionalidades = new List<Funcionalidad>();

                    lstFuncionalidades = (from x in dtCuentas.AsEnumerable()
                                          where Convert.ToInt32(Convert.ToString(x["Cuenta_Codigo"])) == r.Codigo
                                               && x["Func_Codigo"] != DBNull.Value
                                          select new Funcionalidad
                                          {
                                              Codigo = Convert.ToInt32(Convert.ToString(x["Func_Codigo"])),
                                              Nombre = Convert.ToString(x["Func_Desc"])
                                          }).ToList();

                    r.Funcionalidades = lstFuncionalidades;
                }
                return lstCuentas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarCuenta(Cuenta rol)
        {
            try
            {
                XDocument rolXml = ObtenerCuentaXml(rol);
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("@XmlCuenta", "Sp_GuardarCuenta", rolXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private XDocument ObtenerCuentaXml(Cuenta rol)
        {
            //Funcionalidades
            XElement xmlFuncionalidades = new XElement("Funcionalidades");
            XElement xmlFuncionalidad;
            foreach (Funcionalidad item in rol.Funcionalidades)
            {
                xmlFuncionalidad = new XElement("Funcionalidad",
                    new XElement("Codigo", item.Codigo));
                //new XElement("Nombre", item.Nombre));

                xmlFuncionalidades.Add(xmlFuncionalidad);
            }

            XDocument rolXml = new XDocument(
                new XElement("Cuenta",
                new XElement("Codigo", rol.Codigo),
                new XElement("Nombre", rol.Nombre),
                new XElement("Estado", rol.Estado),
                xmlFuncionalidades));
            return rolXml;
        }

        public void EliminarCuenta(int codigoCuenta)
        {
            try
            {
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("Sp_EliminarCuenta", "@Codigo", codigoCuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
