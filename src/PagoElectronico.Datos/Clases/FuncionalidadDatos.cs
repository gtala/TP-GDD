using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PagoElectronico.Datos.Helpers;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.Datos.Clases
{
    public class FuncionalidadDatos
    {
        private Conexion miConexionSql;

        /// <summary>
        /// Devuelve un listado de Funcionalidades
        /// </summary>
        /// <returns></returns>
        public List<Funcionalidad> ObtenerFuncionalidades()
        {
            try
            {
                DataTable dtFuncionalidades = new DataTable();
                miConexionSql = new Conexion();
                dtFuncionalidades = miConexionSql.EjecutarProcedure("Sp_ObtenerFuncionalidades");

                //GDT: Realiza el mapeo de los datos que trae de la base de datos
                //     a una lista de objetos de tipo Funcionalidad.
                List<Funcionalidad> lstFuncionalidades = dtFuncionalidades.AsEnumerable().Select(x => new Funcionalidad
                {
                    Codigo = Convert.ToInt32(Convert.ToString(x["Func_Codigo"])),
                    Nombre = Convert.ToString(x["Func_Desc"] ?? string.Empty)
                }).ToList();

                return lstFuncionalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
