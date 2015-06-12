using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ControlesCustomizados
{
    public partial class ucGrilla : UserControl
    {

        public DataGridView Grilla
        {
            get
            {
                return dgListado;
            }
            set
            {
                dgListado = value;
            }
        }

        public ucGrilla()
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
    }
}
