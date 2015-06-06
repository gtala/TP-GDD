using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.FormulariosBase;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Util;

namespace PagoElectronico.ABM_de_Usuario
{
    public partial class UsuarioListado : FormulariosBase.FormularioListadoBase
    {
        private UsuarioNegocio miUsuarioNegocio;
        private UsuarioEdicion miUsuarioEdicion;
        private List<Usuario> lstUsuarios;
        Dictionary<string, object> lstFiltros;

        #region - Métodos -

        public UsuarioListado()
        {
            InitializeComponent();
            CargaInicialCombos();
            ValidacionesIniciales();

            dgListado.Size = new System.Drawing.Size(800, dgListado.Size.Height);
        }

        private void CargaInicialCombos()
        {
            //try
            //{
            //    ManejadorCombos.CargarComboPais(ref cmbFiltroPais);
            //    ManejadorCombos.CargarComoboTipoDocumento(ref cmbTipoDocumento);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }

        private void ValidacionesIniciales()
        {
            txtUsername.MaxLength = 255;
        }

        private void BuscarUsuarios()
        {
            try
            {
                CargarGrilla();
            }
            catch (Exception)
            {
                MessageBox.Show(MensajesError.ErrMensajeBusqueda);
            }
        }

        public void CargarGrilla()
        {
            try
            {
                lstFiltros = ObtenerFiltros();

                dgListado.DataSource = null;
                miUsuarioNegocio = new UsuarioNegocio();
                lstUsuarios = miUsuarioNegocio.ObtenerUsuarios(lstFiltros);
                dgListado.ColumnCount = 4;
                dgListado.AutoGenerateColumns = false;
                dgListado.Columns[0].Name = "Username";
                dgListado.Columns[0].DataPropertyName = "Username";
                dgListado.Columns[0].Width = 200;
                dgListado.Columns[1].Name = "Fecha creación";
                dgListado.Columns[1].DataPropertyName = "FechaCreacion";
                dgListado.Columns[1].Width = 200;
                dgListado.Columns[2].Name = "Fecha última modificacion";
                dgListado.Columns[2].DataPropertyName = "FechaUltimaModificacion";
                dgListado.Columns[2].Width = 200;
                dgListado.Columns[3].Name = "Inhabilitado";
                dgListado.Columns[3].DataPropertyName = "InhabilitadoString";
                dgListado.Columns[3].Width = 157;

                //Agrego la colección a la grilla.
                dgListado.DataSource = lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Dictionary<string, object> ObtenerFiltros()
        {
            Dictionary<string, object> lstFiltros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                lstFiltros.Add("Username", txtUsername.Text);
            }

            return lstFiltros;
        }

        private void LimpiarDatos()
        {
            try
            {
                 dgListado.DataSource = null;
                 txtUsername.Text = string.Empty;

                if (dgListado.Rows.Count < 1)
                {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MensajesError.ErrMensajesLimpiar);
            }
        }

        private void AgregarRegistro()
        {
            try
            {
                UsuarioEdicion UsuarioEdicion = new UsuarioEdicion();
                UsuarioEdicion.Padre = this;
                UsuarioEdicion.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MensajesError.ErrMensajeAlta);
            }
        }

        private void ModificarRegistro()
        {
            try
            {
                //Si hay fila seleccionada, se trata de una EDICIÓN, sino será un ALTA.
                if (dgListado.SelectedRows.Count != 0)
                {
                    //Edición
                    Usuario miUsuario = new Usuario();
                    DataGridViewRow miFilaSeleccionada = dgListado.SelectedRows[0];
                    string username = Convert.ToString(miFilaSeleccionada.Cells[0].Value);
                    miUsuario = lstUsuarios.Find(x => x.Username == username);
                    miUsuarioEdicion = new UsuarioEdicion(miUsuario);
                    miUsuarioEdicion.Padre = this;
                    miUsuarioEdicion.Usuario = miUsuario;
                }
                else
                {
                    //Alta
                    miUsuarioEdicion = new UsuarioEdicion();
                }

                miUsuarioEdicion.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MensajesError.ErrMensajeModificación);
            }
        }

        private void EliminarRegistro()
        {
            try
            {
                Usuario miUsuario = new Usuario();
                DataGridViewRow miFilaSeleccionada = dgListado.SelectedRows[0];
                string username = Convert.ToString(miFilaSeleccionada.Cells[0].Value);
                miUsuario = lstUsuarios.Find(x => x.Username == username);
                miUsuarioNegocio = new UsuarioNegocio();
                miUsuarioNegocio.EliminarUsuario(username);
                MessageBox.Show(MensajesInfo.InfoEliminado.Replace("|@|","El usuario"));
                //Refresco la grilla.
                CargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show(MensajesError.ErrMensajeBaja);
            }

        }

        #endregion

        #region - Eventos -

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(MensajesInfo.InfoConfirmación.Replace("|@|", "este Usuario"), "Baja Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                EliminarRegistro();
        }

        #endregion
        
    }
}
