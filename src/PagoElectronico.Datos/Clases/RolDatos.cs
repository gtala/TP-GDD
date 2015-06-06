using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PagoElectronico.Datos.Helpers;
using PagoElectronico.Entidades.Clases;
using System.Xml.Linq;

namespace PagoElectronico.Datos.Clases
{
    public class RolDatos
    {
        private Conexion miConexionSql;

        /// <summary>
        /// Devuelve un listado de Roles
        /// </summary>
        /// <returns></returns>
        public List<Rol> ObtenerRoles(Dictionary<string, object> filtros)
        {
            try
            {
                DataTable dtRoles = new DataTable();
                miConexionSql = new Conexion();
                XDocument filtrosXml = UtilDatos.ArmarFiltrosXml(filtros);
                dtRoles = miConexionSql.EjecutarProcedure("Sp_ObtenerRoles", filtrosXml, "@filtrosXml");
                List<Rol> lstRoles = MapearDataTableLista(dtRoles);

                return lstRoles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarRol(Rol rol)
        {
            try
            {
                XDocument rolXml = ObtenerRolXml(rol);
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("@XmlRol", "Sp_GuardarRol", rolXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarRol(int codigoRol)
        {
            try
            {
                miConexionSql = new Conexion();
                miConexionSql.EjecutarProcedure("Sp_EliminarRol", "@Codigo", codigoRol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Rol> MapearDataTableLista(DataTable dtRoles)
        {
            List<Rol> lstRoles = new List<Rol>();

            try
            {
                lstRoles = (from x in dtRoles.AsEnumerable()
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

                    lstFuncionalidades = (from x in dtRoles.AsEnumerable()
                                          where Convert.ToInt32(Convert.ToString(x["Rol_Codigo"])) == r.Codigo
                                               && x["Func_Codigo"] != DBNull.Value
                                          select new Funcionalidad
                                          {
                                              Codigo = Convert.ToInt32(Convert.ToString(x["Func_Codigo"])),
                                              Nombre = Convert.ToString(x["Func_Desc"])
                                          }).ToList();

                    r.Funcionalidades = lstFuncionalidades;
                }
                return lstRoles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private XDocument ObtenerRolXml(Rol rol)
        {
            //Funcionalidades
            XElement xmlFuncionalidades = new XElement("Funcionalidades");
            XElement xmlFuncionalidad;
            foreach (Funcionalidad item in rol.Funcionalidades)
            {
                xmlFuncionalidad = new XElement("Funcionalidad",
                    new XElement("Codigo", item.Codigo));
                //new XElement("Nombre", item.Nombre));

                xmlFuncionalidades.Add(xmlFuncionalidad);
            }

            XDocument rolXml = new XDocument(
                new XElement("Rol",
                new XElement("Codigo", rol.Codigo),
                new XElement("Nombre", rol.Nombre),
                new XElement("Estado", rol.Estado),
                xmlFuncionalidades));
            return rolXml;
        }
    }
}
