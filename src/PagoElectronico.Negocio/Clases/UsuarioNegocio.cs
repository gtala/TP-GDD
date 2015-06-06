using System.Collections.Generic;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Datos.Clases;

namespace PagoElectronico.Negocio.Clases
{
    public class UsuarioNegocio
    {
        Datos.Clases.UsuarioDatos miUsuarioDatos;

        public List<Usuario> ObtenerUsuarios(Dictionary<string, object> filtros)
        {
            try
            {
                miUsuarioDatos = new UsuarioDatos();
                return miUsuarioDatos.ObtenerUsuarios(filtros);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public Usuario ObtenerUsuarioPorUsername(string username)
        {
            try
            {
                miUsuarioDatos = new UsuarioDatos();
                return miUsuarioDatos.ObtenerUsuarioPorUsername(username);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarUsuario(Usuario usuario)
        {
            try
            {
                miUsuarioDatos = new UsuarioDatos();
                miUsuarioDatos.GuardarUsuario(usuario);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarUsuario(string codigoUsuario)
        {
            miUsuarioDatos = new UsuarioDatos();
            miUsuarioDatos.EliminarUsuario(codigoUsuario);
        }
    }
}
