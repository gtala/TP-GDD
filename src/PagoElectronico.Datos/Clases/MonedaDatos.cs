using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Datos.Helpers;
using System.Data;

namespace PagoElectronico.Datos.Clases
{
    public class MonedaDatos
    {

        private Conexion miConexionSql;

        /// <summary>
        /// Devuelve un listado de monedas
        /// </summary>
        /// <returns></returns>
        public List<Moneda> ObtenerMonedas()
        {
            try
            {
                DataTable dtMonedas= new DataTable();
                miConexionSql = new Conexion();
                dtMonedas= miConexionSql.EjecutarProcedure("Sp_ObtenerMonedas");

                List<Moneda> lstMonedas = dtMonedas.AsEnumerable().Select(x => new Moneda
                {
                    Codigo = Convert.ToInt32(Convert.ToString(x["Moneda_Codigo"])),
                    Descipcion = Convert.ToString(x["Moneda_Desc"] ?? string.Empty)
                }).ToList();

                return lstMonedas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
