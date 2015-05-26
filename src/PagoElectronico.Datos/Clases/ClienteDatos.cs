using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PagoElectronico.Datos.Helpers;
using PagoElectronico.Entidades.Clases;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace PagoElectronico.Datos.Clases
{
    public class ClienteDatos
    {
        private Conexion miConexionSql;

        /// <summary>
        /// Devuelve un listado de Clientees
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ObtenerClientes(Dictionary<string, object> filtros)
        {
            try
            {
                DataTable dtClientes = new DataTable();
                miConexionSql = new Conexion();
                XDocument filtrosXml = UtilDatos.ArmarFiltrosXml(filtros);
                dtClientes = miConexionSql.EjecutarProcedure("Sp_ObtenerClientes", filtrosXml, "@filtrosXml");
                List<Cliente> lstClientes = MapearDataTableLista(dtClientes);

                return lstClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        private List<Cliente> MapearDataTableLista(DataTable dtClientes)
        {
            try
            {
                List<Cliente> lstClientes = dtClientes.AsEnumerable().Select(x => new Cliente()
                {
                    Codigo = Convert.ToInt32(Convert.ToString(x["Cliente_Codigo"])),
                    Nombre = Convert.ToString(x["Cliente_Nombre"] ?? string.Empty),
                    Apellido = Convert.ToString(x["Cliente_Apellido"] ?? string.Empty),
                    Tipo_Doc_Codigo = Convert.ToInt32(Convert.ToString(x["Cliente_Tipo_Doc_Cod"] ?? string.Empty)),
                    Tipo_Doc_Desc = Convert.ToString(x["Tipo_Doc_Desc"] ?? string.Empty),
                    Nro_Documento = Convert.ToInt32(Convert.ToString(x["Cliente_Nro_Doc"] ?? string.Empty)),
                    Domicilio_Calle = Convert.ToString(x["Cliente_Dom_Calle"] ?? string.Empty),
                    Domicilio_Nro = Convert.ToInt32(Convert.ToString(x["Cliente_Dom_Nro"] ?? string.Empty)),
                    Domicilio_Piso = Convert.ToInt32(Convert.ToString(x["Cliente_Dom_Piso"] ?? string.Empty)),
                    Domicilio_Depto = Convert.ToString(x["Cliente_Dom_Depto"] ?? string.Empty),
                    Fecha_Nacimiento = Convert.ToDateTime(Convert.ToString(x["Cliente_Fecha_Nac"] ?? string.Empty)),
                    Mail = Convert.ToString(x["Cliente_Mail"] ?? string.Empty),
                    Pais = new Pais
                    {
                        Codigo = Convert.ToInt32(Convert.ToString(x["Pais_Codigo"] ?? string.Empty)),
                        Descipcion = Convert.ToString(x["Pais_Desc"] ?? string.Empty)
                    },
                    Baja = Convert.ToBoolean(x["Cliente_Baja"])
                }).ToList();

                return lstClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarCliente(Cliente cliente)
        {
            try
            {
                XDocument clienteXml = ObtenerClienteXml(cliente);
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("@XmlCliente", "Sp_GuardarCliente", clienteXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private XDocument ObtenerClienteXml(Cliente cliente)
        {
            XDocument clienteXml = new XDocument(
                new XElement("Cliente",
                new XElement("Codigo", cliente.Codigo),
                new XElement("Nombre", cliente.Nombre),
                new XElement("Apellido", cliente.Apellido),
                new XElement("Tipo_Doc_Codigo", cliente.Tipo_Doc_Codigo),
                new XElement("Nro_Documento", cliente.Nro_Documento),
                new XElement("Pais_Codigo", cliente.Pais.Codigo),
                new XElement("Domicilio_Calle", cliente.Domicilio_Calle),
                new XElement("Domicilio_Nro", cliente.Domicilio_Nro),
                new XElement("Domicilio_Piso", cliente.Domicilio_Piso),
                new XElement("Domicilio_Depto", cliente.Domicilio_Depto),
                new XElement("Fecha_Nacimiento", Convert.ToString(cliente.Fecha_Nacimiento)),
                new XElement("Mail", cliente.Mail),
                new XElement("Baja", cliente.Baja)));
            return clienteXml;
        }

        public void EliminarCliente(int codigoCliente)
        {
            try
            {
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("Sp_EliminarCliente", "@Codigo", codigoCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
