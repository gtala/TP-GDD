using System.Collections.Generic;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Datos.Clases;

namespace PagoElectronico.Negocio.Clases
{
    public class ClienteNegocio
    {
        Datos.Clases.ClienteDatos miClienteDatos;

        public List<Cliente> ObtenerClientes(Dictionary<string, object> filtros)
        {
            try
            {
                miClienteDatos = new ClienteDatos();
                return miClienteDatos.ObtenerClientes(filtros);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarCliente(Cliente cliente)
        {
            try
            {
                miClienteDatos = new ClienteDatos();
                miClienteDatos.GuardarCliente(cliente);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarCliente(int codigoCliente)
        {
            miClienteDatos = new ClienteDatos();
            miClienteDatos.EliminarCliente(codigoCliente);
        }
    }
}
