using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using clases;

namespace frbapagoelectronico.ABM_Rol
{
    public partial class listadorol : Form
    {
        public listadorol()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtrolexacto.Text == "") 
            {
                //buscar por like
                SqlConnection unacon = new Conexiones().conectarse();
                SqlCommand cmd = new SqlCommand("select idRol,nombre,estado from gdd_maxi.Roles where nombre like '%" + txtrollike.Text + "%'", unacon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvroles.DataSource = dt;
                unacon.Close();
            }
            if (txtrollike.Text == "")
            {
                //buscar por exacto
                SqlConnection unacon = new Conexiones().conectarse();
                SqlCommand cmd = new SqlCommand("select idRol,nombre,estado from gdd_maxi.Roles where nombre = '" + txtrolexacto.Text + "'", unacon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvroles.DataSource = dt;
                unacon.Close();
            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Rol unrol = new Rol();
            int X1 = 0;
            string X2 = "";
            int X3 = 0;
            int Row = 0;
             
            Row = dgvroles.CurrentRow.Index;
            X1 = (int)dgvroles[0,Row].Value;
            X2 = (string)dgvroles[1,Row].Value;
            X3 = (int)dgvroles[2,Row].Value;

            unrol.setidrol(X1);
            unrol.setnombre(X2);
            unrol.setestado(X3);
            frmmodificarol mr = new frmmodificarol(unrol);
            mr.Show();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int X1 = 0;
            int Row = 0;

            Row = dgvroles.CurrentRow.Index;
            X1 = (int)dgvroles[0, Row].Value;
            SqlConnection unacon = new Conexiones().conectarse();
            SqlCommand cmd = new SqlCommand("delete from gdd_maxi.Roles where idrol = " + X1, unacon);
            SqlCommand cmd2 = new SqlCommand("delete from gdd_maxi.Rolxfuncionalidad where idrol = " + X1, unacon);
            SqlCommand cmd3 = new SqlCommand("delete from gdd_maxi.usuarioxrol where idrol = " + X1, unacon);

            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            MessageBox.Show("rol eliminado satisfactoriamente");
            /*
            SqlCommand cmd3 = new SqlCommand("select idRol,nombre,estado from gdd_maxi.Roles",unacon);
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvroles.DataSource = dt;
            */
            dgvroles.DataSource = null;
            unacon.Close();

        }

        
    }
}
