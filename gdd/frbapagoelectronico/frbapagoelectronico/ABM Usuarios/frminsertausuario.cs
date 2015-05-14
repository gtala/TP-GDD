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
using System.IO;
namespace frbapagoelectronico.ABM_Usuarios
{
    public partial class frminsertausuario : Form
    {
        
        public frminsertausuario()
        {
            InitializeComponent();
           
            SqlConnection unacon = new Conexiones().conectarse();
            SqlCommand cmd = new SqlCommand("select * from gdd_maxi.V_nombrederoles", unacon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRoles.DataSource = dt;
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "seleccionado";
            dgvRoles.Columns.Add(chk);
            unacon.Close();
        }

        private void btnguardarusuario_Click(object sender, EventArgs e)
        {
            List<string> listadeusuarios;
            listadeusuarios = new Usuariosql().obtenerusuarios();
                 
            
            if (listadeusuarios.Contains(txtusername.Text))
            {
                MessageBox.Show("el usuario ingresado ya existe");
            }
            else 
            {
                string username = txtusername.Text;
                string pass = Encriptador(txtpass.Text);
                DateTime fecha1 = dateTimePicker1.Value;
                DateTime fecha2 = dateTimePicker2.Value;
                string pregsecre = txtpregsecre.Text;
                string respsecre = Encriptador(txtrespsecre.Text);

                SqlConnection unacon = new Conexiones().conectarse();
                SqlCommand cmd = new SqlCommand("gdd_maxi.sp_insertausuario", unacon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
                cmd.Parameters.Add("@fechacrea", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@fechaultmod", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                cmd.Parameters.Add("@preguntasecreta", SqlDbType.VarChar).Value = pregsecre;
                cmd.Parameters.Add("@respuestasecreta", SqlDbType.VarChar).Value = respsecre;
                cmd.Parameters.Add("@estado", SqlDbType.Int).Value = checkBox1.Checked;
                cmd.ExecuteNonQuery();
                
                
                foreach (DataGridViewRow r in dgvRoles.Rows)
                {
                    DataGridViewCheckBoxCell chk = r.Cells["seleccionado"] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        SqlCommand cmd2 = new SqlCommand("gdd_maxi.sp_insertarolxusuario", unacon);

                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = txtusername.Text;
                        cmd2.Parameters.Add("@idrol", SqlDbType.Int).Value = r.Cells["idrol"].Value;
                        cmd2.ExecuteNonQuery();
                    }
                }
                

                unacon.Close();


            }
            
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

    }
}
