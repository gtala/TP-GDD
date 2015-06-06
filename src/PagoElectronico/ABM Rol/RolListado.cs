using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.FormulariosBase;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Util;

namespace PagoElectronico.ABM_Rol
{
    public partial class RolListado : FormularioListadoBase
    {
        private RolNegocio miRolNegocio;
        private RolEdicion miRolEdicion;
        private List<Rol> lstRoles;
        Dictionary<string, object> lstFiltros;

        #region - Métodos -

        public RolListado()
        {
            InitializeComponent();
            CargaInicialCombos();
            ValidacionesIniciales();
            dgListado.Size = new System.Drawing.Size(472, dgListado.Size.Height - 80);
        }

        private void CargaInicialCombos()
        {
            try
            {
                //ManejadorCombos.CargarComboPais(ref cmbFiltroPais);
                //ManejadorCombos.CargarComoboTipoDocumento(ref cmbTipoDocumento);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidacionesIniciales()
        {
            txtNombre.MaxLength = 255;
        }

        private void BuscarRoles()
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
                miRolNegocio = new RolNegocio();
                lstRoles = miRolNegocio.ObtenerRoles(lstFiltros);
                dgListado.ColumnCount = 3;
                dgListado.AutoGenerateColumns = false;
                dgListado.Columns[0].Name = "Código";
                dgListado.Columns[0].DataPropertyName = "Codigo";
                //dgListado.Columns[0].Visible = false;
                dgListado.Columns[1].Name = "Nombre";
                dgListado.Columns[1].DataPropertyName = "Nombre";
                dgListado.Columns[1].Width = 200;
                dgListado.Columns[2].Name = "Estado";
                dgListado.Columns[2].DataPropertyName = "EstadoString";
                dgListado.Columns[2].Width = 129;

                //Agrego la colección a la grilla.
                dgListado.DataSource = lstRoles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Dictionary<string, object> ObtenerFiltros()
        {
            Dictionary<string, object> lstFiltros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                lstFiltros.Add("Nombre", txtNombre.Text);
            }

            return lstFiltros;
        }

        private void LimpiarDatos()
        {
            try
            {
                dgListado.DataSource = null;
                txtNombre.Text = string.Empty;

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
                RolEdicion rolEdicion = new RolEdicion();
                rolEdicion.Padre = this;
                rolEdicion.ShowDialog(this);
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
                    Rol miRol = new Rol();
                    DataGridViewRow miFilaSeleccionada = dgListado.SelectedRows[0];
                    int codigoRol = Convert.ToInt32(miFilaSeleccionada.Cells[0].Value);
                    miRol = lstRoles.Find(x => x.Codigo == codigoRol);
                    miRolEdicion = new RolEdicion(miRol);
                    miRolEdicion.Padre = this;
                    miRolEdicion.Rol = miRol;
                }
                else
                {
                    //Alta
                    miRolEdicion = new RolEdicion();
                }

                miRolEdicion.ShowDialog(this);
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
                Rol miRol = new Rol();
                DataGridViewRow miFilaSeleccionada = dgListado.SelectedRows[0];
                int codigoRol = Convert.ToInt32(miFilaSeleccionada.Cells[0].Value);
                miRol = lstRoles.Find(x => x.Codigo == codigoRol);
                miRolNegocio = new RolNegocio();
                miRolNegocio.EliminarRol(codigoRol);
              //  MessageBox.Show(MensajesInfo.InfoRolEliminado);
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
            BuscarRoles();
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
            var resultado = MessageBox.Show(MensajesInfo.InfoConfirmación.Replace("|@|", "este rol"), "Baja rol", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                EliminarRegistro();
        }

        #endregion

    }
}
