using System.Collections.Generic;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.Negocio.Clases
{
    public class FuncionalidadNegocio
    {
        Datos.Clases.FuncionalidadDatos miFuncionalidadDatos;

        public List<Funcionalidad> ObtenerFuncionalidades()
        {
            try
            {
                miFuncionalidadDatos = new PagoElectronico.Datos.Clases.FuncionalidadDatos();
                return miFuncionalidadDatos.ObtenerFuncionalidades();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
    }
}
