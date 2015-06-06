using System.Collections.Generic;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Datos.Clases;

namespace PagoElectronico.Negocio.Clases
{
    public class RolNegocio
    {
        Datos.Clases.RolDatos miRolDatos;

        public List<Rol> ObtenerRoles(Dictionary<string, object> filtros)
        {
            try
            {
                miRolDatos = new RolDatos();
                return miRolDatos.ObtenerRoles(filtros);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarRol(Rol rol)
        {
            try
            {
                miRolDatos = new RolDatos();
                miRolDatos.GuardarRol(rol);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarRol(int codigoRol)
        {
            miRolDatos = new RolDatos();
            miRolDatos.EliminarRol(codigoRol);
        }
    }
}
