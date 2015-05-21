using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PagoElectronico.Datos.Helpers;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.Datos.Clases
{
    public class PaisDatos
    {
        private Conexion miConexionSql;

        /// <summary>
        /// Devuelve un listado de paises
        /// </summary>
        /// <returns></returns>
        public List<Pais> ObtenerPaises()
        {
            try
            {
                DataTable dtPaises = new DataTable();
                miConexionSql = new Conexion();
                dtPaises = miConexionSql.EjecutarProcedure("Sp_ObtenerPaises");

                //GDT: Realiza el mapeo de los datos que trae de la base de datos
                //     a una lista de objetos de tipo Pais.
                List<Pais> lstPaises = dtPaises.AsEnumerable().Select(x => new Pais
                {
                    Pais_Codigo = Convert.ToInt32(Convert.ToString(x["Pais_Codigo"])),
                    Pais_Descipcion = Convert.ToString(x["Pais_Desc"] ?? string.Empty)
                }).ToList();

                return lstPaises;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
