using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Negocio.Helpers;
using System.Data;

namespace PagoElectronico.Util
{
    public class ManejadorCombos
    {
        const string SELECCIONE = "- Seleccione -";
        public static void CargarComboPais(ref ComboBox combo)
        {
            try
            {
                PaisNegocio miPaisNegocio = new PaisNegocio();
                List<Pais> lstPaises = new List<Pais>();
                lstPaises = miPaisNegocio.ObtenerPaises();
                lstPaises.Insert(0, new Pais() { Codigo = -1, Descipcion = SELECCIONE });
                combo.DataSource = lstPaises;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Descipcion";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void CargarComboTipoDocumento(ref ComboBox combo)
        {
            try
            {
                UtilNegocio miUtil = new UtilNegocio();
                DataTable dataTable = miUtil.ObtenerTipoDocumento();
                DataRow row = dataTable.NewRow();
                row["Tipo_Doc_Cod"] = -1;
                row["Tipo_Doc_Desc"] = SELECCIONE;
                dataTable.Rows.InsertAt(row, 0);
                combo.DisplayMember = "Tipo_Doc_Desc";
                combo.ValueMember = "Tipo_Doc_Cod";
                combo.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CargarComboTipoCuenta(ref ComboBox combo)
        {
            try
            {
                UtilNegocio util = new UtilNegocio();

                List<TipoCuenta> lstTiposCuenta= util.ObtenerTiposCuenta();
                lstTiposCuenta.Insert(0, new TipoCuenta() { Codigo = -1, Descipcion = SELECCIONE });
                combo.DataSource = lstTiposCuenta;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Descipcion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CargarComboMoneda(ref ComboBox combo)
        {
            try
            {
                UtilNegocio util = new UtilNegocio();

                List<Moneda> lstMonedas = util.ObtenerMonedas();
                lstMonedas.Insert(0, new Moneda() { Codigo = -1, Descipcion = SELECCIONE });
                combo.DataSource = lstMonedas;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Descipcion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CargarComboRolesUsuario(ref ComboBox combo, List<Rol> roles)
        {
            try
            {
                List<Rol> lstRoles = new List<Rol>();
                lstRoles = roles;
                lstRoles.Insert(0, new Rol() { Codigo = -1, Nombre = SELECCIONE });
                combo.DataSource = lstRoles;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Nombre";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void CargarCheckListFuncionalidades(ref CheckedListBox chk)
        {
            FuncionalidadNegocio miFuncionalidadNegocio = new FuncionalidadNegocio();
            List<Funcionalidad> lstFuncionalidades = new List<Funcionalidad>();
            lstFuncionalidades = miFuncionalidadNegocio.ObtenerFuncionalidades();

            ((ListBox)chk).DataSource = lstFuncionalidades;
            ((ListBox)chk).DisplayMember = "Nombre";
            ((ListBox)chk).ValueMember = "Codigo";
        }

        public static void CargarListBoxRoles(ref ListBox lst, List<Rol> rolesDataSource)
        {
            lst.DataSource = rolesDataSource;
            lst.DisplayMember = "Nombre";
            lst.ValueMember = "Codigo";
        }
    }
}
