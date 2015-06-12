using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PagoElectronico.ABM_Cliente;
using PagoElectronico.Entidades;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.FormulariosBase;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Util;

namespace PagoElectronico.Transferencias
{
    public partial class Transferencias : FormBase
    {

        public Transferencias()
        {
            InitializeComponent();
        }

        public Transferencias(Usuario usuario)
        {
            InitializeComponent();

            try
            {
                ClienteNegocio clienteNego = new ClienteNegocio();
                ClienteSesion = clienteNego.ObtenerClientePorUsuario(usuario.Username);
                if (ClienteSesion != null)
                {
                    this.UsuarioLogueado = usuario;
                    DataGridView dgGrillaOrigen = ucGrillaOrigen.Grilla;
                    dgGrillaOrigen.Size = new System.Drawing.Size(550, 180);
                    CargarGrillaOrigen(ref dgGrillaOrigen);
                    CargarGrillaDestino(ClienteSesion);

                    SetearDatosClienteOrigen(ClienteSesion);
                    SetearDatosClienteDestino(ClienteSesion);

                    this.AutoValidate = AutoValidate.Disable;
                    ManejadorValidaciones util = new ManejadorValidaciones(this.errorProvider);
                    util.CrearValidacionesNumericTextBox(ref txtImporte, MensajesInfo.infoCampoRequerido.Replace("|@|", "Importe"));
                }
                else
                {
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void SetearDatosClienteDestino(Cliente cliente)
        {
            lblNombreDestino.Text = cliente.Nombre;
            lblApellidoDestino.Text = cliente.Apellido;
            lblTipoDocDestino.Text = cliente.Tipo_Doc_Desc;
            lblNroDocDestino.Text = cliente.Nro_Documento.ToString();
        }

        private void SetearDatosClienteOrigen(Cliente cliente)
        {
            lblNombreOrigen.Text = cliente.Nombre;
            lblApellidoOrigen.Text = cliente.Apellido;
            lblTipoDocOrigen.Text = cliente.Tipo_Doc_Desc;
            lblNroDocOrigen.Text = cliente.Nro_Documento.ToString();
        }

        private void CargarGrillaOrigen(ref DataGridView dgGrillaOrigen)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente miCliente = clienteNegocio.ObtenerClientePorUsuario(UsuarioLogueado.Username);
            if (miCliente == null)
            {
                MessageBox.Show("No existen cuentas asociadas al usuario logueado.", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            else
            {
                CargarGrillaCuenta(ref dgGrillaOrigen, miCliente.Codigo, false);
            }
        }

        public void CargarGrillaDestino(Cliente cliente)
        {
            List<Cuenta> lstCuenta = new List<Cuenta>();
            CuentaNegocio cuentaNegocio = new CuentaNegocio();
            DataGridView dgGrillaDestino = ucGrillaDestino.Grilla;
            dgGrillaDestino.Size = new System.Drawing.Size(550, 180);
            if (cliente != null)
            {
                CargarGrillaCuenta(ref dgGrillaDestino, cliente.Codigo, true);
                SetearDatosClienteDestino(cliente);
            }
        }

        public void CargarGrillaCuenta(ref DataGridView grilla, int cliente, bool filtrarCuentas)
        {
            try
            {
                grilla.DataSource = null;
                CuentaNegocio miCuentaNegocio = new CuentaNegocio();
                List<Cuenta> lstCuentas = miCuentaNegocio.ObtenerCuentasPorCliente(cliente);
                if (filtrarCuentas)
                {
                    lstCuentas = lstCuentas.Where(c => c.Tipo_Estado != TipoEstado.CERRADA && c.Tipo_Estado != TipoEstado.PENDIENTE).ToList();
                }
                grilla.ColumnCount = 7;
                grilla.AutoGenerateColumns = false;
                grilla.Columns[0].Name = "Número";
                grilla.Columns[0].DataPropertyName = "Numero";
                grilla.Columns[0].Width = 105;
                grilla.Columns[1].Name = "Estado";
                grilla.Columns[1].DataPropertyName = "EstadoCuenta";
                grilla.Columns[1].Width = 70;
                grilla.Columns[2].Name = "Tipo";
                grilla.Columns[2].DataPropertyName = "TipoCuenta";
                grilla.Columns[2].Width = 70;
                grilla.Columns[3].Name = "Moneda";
                grilla.Columns[3].DataPropertyName = "Moneda";
                grilla.Columns[3].Width = 70;
                grilla.Columns[4].Name = "País";
                grilla.Columns[4].DataPropertyName = "PaisCuenta";
                grilla.Columns[5].ValueType = typeof(double);
                grilla.Columns[5].Name = "Saldo";
                grilla.Columns[5].DataPropertyName = "Saldo";
                grilla.Columns[5].Width = 92;
                grilla.Columns[6].ValueType = typeof(double);
                grilla.Columns[6].Name = "TipoCuenta_Costo";
                grilla.Columns[6].DataPropertyName = "TipoCuenta_Costo";
                grilla.Columns[6].Visible = false;

                //Agrego la colección a la grilla.
                grilla.DataSource = lstCuentas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            ClienteListado clienteLis;
            clienteLis = new ClienteListado();
            clienteLis.btnEliminar.Visible = false;
            clienteLis.btnAgregar.Visible = false;
            clienteLis.btnModificar.Visible = false;
            clienteLis.btnSeleccionar.Visible = true;
            clienteLis.TransferenciaFormulario = this;
            clienteLis.ShowDialog(this);
        }

        private void rbOtra_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscarClientes.Visible = ((RadioButton)sender).Checked;
        }

        private void rbPropia_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetearDatosClienteOrigen(ClienteSesion);
                CargarGrillaDestino(ClienteSesion);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                GuardarTransferencia();
            }
        }

        private Transferencia ObtenerTransferenciaFormulario()
        {

            long cuentaOrigen;
            long cuentaDestino;
            double saldoOrgien;
            double costoTransferencia = 0;
            bool generaCosto = !(lblNroDocOrigen.Text == lblNroDocDestino.Text && lblTipoDocDestino.Text == lblTipoDocOrigen.Text);

            DataGridViewRow miFilaSeleccionada = ucGrillaOrigen.Grilla.SelectedRows[0];

            if (generaCosto)
            {
                costoTransferencia = Convert.ToDouble(miFilaSeleccionada.Cells["TipoCuenta_Costo"].Value);
            }

            cuentaOrigen = Convert.ToInt64(miFilaSeleccionada.Cells["Número"].Value);
            saldoOrgien = Convert.ToDouble(miFilaSeleccionada.Cells["Saldo"].Value);
            miFilaSeleccionada = ucGrillaDestino.Grilla.SelectedRows[0];
            cuentaDestino = Convert.ToInt64(miFilaSeleccionada.Cells["Número"].Value);


            if (cuentaOrigen == cuentaDestino)
            {
                MessageBox.Show("La cuenta origen no puede ser igual a la cuenta destino.", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            if (saldoOrgien < (Convert.ToDouble(txtImporte.Text) + costoTransferencia))
            {
                string mensaje = "Saldo insuficiente.";
                mensaje = (saldoOrgien >= Convert.ToDouble(txtImporte.Text)) ? mensaje + " La transferencia tiene un costo de " + costoTransferencia.ToString() : mensaje;
                MessageBox.Show(mensaje, "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            Transferencia miTransferencia = new Transferencia();
            miTransferencia.Fecha = DateTime.Now.ToLocalTime();
            miTransferencia.Importe = Convert.ToDouble(txtImporte.Text);
            miTransferencia.CuentaOrigen = cuentaOrigen;
            miTransferencia.CuentaDestino = cuentaDestino;


            miTransferencia.Costo = costoTransferencia;

            return miTransferencia;
        }

        private void GuardarTransferencia()
        {
            Transferencia transferencia;
            transferencia = ObtenerTransferenciaFormulario();
            if (transferencia != null)
            {
                TransferenciaNegocio tn = new TransferenciaNegocio();
                tn.GuardarTransferencia(transferencia);
                MessageBox.Show("La transferencia se realizó correctemente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
