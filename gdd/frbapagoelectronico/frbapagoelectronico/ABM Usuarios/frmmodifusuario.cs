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
using System.Security.Cryptography;

namespace frbapagoelectronico.ABM_Usuarios
{
    public partial class frmmodifusuario : Form
    {
        string passglobal;
        public frmmodifusuario(Usuario usr)
        {
            InitializeComponent();
            txtusername.Text = usr.getusername();
            txtusername.Enabled = false;
            txtpass.Text = usr.getpass();
            txtpass.UseSystemPasswordChar = true;
            txtpass.PasswordChar = '*';
            dateTimePicker1.Value = usr.getfechacrea();
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker2.Enabled = false;
            txtpregsecre.Text = usr.getpreguntasecreta();
            txtrespsecre.Text = usr.getrespuestasecreta();
            SqlConnection unacon = new Conexiones().conectarse();
            SqlCommand cmd = new SqlCommand("gdd_maxi.sp_traerrolesactivos", unacon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRoles.DataSource = dt;
            dgvRoles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.Name = "seleccionado";
            dgvRoles.Columns.Add(check);
            
            if (usr.estado == 1) checkBox1.Checked = true;
            unacon.Close();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection unacon = new Conexiones().conectarse();
            SqlCommand cmd = new SqlCommand("delete from gdd_maxi.usuarioxrol where username = '" + txtusername.Text + "'",unacon);
            cmd.ExecuteNonQuery();
            //update gdd_maxi.Usuarios set pass = 'pass',preguntasecreta = 'preguntasecreta',respuestasecreta = 'rps' 
            //where username = 'admin'
            string passha;
            string respsha;
            int estado = 0;
            if (checkBox1.Checked) estado = 1;
            passglobal = txtpass.Text;
            txtpass.TextChanged += new EventHandler(txtpass_TextChanged);
            respsha = Encriptador(txtrespsecre.Text);
            SqlCommand cmd2 = new SqlCommand("update gdd_maxi.usuarios set pass = '" + passglobal + "',fechaultmod = '" + dateTimePicker2.Value.ToString() + "',preguntasecreta = '" + txtpregsecre.Text + "',respuestasecreta = '" + respsha + "',estado = '" + estado.ToString() + "' where username = '" + txtusername.Text + "'",unacon);
            cmd2.ExecuteNonQuery();
            foreach (DataGridViewRow r in dgvRoles.Rows)
            {
                DataGridViewCheckBoxCell chk = r.Cells["seleccionado"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(chk.Value) == true)
                {
                    SqlCommand cmd4 = new SqlCommand("gdd_maxi.sp_insertarolxusuario", unacon);

                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = txtusername.Text;
                    cmd4.Parameters.Add("@idrol", SqlDbType.Int).Value = r.Cells["idrol"].Value;
                    cmd4.ExecuteNonQuery();
                }
            }

            unacon.Close();

        }

        public static string Encriptador(string entrada)
        {
            var provider = new SHA256Managed();

            byte[] inputBytes = Encoding.UTF8.GetBytes(entrada);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder salida = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                salida.Append(hashedBytes[i].ToString("x2").ToLower());

            return salida.ToString();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            passglobal = Encriptador(txtpass.Text);
        }

    }
}
