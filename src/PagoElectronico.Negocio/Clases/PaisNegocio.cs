using System.Collections.Generic;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.Negocio.Clases
{
    public class PaisNegocio
    {
        Datos.Clases.PaisDatos miPaisDatos;

        public List<Pais> ObtenerPaises()
        {
            try
            {
                miPaisDatos = new PagoElectronico.Datos.Clases.PaisDatos();
                return miPaisDatos.ObtenerPaises();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
    }
}
