using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Util;
using System.Linq;

namespace PagoElectronico.ABM_de_Usuario
{
    public partial class UsuarioEdicion : FormulariosBase.FormularioEdicionBase
    {
        #region - Propiedades -

        private UsuarioNegocio miUsuarioNegocio;
        private Usuario usuario;
        public UsuarioListado Padre;
        public Usuario Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        #endregion

        #region - Métodos -

        /// <summary>
        /// Constructor para el Alta.
        /// </summary>
        public UsuarioEdicion()
        {
            InitializeComponent();
            IniciarFormulario();

            ManejadorValidaciones util = new ManejadorValidaciones(this.errProvider);
            util.CrearValidacionesTextBox(ref txtUsername, MensajesInfo.infoCampoRequerido.Replace("|@|", "Username"));
            util.CrearValidacionesTextBox(ref txtPassword, MensajesInfo.infoCampoRequerido.Replace("|@|", "Password"));
        }

        private void IniciarFormulario()
        {
            this.AutoValidate = AutoValidate.Disable;
            CargarCombos();
            ValidacionesIniciales();
            Util.ManejadorValidaciones util = new Util.ManejadorValidaciones(this.errProvider);
            util.CrearValidacionesTextBox(ref txtPregunta, MensajesInfo.infoCampoRequerido.Replace("|@|", "Pregunta secreta"));
            util.CrearValidacionesTextBox(ref txtRespuesta, MensajesInfo.infoCampoRequerido.Replace("|@|", "Respuesta secreta"));
            util.CrearValidacionesListBox(ref lstAsignados, "Debe seleccionar al menos un(1) Rol");


        }

        private void ValidacionesIniciales()
        {
            //GDT: Me aseguro que no rompa la base.
            txtUsername.MaxLength = 255;
            txtPassword.MaxLength = 255;
            txtRespuesta.MaxLength = 255;
            txtPregunta.MaxLength = 255;

        }

        private void CargarCombos()
        {
            try
            {


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Constructor usado cuando se realiza una edición.
        /// </summary>
        /// <param name="miUsuario"></param>
        public UsuarioEdicion(Usuario miUsuario)
        {
            InitializeComponent();
            IniciarFormulario();
            Usuario = miUsuario;
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            try
            {
                txtUsername.Text = Usuario.Username;
                txtUsername.ReadOnly = true; // es la clave, no se puede editar.

                txtPassword.Text = Usuario.Password;
                txtPassword.ReadOnly = true;
                chkInhabilitado.Checked = Usuario.Inhabilitado;
                txtPregunta.Text = Usuario.PreguntaSecreta;
                txtRespuesta.Text = Usuario.RespuestaSecreta;
                lblFechaCreacion.Text = Convert.ToString(Usuario.FechaCreacion);
                lblFechaModificacion.Text = Usuario.FechaUltimaModificacion != DateTime.MinValue ? Convert.ToString(Usuario.FechaUltimaModificacion) : string.Empty;

                //Cargo los roles
                RolNegocio miRolNegocio = new RolNegocio();
                List<Rol> lstRolesTodos = new List<Rol>();
                List<Rol> lstRolesNoAsignados = new List<Rol>();
                lstRolesTodos = miRolNegocio.ObtenerRoles(new Dictionary<string, object>());
                lstRolesNoAsignados = lstRolesTodos.Where(item => !usuario.Roles.Exists(r => r.Codigo == item.Codigo)).ToList();
                ManejadorCombos.CargarListBoxRoles(ref lstNoAsignados, lstRolesNoAsignados);
                ManejadorCombos.CargarListBoxRoles(ref lstAsignados, usuario.Roles);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Usuario ObtenerUsuarioFormulario()
        {
            try
            {
                //Si es un Alta
                if (usuario == null)
                {
                    usuario = new Usuario();
                }
                else
                {
                    usuario.FechaUltimaModificacion = DateTime.Now; // Ver si tiene que ser parametro de configuración.
                }
                usuario.Username = txtUsername.Text;
                usuario.Password = txtPassword.Text;
                usuario.PreguntaSecreta = txtPregunta.Text;
                usuario.RespuestaSecreta = txtRespuesta.Text;
                usuario.Inhabilitado = chkInhabilitado.Checked;
                usuario.FechaCreacion = (lblFechaCreacion.Text != string.Empty) ? Convert.ToDateTime(lblFechaCreacion.Text) : DateTime.MinValue;
                usuario.Roles = (List<Rol>)lstAsignados.DataSource;
                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void GuardarUsuario()
        {
            try
            {
                miUsuarioNegocio = new UsuarioNegocio();
                usuario = ObtenerUsuarioFormulario();
                miUsuarioNegocio.GuardarUsuario(usuario);
                MessageBox.Show("¡Se guardaron los datos correctamente!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Padre.CargarGrilla();
                //Cierro el formulario actual.
                this.Dispose();
            }
            catch (SqlException ex)
            {
                //if (ex.Message.Contains("U_Usuario_Mail"))
                //{
                //   var result = MessageBox.Show("El mail ingresado ya se encuentra en uso, por favor intente con otro.", "Mail duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (ex.Message.Contains("U_Documento"))
                //{
                //    var result = MessageBox.Show("La combinación tipo y numero de documento ingresada ya existe, por favor intente con otra.", "Tipo y numero de docuemnto existente", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                //}
                //else
                //{
                //    MessageBox.Show(MensajesError.ErrMensajeGuardarUsuario);
                //}
            }
            catch (Exception ex)
            {
                // MessageBox.Show(MensajesError.ErrMensajeGuardarUsuario);
            }
        }

        private void MoverItems(ref ListBox lstOrigen, ref ListBox lstDestino, bool moverTodos)
        {

            try
            {
                if (lstOrigen.SelectedItem != null)
                {
                    List<Rol> lstNuevoOrigen = (List<Rol>)lstOrigen.DataSource;
                    List<Rol> lstNuevoDestino = (List<Rol>)lstDestino.DataSource;

                    if (!moverTodos)
                    {
                        lstNuevoDestino.Add((Rol)lstOrigen.SelectedItem);
                        lstNuevoOrigen.Remove((Rol)lstOrigen.SelectedItem);
                    }
                    else
                    {
                        List<Rol> aux = new List<Rol>();

                        foreach (Rol item in lstNuevoDestino)
                        {
                            aux.Add(item);
                        }

                        foreach (Rol item in lstNuevoOrigen)
                        {
                            aux.Add(item);
                        }

                        lstNuevoDestino = aux;
                        lstNuevoOrigen.Clear();
                    }

                    lstOrigen.DataSource = null;
                    lstDestino.DataSource = null;

                    lstOrigen.Items.Clear();
                    lstDestino.Items.Clear();

                    Util.ManejadorCombos.CargarListBoxRoles(ref lstOrigen, lstNuevoOrigen);
                    Util.ManejadorCombos.CargarListBoxRoles(ref lstDestino, lstNuevoDestino);

                    lstOrigen.Refresh();
                    lstDestino.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        #region - Eventos -

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                GuardarUsuario();
            }
            else
            {
                if (lstAsignados.SelectedItem == null)
                {
                    tbUsuario.SelectTab(1);
                }
                else
                {
                    tbUsuario.SelectTab(0);
                }
            }
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            try
            {
                MoverItems(ref lstAsignados, ref lstNoAsignados, false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDesasignarTodos_Click(object sender, EventArgs e)
        {
            MoverItems(ref lstAsignados, ref lstNoAsignados, true);
        }

        private void btnAsignarTodos_Click(object sender, EventArgs e)
        {
            MoverItems(ref lstNoAsignados, ref lstAsignados, true);
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                MoverItems(ref lstNoAsignados, ref lstAsignados, false);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

    }
}
