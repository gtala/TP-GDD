using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Util;

namespace PagoElectronico.Login
{
    public partial class Login : Form
    {
        #region - Propiedades -

        Usuario usuarioLogueado;

        #endregion

        #region - Métodos -

        public Login()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            this.AutoValidate = AutoValidate.Disable;
            ManejadorValidaciones validador = new ManejadorValidaciones(errorProvider);
            validador.CrearValidacionesTextBox(ref txtUsername, MensajesInfo.infoCampoRequerido.Replace("|@|", "Usuario"));
            validador.CrearValidacionesTextBox(ref txtPassword, MensajesInfo.infoCampoRequerido.Replace("|@|", "Password"));
            txtUsername.MaxLength = 255;
            txtPassword.MaxLength = 255;
        }

        private void ObtenerUsuarioPorUsername()
        {
            try
            {
                UsuarioNegocio miUsuarioNegocio = new UsuarioNegocio();
                usuarioLogueado = miUsuarioNegocio.ObtenerUsuarioPorUsername(txtUsername.Text);

                if (usuarioLogueado == null)
                {
                    MostrarMensajeErrorLogin();
                }
                else
                {
                    ValidarDatosUsuario(usuarioLogueado);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al intentar realizar el logueo. Por favor, intente nuevamente.", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarMensajeErrorLogin()
        {
            MessageBox.Show("Usuario y/o password incorrectos. Por favor intente de nuevo.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ValidarDatosUsuario(Usuario usuarioLogueado)
        {
            if (!usuarioLogueado.Inhabilitado)
            {
                if (usuarioLogueado.Password.ToUpper().Trim() == txtPassword.Text.ToUpper().Trim())
                {
                    ReiniciarIntentosFallidos(usuarioLogueado);
                    if (usuarioLogueado.Roles != null && usuarioLogueado.Roles.Count > 1)
                    {
                        PrepararSeleccionRoles();
                    }
                    else
                    {
                        MostrarMenu(usuarioLogueado.Roles[0]);
                    }
                }
                else
                {
                    RegistrarIntentoFallido(usuarioLogueado);
                    if (usuarioLogueado.Inhabilitado)
                    {
                        MessageBox.Show("El usuario [" + txtUsername.Text + "] fué Inhabilitado por superar la cantidad de intentos fallidos(3). Por favor comuniquese con el Administrador del sistema.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MostrarMensajeErrorLogin();
                    }
                }
            }
            else
            {
                MessageBox.Show("El usuario [" + txtUsername.Text + "] se encuentra Inhabilitado para usar el sistema. Por favor comuniquese con el Administrador del sistema.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PrepararSeleccionRoles()
        {
            gbRoles.Visible = true;
            cmbRoles.Focus();
            //gbLogin.Visible = false;
            Util.ManejadorValidaciones validador = new Util.ManejadorValidaciones(this.errorProvider);
            validador.CrearValidacionesComboBox(ref cmbRoles, MensajesInfo.infoCampoRequerido.Replace("|@|", "Rol"));
            Util.ManejadorCombos.CargarComboRolesUsuario(ref cmbRoles, usuarioLogueado.Roles);
        }

        private void ReiniciarIntentosFallidos(Usuario usuarioLogueado)
        {
            UsuarioNegocio miUsuarioNegocio = new UsuarioNegocio();
            //Reinicio la cantidad de intentos fallidos
            usuarioLogueado.CantidadIntentosFallidos = 0;
            miUsuarioNegocio.GuardarUsuario(usuarioLogueado);
        }

        private void RegistrarIntentoFallido(Usuario usuarioLogueado)
        {
            UsuarioNegocio miUsuarioNegocio = new UsuarioNegocio();
            usuarioLogueado.CantidadIntentosFallidos = usuarioLogueado.CantidadIntentosFallidos + 1;
            usuarioLogueado.Inhabilitado = usuarioLogueado.CantidadIntentosFallidos >= 3; //Inhabilita al usuario cuando realiza el tercer intento fallido.
            miUsuarioNegocio.GuardarUsuario(usuarioLogueado);
        }

        private void MostrarMenu(Rol rol)
        {
            Principal formPrincipal = new Principal(this,rol.Funcionalidades);
            formPrincipal.Show();
        }

        #endregion

        #region - Eventos -

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                ObtenerUsuarioPorUsername();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                foreach (Rol rol in usuarioLogueado.Roles )
                {
                    if((int)cmbRoles.SelectedValue == rol.Codigo )
                    {
                        MostrarMenu(rol);
                        break;
                    }
            		 
                }
            }
        }

        #endregion
    }
}
