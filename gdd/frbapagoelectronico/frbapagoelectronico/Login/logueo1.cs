using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using clases;
using control;
namespace frbapagoelectronico.Login
{
    public partial class logueo1 : Form
    {
        public int intentos = 0;

        usuarioactual usract = new usuarioactual();
        public logueo1()
        {
            InitializeComponent();
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            Usuario newuser = Usuariosql.obtenerusuario(txtUsuario.Text);

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("escriba un usuario por favor");
                return;
            }
            
            
            if (txtContrasenia.Text == "")
            {
                MessageBox.Show("escriba una contraseña por favor");
                return;
            }

           

            if (newuser != null)
            {

                if (newuser.estado == 0)
                {
                    MessageBox.Show("usuario inhabilitado");
                }
                else
                {

                    if (newuser.getpass() == Usuario.encriptar(txtContrasenia.Text))
                    {
                        //auditoria correcto
                        SqlConnection unacon = new Conexiones().conectarse();
                        SqlCommand cmd = new SqlCommand("gdd_maxi.sp_insertalogin",unacon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@correcto", SqlDbType.Char).Value = "si";
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUsuario.Text;
                        cmd.ExecuteNonQuery();
                        unacon.Close();
                        MessageBox.Show("usuario validado ok");
                        this.Hide();
                        logueo2 formlogueo2 = new logueo2(this, newuser);
                        formlogueo2.Show();
                        
                    }
                    else 
                    {
                        intentos++;
                        MessageBox.Show("contraseña incorrecta");
                    
                    }

                    if (intentos == 3) 
                    {
                    //auditoria fallo
                        SqlConnection unacon = new Conexiones().conectarse();
                        SqlCommand cmd = new SqlCommand("gdd_maxi.sp_insertalogin", unacon);
                        SqlCommand cmd2 = new SqlCommand("update gdd_maxi.usuarios set estado = 0 where username = '" + txtUsuario.Text + "'", unacon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@correcto", SqlDbType.Char).Value = "no";
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUsuario.Text;
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        
                        
                        unacon.Close();
                        
                        MessageBox.Show("usuario inhabilitado");
                        intentos = 0;
                    
                    }
                }
            }
            else 
            {
                MessageBox.Show("usuario no existente");
            
            }
        }

        private void logueo1_Load(object sender, EventArgs e)
        {
            
            

        }
    }
}
