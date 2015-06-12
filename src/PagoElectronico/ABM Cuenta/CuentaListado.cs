using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.FormulariosBase;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.ABM_Cliente;
using PagoElectronico.Entidades;
using PagoElectronico.Util;
using System.Linq;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class CuentaListado : FormularioListadoBase
    {
        private CuentaNegocio miCuentaNegocio;
        private CuentaEdicion miCuentaEdicion;
        private List<Cuenta> lstCuentas;
        Dictionary<string, object> lstFiltros;
        private Cliente clienteSeleccionado;

        #region - Métodos -

        public CuentaListado()
        {
            InitializeComponent();
            CargaInicialCombos();
            ValidacionesIniciales();
            dgListado.Size = new System.Drawing.Size(600, dgListado.Size.Height - 80);
        }

        public CuentaListado(Usuario usuario)
        {
            InitializeComponent();
            CargaInicialCombos();
            ValidacionesIniciales();
            dgListado.Size = new System.Drawing.Size(780, dgListado.Size.Height - 80);
            UsuarioLogueado = usuario;

            if (usuario.RolActivo.Nombre != "Administrador")
            {
                ClienteNegocio cn = new ClienteNegocio();
                clienteSeleccionado = cn.ObtenerClientePorUsuario(usuario.Username);
                btnBuscarClientes.Visible = false;
            }

            if (clienteSeleccionado == null)
            {
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnBuscar.Enabled = false;
                btnLimpiar.Enabled = false;
            }
            else
            {
                SetClienteSeleccionado(clienteSeleccionado);
            }
        }

        private void CargaInicialCombos()
        {
            try
            {
                ManejadorCombos.CargarComboPais(ref cmbPais);
                ManejadorCombos.CargarComboTipoCuenta(ref cmbTipoCuenta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidacionesIniciales()
        {
            //txtNombre.MaxLength = 255;
        }

        private void BuscarCuentas()
        {
            try
            {
                CargarGrilla(clienteSeleccionado);
            }
            catch (Exception)
            {
                MessageBox.Show(MensajesError.ErrMensajeBusqueda);
            }
        }

        public void CargarGrilla(Cliente cliente)
        {
            try
            {
                ////lstFiltros = ObtenerFiltros();
                //ClienteNegocio cn = new ClienteNegocio();
                //Cliente cliente = cn.ObtenerClientePorUsuario(UsuarioLogueado.Username);

                dgListado.DataSource = null;
                miCuentaNegocio = new CuentaNegocio();
                lstCuentas = miCuentaNegocio.ObtenerCuentasPorCliente(cliente.Codigo);
                dgListado.ColumnCount = 5;
                dgListado.AutoGenerateColumns = false;
                dgListado.Columns[0].Name = "Número";
                dgListado.Columns[0].DataPropertyName = "Numero";
                dgListado.Columns[0].Width = 150;
                dgListado.Columns[1].Name = "Estado";
                dgListado.Columns[1].DataPropertyName = "EstadoCuenta";
                dgListado.Columns[1].Width = 150;
                dgListado.Columns[2].Name = "Tipo";
                dgListado.Columns[2].DataPropertyName = "TipoCuenta";
                dgListado.Columns[2].Width = 150;
                dgListado.Columns[3].Name = "Moneda";
                dgListado.Columns[3].DataPropertyName = "Moneda";
                dgListado.Columns[3].Width = 150;
                dgListado.Columns[4].Name = "País";
                dgListado.Columns[4].DataPropertyName = "PaisCuenta";
                dgListado.Columns[4].Width = 137;

                TipoCuenta filtroTipoCuenta;
                Pais filtroPais;
                TipoEstado filtroEstado = TipoEstado.PENDIENTE;

                filtroPais = (Pais)cmbPais.SelectedItem;
                filtroTipoCuenta = (TipoCuenta)cmbTipoCuenta.SelectedItem;
                if (!chkTodos.Checked)
                {
                    if (rbCerrada.Checked)
                    {
                        filtroEstado = TipoEstado.CERRADA;
                    }
                    else if (rbHabilitada.Checked)
                    {
                        filtroEstado = TipoEstado.HABILITADA;
                    }
                    else if (rbInhabilitada.Checked)
                    {
                        filtroEstado = TipoEstado.INHABILITADA;
                    }
                    else if (rbPendiente.Checked)
                    {
                        filtroEstado = TipoEstado.PENDIENTE;
                    }
                }

                lstCuentas = lstCuentas.Where(c => (chkTodos.Checked || c.Tipo_Estado == filtroEstado)
                                        && (filtroPais.Codigo == -1 || c.Pais.Codigo == filtroPais.Codigo)
                                        && (filtroTipoCuenta.Codigo == -1 || c.Tipo.Codigo == filtroTipoCuenta.Codigo)).ToList();

                //Agrego la colección a la grilla.
                dgListado.DataSource = lstCuentas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Dictionary<string, object> ObtenerFiltros()
        {
            Dictionary<string, object> lstFiltros = new Dictionary<string, object>();

            //if (!string.IsNullOrEmpty(txtNombre.Text))
            //{
            //    lstFiltros.Add("Nombre", txtNombre.Text);
            //}

            return lstFiltros;
        }

        private void LimpiarDatos()
        {
            try
            {
                dgListado.DataSource = null;
                cmbTipoCuenta.SelectedValue = -1;
                cmbPais.SelectedValue = -1;

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
                CuentaEdicion cuentaEdicion = new CuentaEdicion();
                cuentaEdicion.Padre = this;
                cuentaEdicion.ClienteActual = clienteSeleccionado;
                cuentaEdicion.ShowDialog(this);
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
                    Cuenta miCuenta = new Cuenta();
                    DataGridViewRow miFilaSeleccionada = dgListado.SelectedRows[0];
                    long numeroCuenta = Convert.ToInt64(miFilaSeleccionada.Cells[0].Value);
                    miCuenta = lstCuentas.Find(x => x.Numero == numeroCuenta);
                    miCuentaEdicion = new CuentaEdicion(miCuenta);
                    miCuentaEdicion.Padre = this;
                    miCuentaEdicion.ClienteActual = clienteSeleccionado;
                    miCuentaEdicion.CuentaActual = miCuenta;
                }
                else
                {
                    //Alta
                    miCuentaEdicion = new CuentaEdicion();
                }

                miCuentaEdicion.ShowDialog(this);
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
                Cuenta miCuenta = new Cuenta();
                DataGridViewRow miFilaSeleccionada = dgListado.SelectedRows[0];
                long cuentaNumero = Convert.ToInt64(miFilaSeleccionada.Cells[0].Value);
                miCuenta = lstCuentas.Find(x => x.Numero == cuentaNumero);
                miCuentaNegocio = new CuentaNegocio();
                miCuenta.Estado = new EstadoCuenta() { Codigo = (int)TipoEstado.CERRADA };
                miCuentaNegocio.GuardarCuenta(miCuenta, false);
                MessageBox.Show("La cuenta se dió de baja correctamente", "Baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresco la grilla.
                CargarGrilla(clienteSeleccionado);

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
            BuscarCuentas();
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
            var resultado = MessageBox.Show(MensajesInfo.InfoConfirmación.Replace("|@|", "este cuenta"), "Baja cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                EliminarRegistro();
        }

        #endregion

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            ClienteListado clienteLis;
            clienteLis = new ClienteListado();
            clienteLis.btnEliminar.Visible = false;
            clienteLis.btnAgregar.Visible = false;
            clienteLis.btnModificar.Visible = false;
            clienteLis.btnSeleccionar.Visible = true;
            clienteLis.CuentasFormulario = this;
            clienteLis.ShowDialog(this);
        }

        internal void SetClienteSeleccionado(Cliente miCliente)
        {
            clienteSeleccionado = miCliente;
            lblApellidoOrigen.Text = miCliente.Apellido;
            lblNombreOrigen.Text = miCliente.Nombre;
            lblTipoDocOrigen.Text = miCliente.Tipo_Doc_Desc;
            lblNroDocOrigen.Text = miCliente.Nro_Documento.ToString();
            btnLimpiar.Enabled = true;
            btnBuscar.Enabled = true;
            btnAgregar.Enabled = true;
            CargarGrilla(miCliente);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            gbEstados.Enabled = !((CheckBox)sender).Checked;
        }
    }
}
