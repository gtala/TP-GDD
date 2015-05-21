using System.Collections.Generic;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.Negocio.Clases
{
    public class ClienteNegocio
    {
        Datos.Clases.ClienteDatos miClienteDatos;

        public List<Cliente> ObtenerClientes()
        {
            try
            {
                miClienteDatos = new PagoElectronico.Datos.Clases.ClienteDatos();
                return miClienteDatos.ObtenerClientes();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
    }
}
