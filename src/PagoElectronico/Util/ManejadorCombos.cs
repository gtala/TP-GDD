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

        public static void CargarComoboTipoDocumento(ref ComboBox combo)
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
    }
}
