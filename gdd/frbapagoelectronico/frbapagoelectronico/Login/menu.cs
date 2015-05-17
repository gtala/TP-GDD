using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases;
using control;
using System.Windows;
using frbapagoelectronico.ABM_Rol;
using frbapagoelectronico.ABM_Usuarios;
namespace frbapagoelectronico.Login
{
    public partial class menu : Form
    {


        public menu(Usuario usr)
        {
            InitializeComponent();
            DataTable dt = new DataTable("funcionalidades");
            new funcionalidadsql().obtenerFuncionalidades(usr).Fill(dt);
            MenuStrip ms = new MenuStrip();
            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem item1 = new ToolStripMenuItem();
                item1.Text = dr["nombre"].ToString();
                item1.Tag = dr["idfuncionalidad"].ToString();
                item1.Name = dr["nombre"].ToString().Replace(" ", String.Empty);
                if (item1.Name == "ABMderoles")
                {
                    ToolStripMenuItem roleslistado = new ToolStripMenuItem();
                    roleslistado.Text = "listado";
                    ToolStripMenuItem rolesalta = new ToolStripMenuItem();
                    rolesalta.Text = "alta";
                    ToolStripMenuItem rolesbaja = new ToolStripMenuItem();
                    rolesbaja.Text = "baja";
                    roleslistado.Click += new EventHandler(roleslistado_Click);
                    rolesalta.Click += new EventHandler(rolesalta_Click);
                    rolesbaja.Click += new EventHandler(rolesbaja_Click);

                    item1.DropDownItems.Add(roleslistado);
                    item1.DropDownItems.Add(rolesalta);
                    item1.DropDownItems.Add(rolesbaja);
                }
                if (item1.Name == "ABMdeusuarios")
                {
                
                    
                    ToolStripMenuItem usuarioslistado = new ToolStripMenuItem();
                    usuarioslistado.Text = "listado";
                    ToolStripMenuItem usuariosalta = new ToolStripMenuItem();
                    usuariosalta.Text = "alta";
                    ToolStripMenuItem usuariosbaja = new ToolStripMenuItem();
                    usuariosbaja.Text = "baja";
                    usuarioslistado.Click += new EventHandler(usuarioslistado_Click);
                    usuariosalta.Click += new EventHandler(usuariosalta_Click);
                    usuariosbaja.Click += new EventHandler(usuariosbaja_Click);

                    item1.DropDownItems.Add(usuarioslistado);
                    item1.DropDownItems.Add(usuariosalta);
                    item1.DropDownItems.Add(usuariosbaja);
                }
                if (item1.Name == "ABMdeclientes")
                {
                    ToolStripMenuItem clienteslistado = new ToolStripMenuItem();
                    clienteslistado.Text = "listado";
                    ToolStripMenuItem clientesalta = new ToolStripMenuItem();
                    clientesalta.Text = "alta";
                    ToolStripMenuItem clientesbaja = new ToolStripMenuItem();
                    clientesbaja.Text = "baja";
                    clienteslistado.Click += new EventHandler(clienteslistado_Click);
                    clientesalta.Click += new EventHandler(clientesalta_Click);
                    clientesbaja.Click += new EventHandler(clientesbaja_Click);

                    item1.DropDownItems.Add(clienteslistado);
                    item1.DropDownItems.Add(clientesalta);
                    item1.DropDownItems.Add(clientesbaja);   
                }

                ToolStripMenuItemabms.DropDownItems.Add(item1);
            }
        }

        //roles
        private void roleslistado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("roles listado click");
            listadorol lr = new listadorol();
            lr.Show();
        }
        private void rolesalta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("roles alta click");
            frminsertrol frminsert = new frminsertrol();
            frminsert.Show();
        }
        private void rolesbaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("roles baja click");
        }
        //usuarios
        private void usuarioslistado_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("usuarios  listado click");
            listusuario ls = new listusuario();
            ls.Show();
        }
        private void usuariosalta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("usuarios alta click");
            frminsertausuario iu = new frminsertausuario();
            iu.Show();
            
        }
        private void usuariosbaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("usuarios baja click");
        }
        //clientes
        private void clienteslistado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clientes  listado click");
        }
        private void clientesalta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clientes alta click");
        }
        private void clientesbaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clientes baja click");
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            logueo1 l1 = new logueo1();
            l1.Show();
        }

        
        

        
        

        





    }
}
