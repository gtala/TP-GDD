using System;
using System.Data;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Rol
{
    public partial class Rol_Edicion : Form
    {
        #region - Propiedades -
        private DataTable dtFunciones;
        private DataTable dtFuncionesAsignadas;
        #endregion

        #region - Métodos

        /// <summary>
        /// Constructor
        /// </summary>
        public Rol_Edicion()
        {
            InitializeComponent();
            CargarComboFunciones();
            CargarFuncionesAsiganadas();
        }

        private void CargarComboFunciones()
        {
            dtFunciones = new DataTable();
            dtFunciones.Columns.Add("IdFuncion");
            dtFunciones.Columns.Add("Nombre");

            dtFunciones.Rows.Add(new object[] { 1, "Administrador" });
            dtFunciones.Rows.Add(new object[] { 2, "Cliente" });

            cmbFunciones.DisplayMember = "Nombre";
            cmbFunciones.ValueMember = "IdFuncion";
            cmbFunciones.DataSource = dtFunciones;
        }

        private void CargarFuncionesAsiganadas()
        {
            dtFuncionesAsignadas = new DataTable();
            dtFuncionesAsignadas.Columns.Add("IdFuncion");
            dtFuncionesAsignadas.Columns.Add("Nombre");

            //Hardcode para probar
            dtFuncionesAsignadas.Rows.Add(new object[] { 1, "Administrador" });
            dgFunciones.DataSource = dtFuncionesAsignadas;
        }

        #endregion

        #region - Eventos

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Aca se debe guardar el formulario en la base de datos
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cmbFunciones.SelectedItem;
            dtFuncionesAsignadas.Rows.Add(item["IdFuncion"], item["Nombre"]);
        }

        #endregion


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
