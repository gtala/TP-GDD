using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ABM_Rol.Rol_Listado formularioRol = new ABM_Rol.Rol_Listado();
            //formularioRol.Dock = DockStyle.Fill;
            //formularioRol.AllowDrop = false;
            //formularioRol.TopLevel = false;
            //formularioRol.AutoScroll = true;
            //panel1.Controls.Add(formularioRol);
            //formularioRol.Show();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    List<Pais> lstPaises;
        //    PagoElectronico.Negocio.Clases.PaisNegocio miPaisNegocio = new PagoElectronico.Negocio.Clases.PaisNegocio();
        //    lstPaises = miPaisNegocio.ObtenerPaises();

        //}
    }
}
