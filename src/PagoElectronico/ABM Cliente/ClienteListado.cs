using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.FormulariosBase;
using PagoElectronico.Negocio.Clases;
using System.ComponentModel;
using PagoElectronico.Util;

namespace PagoElectronico.ABM_Cliente
{
    public partial class ClienteListado : FormularioListadoBase
    {
        private ClienteNegocio miClienteNegocio;
        private ClienteEdicion miClienteEdicion;
        private List<Cliente> lstClientes;
        Dictionary<string, object> lstFiltros;

        #region - Métodos -

        public ClienteListado()
        {
            InitializeComponent();
            CargaInicialCombos();
            ValidacionesIniciales();
        }

        private void CargaInicialCombos()
        {
            try
            {
                ManejadorCombos.CargarComboPais(ref cmbFiltroPais);
                ManejadorCombos.CargarComoboTipoDocumento(ref cmbTipoDocumento);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidacionesIniciales()
        {
            txtFiltroNombre.MaxLength = 255;
            txtFiltroApellido.MaxLength = 255;
            txtMail.MaxLength = 255;
            numNroDocumento.MaxLength = 18;
        }

        private void BuscarClientes()
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
                miClienteNegocio = new ClienteNegocio();
                lstClientes = miClienteNegocio.ObtenerClientes(lstFiltros);
                dgListado.ColumnCount = 13;
                dgListado.AutoGenerateColumns = false;
                dgListado.Columns[0].Name = "Código";
                dgListado.Columns[0].DataPropertyName = "Codigo";
                dgListado.Columns[0].Visible = false;
                dgListado.Columns[1].Name = "Nombre";
                dgListado.Columns[1].DataPropertyName = "Nombre";
                dgListado.Columns[2].Name = "Apellido";
                dgListado.Columns[2].DataPropertyName = "Apellido";
                dgListado.Columns[3].Name = "Tipo Documento";
                dgListado.Columns[3].DataPropertyName = "Tipo_Doc_Desc";
                dgListado.Columns[4].Name = "Número Documento";
                dgListado.Columns[4].DataPropertyName = "Nro_Documento";
                dgListado.Columns[5].Name = "País";
                dgListado.Columns[5].DataPropertyName = "Pais_Descripcion";
                dgListado.Columns[6].Name = "Fecha Nacimiento";
                dgListado.Columns[6].DataPropertyName = "Fecha_Nacimiento";
                dgListado.Columns[7].Name = "Domicilio Calle";
                dgListado.Columns[7].DataPropertyName = "Domicilio_Calle";
                dgListado.Columns[8].Name = "Domicilio Número";
                dgListado.Columns[8].DataPropertyName = "Domicilio_Nro";
                dgListado.Columns[9].Name = "Domicilio Piso";
                dgListado.Columns[9].DataPropertyName = "Domicilio_Piso";
                dgListado.Columns[10].Name = "Domicilio Departamento";
                dgListado.Columns[10].DataPropertyName = "Domicilio_Depto";
                dgListado.Columns[11].Name = "E-Mail";
                dgListado.Columns[11].DataPropertyName = "Mail";
                dgListado.Columns[11].Width = 200;
                dgListado.Columns[12].Name = "Baja";
                dgListado.Columns[12].DataPropertyName = "BajaEstado";

                //Agrego la colección a la grilla.
                dgListado.DataSource = lstClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Dictionary<string, object> ObtenerFiltros()
        {
            Dictionary<string, object> lstFiltros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtFiltroNombre.Text))
            {
                lstFiltros.Add("Nombre", txtFiltroNombre.Text);
            }

            if (!string.IsNullOrEmpty(txtFiltroApellido.Text))
            {
                lstFiltros.Add("Apellido", txtFiltroApellido.Text);
            }

            if (!string.IsNullOrEmpty(txtMail.Text))
            {
                lstFiltros.Add("Mail", txtMail.Text);
            }

            if (cmbFiltroPais.SelectedValue != null && Convert.ToInt32(cmbFiltroPais.SelectedValue) > 0)
            {
                lstFiltros.Add("Pais_Codigo", Convert.ToInt32(cmbFiltroPais.SelectedValue));
            }

            if (cmbTipoDocumento.SelectedValue != null && Convert.ToInt32(cmbTipoDocumento.SelectedValue) > 0)
            {
                lstFiltros.Add("Tipo_Doc", Convert.ToInt32(cmbTipoDocumento.SelectedValue));
            }

            if (!string.IsNullOrEmpty(numNroDocumento.Text))
            {
                lstFiltros.Add("Nro_Documento", Convert.ToInt32(numNroDocumento.Text));
            }

            if (rbHabilitados.Checked)
            {
                lstFiltros.Add("Baja", 0);
            }
            else if (rbNoHabilitados.Checked)
            {
                lstFiltros.Add("Baja", 1);
            }


            return lstFiltros;
        }

        private void LimpiarDatos()
        {
            try
            {
                dgListado.DataSource = null;
                txtFiltroApellido.Text = string.Empty;
                txtFiltroNombre.Text = string.Empty;
                txtMail.Text = string.Empty;
                numNroDocumento.Text = string.Empty;
                cmbFiltroPais.SelectedValue = -1;
                cmbTipoDocumento.SelectedValue = -1;
                rbTodos.Checked = true;

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
                ClienteEdicion clienteEdicion = new ClienteEdicion();
                clienteEdicion.Padre = this;
                clienteEdicion.ShowDialog(this);
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
                    Cliente miCliente = new Cliente();
                    DataGridViewRow miFilaSeleccionada = dgListado.SelectedRows[0];
                    int codigoCliente = Convert.ToInt32(miFilaSeleccionada.Cells[0].Value);
                    miCliente = lstClientes.Find(x => x.Codigo == codigoCliente);
                    miClienteEdicion = new ClienteEdicion(miCliente);
                    miClienteEdicion.Padre = this;
                    miClienteEdicion.Cliente = miCliente;
                }
                else
                {
                    //Alta
                    miClienteEdicion = new ClienteEdicion();
                }

                miClienteEdicion.ShowDialog(this);
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
                Cliente miCliente = new Cliente();
                DataGridViewRow miFilaSeleccionada = dgListado.SelectedRows[0];
                int codigoCliente = Convert.ToInt32(miFilaSeleccionada.Cells[0].Value);
                miCliente = lstClientes.Find(x => x.Codigo == codigoCliente);
                miClienteNegocio = new ClienteNegocio();
                miClienteNegocio.EliminarCliente(codigoCliente);
                MessageBox.Show(MensajesInfo.InfoClienteEliminado);
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
            BuscarClientes();
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
            var resultado = MessageBox.Show(MensajesInfo.InfoConfirmación.Replace("|@|", "este cliente"), "Baja cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                EliminarRegistro();
        }

        #endregion

    }
}
