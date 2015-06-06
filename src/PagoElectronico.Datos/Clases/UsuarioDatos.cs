using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PagoElectronico.Datos.Helpers;
using PagoElectronico.Entidades.Clases;
using System.Xml.Linq;
using System.Data.SqlTypes;

namespace PagoElectronico.Datos.Clases
{
    public class UsuarioDatos
    {
        private Conexion miConexionSql;

        /// <summary>
        /// Devuelve un listado de Usuarioes
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerUsuarios(Dictionary<string, object> filtros)
        {
            try
            {
                DataTable dtUsuarios = new DataTable();
                miConexionSql = new Conexion();
                XDocument filtrosXml = UtilDatos.ArmarFiltrosXml(filtros);
                dtUsuarios = miConexionSql.EjecutarProcedure("Sp_ObtenerUsuarios", filtrosXml, "@filtrosXml");
                List<Usuario> lstUsuarios = MapearDataTableLista(dtUsuarios);

                return lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario ObtenerUsuarioPorUsername(string username)
        {
            try
            {
                Usuario miUsuario;
                DataTable dtUsuarios = new DataTable();
                miConexionSql = new Conexion();
                XDocument parametroXml = new XDocument(new XElement("Username", username));
                dtUsuarios = miConexionSql.EjecutarProcedure("Sp_ObtenerUsuarioPorUsername", parametroXml, "@UsernameXML");
                List<Usuario> lstUsuarios = MapearDataTableLista(dtUsuarios);

                miUsuario = lstUsuarios.Count > 0 ? lstUsuarios.First() : null;
                return miUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Usuario> MapearDataTableLista(DataTable dtUsuarios)
        {
            try
            {

                List<Usuario> lstUsuarios = new List<Usuario>();

                lstUsuarios = (from x in dtUsuarios.AsEnumerable()
                               select new Usuario
                               {
                                   Username = Convert.ToString(x["Usuario_Username"] ?? string.Empty),
                                   Password = Convert.ToString(x["Usuario_Password"] ?? string.Empty),
                                   PreguntaSecreta = Convert.ToString(x["Usuario_Pregunta_Secreta"] ?? string.Empty),
                                   RespuestaSecreta = Convert.ToString(x["Usuario_Respuesta_Secreta"] ?? string.Empty),
                                   FechaCreacion = Convert.ToDateTime(Convert.ToString(x["Usuario_Fecha_Creacion"] ?? string.Empty)),
                                   FechaUltimaModificacion = (x["Usuario_Fecha_Ultima_Modificacion"] == DBNull.Value || Convert.ToDateTime(x["Usuario_Fecha_Ultima_Modificacion"]) == SqlDateTime.MinValue.Value) ? DateTime.MinValue : Convert.ToDateTime(Convert.ToString(x["Usuario_Fecha_Ultima_Modificacion"])),
                                   CantidadIntentosFallidos = Convert.ToInt32(Convert.ToString(x["Usuario_Intentos_Fallidos"])),
                                   Inhabilitado = Convert.ToBoolean(x["Usuario_Inhabilitado"])
                               }).ToList();

                lstUsuarios = lstUsuarios.GroupBy(a => a.Username).Select(g => g.First()).ToList();

                //Cargo los Roles de cada Usuario.
                foreach (Usuario u in lstUsuarios)
                {
                    List<Rol> lstRoles = new List<Rol>();

                    lstRoles = (from x in dtUsuarios.AsEnumerable()
                                where Convert.ToString(x["Usuario_Username"]).ToUpper().Trim() == u.Username.ToUpper().Trim()
                                               && x["Rol_Codigo"] != DBNull.Value
                                select new Rol
                                {
                                    Codigo = Convert.ToInt32(Convert.ToString(x["Rol_Codigo"])),
                                    Nombre = Convert.ToString(x["Rol_Nombre"]),
                                    Estado = Convert.ToBoolean(x["Rol_Estado"])
                                }).ToList();

                    lstRoles = lstRoles.GroupBy(a => a.Codigo).Select(g => g.First()).ToList();

                    //Cargo las funcionalidades de cada Rol
                    foreach (Rol r in lstRoles)
                    {
                        List<Funcionalidad> lstFuncionalidades = new List<Funcionalidad>();

                        lstFuncionalidades = (from x in dtUsuarios.AsEnumerable()
                                              where (x["Rol_Codigo"] != DBNull.Value && Convert.ToInt32(Convert.ToString(x["Rol_Codigo"])) == r.Codigo
                                                   && x["Func_Codigo"] != DBNull.Value)
                                              select new Funcionalidad
                                              {
                                                  Codigo = Convert.ToInt32(Convert.ToString(x["Func_Codigo"])),
                                                  Nombre = Convert.ToString(x["Func_Desc"])
                                              }).ToList();

                        r.Funcionalidades = lstFuncionalidades;
                    }

                    u.Roles = lstRoles;
                }

                return lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarUsuario(Usuario usuario)
        {
            try
            {
                XDocument usuarioXml = ObtenerUsuarioXml(usuario);
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("@XmlUsuario", "Sp_GuardarUsuario", usuarioXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private XDocument ObtenerUsuarioXml(Usuario usuario)
        {
            bool esAlta = usuario.FechaCreacion == DateTime.MinValue;
            if (esAlta)
            {
                usuario.FechaCreacion = DateTime.Now;
                usuario.FechaUltimaModificacion = SqlDateTime.MinValue.Value;
            }

            //Roles
            XElement xmlRoles = new XElement("Roles");
            XElement xmlRol;
            foreach (Rol item in usuario.Roles)
            {
                xmlRol = new XElement("Rol",
                    new XElement("Codigo", item.Codigo));
                xmlRoles.Add(xmlRol);
            }

            XDocument usuarioXml = new XDocument(
                new XElement("Usuario",
                new XElement("Username", usuario.Username),
                new XElement("Password", usuario.Password),
                //new XElement("Rol", usuario.Rol.Id),
                new XElement("FechaCreacion", Convert.ToString(usuario.FechaCreacion)),
                new XElement("FechaUltimaModificacion", Convert.ToString(usuario.FechaUltimaModificacion)),
                new XElement("PreguntaSecreta", usuario.PreguntaSecreta),
                new XElement("RespuestaSecreta", usuario.RespuestaSecreta),
                new XElement("CantidadIntentosFallidos", usuario.CantidadIntentosFallidos),
                new XElement("Inhabilitado", usuario.Inhabilitado),
                new XElement("EsAlta", esAlta),
                xmlRoles));
            return usuarioXml;
        }

        public void EliminarUsuario(string username)
        {
            try
            {
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("Sp_EliminarUsuario", "@Username", username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
