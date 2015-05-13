using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Rol.Rol_Edicion formularioRol = new ABM_Rol.Rol_Edicion();

            formularioRol.TopLevel = false;
            formularioRol.AutoScroll = true;
            panel1.Controls.Add(formularioRol);
            formularioRol.Show();


        }
    }
}
