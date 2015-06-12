using System.Collections.Generic;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Datos.Clases;

namespace PagoElectronico.Negocio.Clases
{
    public class CuentaNegocio
    {
        Datos.Clases.CuentaDatos miCuentaDatos;

        public  List<Cuenta> ObtenerCuentasPorCliente(int cliente)
        {
            try
            {
                miCuentaDatos = new CuentaDatos();
                return miCuentaDatos.ObtenerCuentasPorCliente(cliente);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarCuenta(Cuenta cuenta, bool esAlta)
        {
            try
            {
                miCuentaDatos = new CuentaDatos();
                miCuentaDatos.GuardarCuenta(cuenta, esAlta);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarCuenta(int codigoCuenta)
        {
            //miCuentaDatos = new CuentaDatos();
            //miCuentaDatos.GuardarCuenta(
        }
    }
}
