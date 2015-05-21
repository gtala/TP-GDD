using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases;
using System.Data.SqlClient;
using control;

namespace frbapagoelectronico.Login
{
    public partial class logueo2 : Form
    {
        logueo1 formanterior;
        Usuario unusuario;
        public logueo2(logueo1 anterior,Usuario newuser)
        {
            InitializeComponent();
            this.formanterior = anterior;
            DataTable dt = new DataTable("Roles");
            new Rolsql().obtenerRoles(newuser).Fill(dt);
            cbRoles.DataSource = dt;
            cbRoles.ValueMember = "idrol";
            cbRoles.DisplayMember = "nombre";
            unusuario = newuser;
        }

        

        private void btncontinuar_Click(object sender, EventArgs e)
        {

            if (cbRoles.DisplayMember == "" || cbRoles.SelectedValue==null)
            {
                MessageBox.Show("elija un rol por favor");
            }
            else
            {
                unusuario.setrol(int.Parse(cbRoles.SelectedValue.ToString()));
                this.Hide();
                menu formmenu = new menu(unusuario);
                formmenu.Show();
            }

        }

        private void logueo2_Load(object sender, EventArgs e)
        {

        }
    }
}
