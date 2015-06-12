using System;
using System.Linq;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.FormulariosBase;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Util;

namespace PagoElectronico.Login
{
    public partial class Login : FormBase
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
                string paswordIngresadoEncriptado = Encriptador.Encriptar(txtPassword.Text);
                bool logueoCorrecto = usuarioLogueado.Password == paswordIngresadoEncriptado;
                Negocio.Helpers.UtilNegocio util = new PagoElectronico.Negocio.Helpers.UtilNegocio();

                if (logueoCorrecto)
                {
                    util.GuardarAuditoriaLogin(usuarioLogueado.Username, logueoCorrecto, usuarioLogueado.CantidadIntentosFallidos + 1);

                    ReiniciarIntentosFallidos(usuarioLogueado);
                    //Solo roles habilitados
                    usuarioLogueado.Roles = usuarioLogueado.Roles.Where(r => !r.Estado).ToList();

                    if (usuarioLogueado.Roles != null && usuarioLogueado.Roles.Count > 0)
                    {
                        if (usuarioLogueado.Roles.Count > 1)
                        {
                            PrepararSeleccionRoles();
                        }
                        else
                        {
                            usuarioLogueado.RolActivo = usuarioLogueado.Roles[0];
                            MostrarMenu(usuarioLogueado);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario [" + txtUsername.Text + "] no tiene roles habilitados asignados. Por favor comuniquese con el Administrador del sistema.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    RegistrarIntentoFallido(usuarioLogueado);
                    util.GuardarAuditoriaLogin(usuarioLogueado.Username, logueoCorrecto, usuarioLogueado.CantidadIntentosFallidos);
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

        private void MostrarMenu(Usuario usuario)
        {
            Principal formPrincipal = new Principal(this, usuario);
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
                foreach (Rol rol in usuarioLogueado.Roles)
                {
                    if ((int)cmbRoles.SelectedValue == rol.Codigo)
                    {
                        usuarioLogueado.RolActivo = rol;
                        MostrarMenu(usuarioLogueado);
                        break;
                    }

                }
            }
        }

        #endregion
    }
}
