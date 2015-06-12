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
        public List<Cuenta> ObtenerCuentasPorCliente(int cliente)
        {
            try
            {

                XDocument clienteXml = new XDocument(new XElement("ClienteCodigo", cliente));

                DataTable dtCuentas = new DataTable();
                miConexionSql = new Conexion();
                dtCuentas = miConexionSql.EjecutarProcedure("Sp_ObtenerCuentasPorCliente", clienteXml, "@ClienteXML");
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
                                  Numero = Convert.ToInt64(Convert.ToString(x["Cuenta_Numero"])),
                                  Pais = new Pais
                                  {
                                      Codigo = Convert.ToInt32(Convert.ToString(x["Pais_Codigo"] ?? string.Empty)),
                                      Descipcion = Convert.ToString(x["Pais_Desc"] ?? string.Empty)
                                  },
                                  Tipo = new TipoCuenta
                                  {
                                      Codigo = Convert.ToInt32(Convert.ToString(x["Tipo_Cuenta_Tipo"] ?? string.Empty)),
                                      Descipcion = Convert.ToString(x["Tipo_Cuenta_Desc"] ?? string.Empty),
                                      DiasDuracion = Convert.ToInt32(Convert.ToString(x["Tipo_Cuenta_Dias_Duracion"] == DBNull.Value ? "0" : x["Tipo_Cuenta_Dias_Duracion"])),
                                      Costo = Convert.ToDouble(Convert.ToString(x["Tipo_Cuenta_Costo"] ?? string.Empty))
                                  },
                                  MonedaCodigo = Convert.ToInt32(Convert.ToString(x["Moneda_Tipo"] ?? string.Empty)),
                                  Moneda = Convert.ToString(x["Moneda_Desc"] ?? string.Empty),
                                  Saldo = Convert.ToDouble(x["Cuenta_Saldo"] == DBNull.Value ? "0" : Convert.ToString(x["Cuenta_Saldo"])),
                                  Estado = new EstadoCuenta
                                  {
                                      Codigo = Convert.ToInt32(Convert.ToString(x["Estado_Cuenta_Id"] ?? string.Empty)),
                                      Descipcion = Convert.ToString(x["Estado_Cuenta_Desc"] ?? string.Empty)
                                  },
                                  Cliente = Convert.ToInt32(Convert.ToString(x["Cuenta_Cliente"] ?? string.Empty)),
                                  FechaCierre = x["Cuenta_Fecha_Cierre"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(Convert.ToString(x["Cuenta_Fecha_Cierre"])),
                                  FechaCreacion = Convert.ToDateTime(Convert.ToString(x["Cuenta_Fecha_Creacion"] ?? string.Empty))

                              }).ToList();

                return lstCuentas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarCuenta(Cuenta cuenta, bool esAlta)
        {
            try
            {
                XDocument cuentaXml = ObtenerCuentaXml(cuenta, esAlta);
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("@XmlCuenta", "Sp_GuardarCuenta", cuentaXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private XDocument ObtenerCuentaXml(Cuenta cuenta, bool esAlta)
        {
            XDocument cuentaXml = new XDocument(
                new XElement("Cuenta",
                new XElement("EsAlta", esAlta),
                new XElement("Numero", cuenta.Numero),
                new XElement("MonedaCodigo", cuenta.MonedaCodigo),
                new XElement("Pais", cuenta.Pais.Codigo),
                new XElement("CodCliente", cuenta.Cliente),
                new XElement("TipoCuenta", cuenta.Tipo.Codigo),
                new XElement("Estado", cuenta.Estado.Codigo),
                new XElement("FechaCreacion", Convert.ToString(cuenta.FechaCreacion))));

            if (cuenta.FechaCierre != DateTime.MinValue)
            {
                cuentaXml.Document.Root.Add(new XElement("FechaCierre", Convert.ToString(cuenta.FechaCierre)));
            }

            return cuentaXml;
        }
    }
}
