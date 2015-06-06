using System.Collections.Generic;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Datos.Clases;

namespace PagoElectronico.Negocio.Clases
{
    public class CuentaNegocio
    {
        Datos.Clases.CuentaDatos miCuentaDatos;

        public List<Cuenta> ObtenerCuentas(Dictionary<string, object> filtros)
        {
            try
            {
                miCuentaDatos = new CuentaDatos();
                return miCuentaDatos.ObtenerCuentas(filtros);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarCuenta(Cuenta cuenta)
        {
            try
            {
                miCuentaDatos = new CuentaDatos();
                miCuentaDatos.GuardarCuenta(cuenta);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarCuenta(int codigoCuenta)
        {
            miCuentaDatos = new CuentaDatos();
            miCuentaDatos.EliminarCuenta(codigoCuenta);
        }
    }
}
