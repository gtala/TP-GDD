using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.FormulariosBase
{
    public partial class FormularioListadoBase : Form
    {
        public FormularioListadoBase()
        {
            InitializeComponent();
        }

        private void dgListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //GDT 20150520: Al seleccionar cualquier celda, se selecciona automaticamente toda la fila.
            if (e.RowIndex > -1)
            {
                dgListado.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgListado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            bool tieneFilas = (dgListado.Rows.Count > 0);
            btnEliminar.Enabled = tieneFilas;
            btnModificar.Enabled = tieneFilas;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
