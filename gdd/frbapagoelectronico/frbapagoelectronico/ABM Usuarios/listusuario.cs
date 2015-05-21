using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using clases;
namespace frbapagoelectronico.ABM_Usuarios
{
    public partial class listusuario : Form
    {
        public listusuario()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SqlConnection unacon = new Conexiones().conectarse();
            if (textBox1.Text == "") 
            {
                SqlCommand cmd = new SqlCommand("select username,pass,fechacrea,fechaultmod,preguntasecreta,respuestasecreta,estado from gdd_maxi.usuarios where username like " + "'%" + textBox2.Text + "%'", unacon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvusuarios.DataSource = dt; 
            }
            if (textBox2.Text == "")
            {
                SqlCommand cmd = new SqlCommand("select username,pass,fechacrea,fechaultmod,preguntasecreta,respuestasecreta,estado from gdd_maxi.usuarios where username = " + "'" + textBox1.Text + "'", unacon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvusuarios.DataSource = dt;
            }
            
           
            unacon.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string X1 = "";
            string X2 = "";
            DateTime X3;
            DateTime X4;
            string X5 = "";
            string X6 = "";
            int X7 = 0;            
            int Row = 0;
             
            Row = dgvusuarios.CurrentRow.Index;
            X1 = (string)dgvusuarios[0,Row].Value;
            X2 = (string)dgvusuarios[1,Row].Value;
            X3 = (DateTime)dgvusuarios[2,Row].Value;
            X4 = (DateTime)dgvusuarios[3,Row].Value;
            X5 = (string)dgvusuarios[4,Row].Value;
            X6 = (string)dgvusuarios[5,Row].Value;
            X7 = (int)dgvusuarios[6, Row].Value;

            Usuario usr = new Usuario();
            usr.setusername(X1);
            usr.setpass(X2);
            usr.setfechacrea(X3);
            usr.setfechaultmod(X4);
            usr.setpreguntasecreta(X5);
            usr.setrespuestasecreta(X6);
            usr.estado = X7;
            frmmodifusuario mod = new frmmodifusuario(usr);
            mod.Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            SqlConnection unacon = new Conexiones().conectarse();
            
            string X1 = "";
            int Row = 0;
            Row = dgvusuarios.CurrentRow.Index;
            X1 = (string)dgvusuarios[0, Row].Value;

            SqlCommand cmd = new SqlCommand("update gdd_maxi.usuarios set estado = 0 where username = '" + X1 + "'",unacon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("usuario eliminado correctamente");
            unacon.Close();

        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            frminsertausuario inserta = new frminsertausuario();
            inserta.Show();
        }
    }
}
