using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PagoElectronico.Datos.Helpers;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.Datos.Clases
{
    public class ClienteDatos
    {
        private Conexion miConexionSql;

        /// <summary>
        /// Devuelve un listado de Clientees
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ObtenerClientes()
        {
            try
            {
                DataTable dtClientes = new DataTable();
                miConexionSql = new Conexion();
                dtClientes = miConexionSql.EjecutarProcedure("Sp_ObtenerClientes");

                //GDT: Realiza el mapeo de los datos que trae de la base de datos
                //     a una lista de objetos de tipo Cliente.
                List<Cliente> lstClientes = dtClientes.AsEnumerable().Select(x => new Cliente()
                {
                    Codigo = Convert.ToInt32(Convert.ToString(x["Cliente_Codigo"])),
                    Nombre = Convert.ToString(x["Cliente_Nombre"] ?? string.Empty),
                    Apellido = Convert.ToString(x["Cliente_Apellido"] ?? string.Empty),
                    Tipo_Doc_Codigo = Convert.ToInt32(Convert.ToString(x["Cliente_Tipo_Doc_Cod"] ?? string.Empty)),
                    Tipo_Doc_Desc = Convert.ToString(x["Cliente_Tipo_Doc_Desc"] ?? string.Empty),
                    Nro_Documento = Convert.ToInt32(Convert.ToString(x["Cliente_Nro_Doc"] ?? string.Empty)),
                    Domicilio_Calle = Convert.ToString(x["Cliente_Dom_Calle"] ?? string.Empty),
                    Domicilio_Nro = Convert.ToInt32(Convert.ToString(x["Cliente_Dom_Nro"] ?? string.Empty)),
                    Domicilio_Piso = Convert.ToInt32(Convert.ToString(x["Cliente_Dom_Piso"] ?? string.Empty)),
                    Domicilio_Depto = Convert.ToString(x["Cliente_Dom_Depto"] ?? string.Empty),
                    Fecha_Nacimiento = Convert.ToDateTime(Convert.ToString(x["Cliente_Fecha_Nac"] ?? string.Empty)),
                    Mail = Convert.ToString(x["Cliente_Mail"] ?? string.Empty),
                    Pais = new Pais
                    {
                        Pais_Codigo = Convert.ToInt32(Convert.ToString(x["Pais_Codigo"] ?? string.Empty)),
                        Pais_Descipcion = Convert.ToString(x["Pais_Desc"] ?? string.Empty)
                    }
                }).ToList();
                return lstClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public int[] GuardarCliente()
        //{
        //    try
        //    {
        //        DataTable dtClientes = new DataTable();
        //        miConexionSql = new Conexion();

        //        dtClientes = miConexionSql.EjecutarProcedure("Sp_GuardarDatosCliente");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
