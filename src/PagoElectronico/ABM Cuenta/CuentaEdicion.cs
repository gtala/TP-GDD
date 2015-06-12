using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Util;
using PagoElectronico.Entidades;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class CuentaEdicion : FormulariosBase.FormularioEdicionBase
    {
        #region - Propiedades -

        private CuentaNegocio miCuentaNegocio;
        private Cuenta cuentaActual;
        public CuentaListado Padre;
        public Cuenta CuentaActual
        {
            get
            {
                return cuentaActual;
            }
            set
            {
                cuentaActual = value;
            }
        }

        private Cliente clienteActual;
        public Cliente ClienteActual
        {
            get
            {
                return clienteActual;
            }
            set
            {
                clienteActual = value;
            }
        }

        #endregion

        #region - Métodos -

        /// <summary>
        /// Constructor para el Alta.
        /// </summary>
        public CuentaEdicion()
        {
            InitializeComponent();
            IniciarFormulario();
            rbPendiente.Checked = true;
            rbCerrada.Enabled = false;
            rbHabilitada.Enabled = false;
            rbInhabilitada.Enabled = false;
        }

        private void IniciarFormulario()
        {
            this.AutoValidate = AutoValidate.Disable;
            CargarCombos();
            ValidacionesIniciales();
            Util.ManejadorValidaciones util = new Util.ManejadorValidaciones(this.errProvider);
            util.CrearValidacionesNumericTextBox(ref txtNumeroCuenta, MensajesInfo.infoCampoRequerido.Replace("|@|", "Número"));
            util.CrearValidacionesComboBox(ref cmbTipoCuenta, MensajesInfo.infoCampoRequerido.Replace("|@|", "Tipo Cuenta"));
            util.CrearValidacionesComboBox(ref cmbMoneda, MensajesInfo.infoCampoRequerido.Replace("|@|", "Moneda"));
            util.CrearValidacionesComboBox(ref cmbPais, MensajesInfo.infoCampoRequerido.Replace("|@|", "País"));
        }

        private void ValidacionesIniciales()
        {
            ////GDT: Me aseguro que no rompa la base.
            txtNumeroCuenta.MaxLength = 18;
        }

        private void CargarCombos()
        {
            try
            {
                ManejadorCombos.CargarComboPais(ref cmbPais);
                ManejadorCombos.CargarComboMoneda(ref cmbMoneda);
                ManejadorCombos.CargarComboTipoCuenta(ref cmbTipoCuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Constructor usado cuando se realiza una edición.
        /// </summary>
        /// <param name="miCuenta"></param>
        public CuentaEdicion(Cuenta miCuenta)
        {
            InitializeComponent();
            IniciarFormulario();
            CuentaActual = miCuenta;
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            try
            {
                txtNumeroCuenta.Text = cuentaActual.Numero.ToString();
                txtNumeroCuenta.Enabled = false;

                cmbPais.SelectedValue = cuentaActual.Pais.Codigo;
                cmbMoneda.SelectedValue = cuentaActual.MonedaCodigo;
                cmbTipoCuenta.SelectedValue = cuentaActual.Tipo.Codigo;
                lblFechaCierre.Text = cuentaActual.FechaCierre == DateTime.MinValue ? string.Empty : Convert.ToString(cuentaActual.FechaCierre);
                lblFechaCreacion.Text = Convert.ToString(cuentaActual.FechaCreacion);

                switch (cuentaActual.Tipo_Estado)
                {
                    case PagoElectronico.Entidades.TipoEstado.PENDIENTE:
                        rbPendiente.Checked = true;
                        break;
                    case PagoElectronico.Entidades.TipoEstado.CERRADA:
                        rbCerrada.Checked = true;
                        rbPendiente.Enabled = false;
                        rbInhabilitada.Enabled = false;
                        rbHabilitada.Enabled = false;
                        break;
                    case PagoElectronico.Entidades.TipoEstado.INHABILITADA:
                        rbInhabilitada.Checked = true;
                        break;
                    case PagoElectronico.Entidades.TipoEstado.HABILITADA:
                        rbHabilitada.Checked = true;
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Cuenta ObtenerCuentaFormulario(ref bool esAlta)
        {
            try
            {
                esAlta = false;
                //Si es un Alta
                if (cuentaActual == null)
                {
                    esAlta = true;
                    cuentaActual = new Cuenta();
                    cuentaActual.FechaCreacion = DateTime.Now;
                }
                cuentaActual.Numero = Convert.ToInt64(txtNumeroCuenta.Text);
                cuentaActual.Pais = (Pais)cmbPais.SelectedItem;
                cuentaActual.Tipo = (TipoCuenta)cmbTipoCuenta.SelectedItem;
                cuentaActual.MonedaCodigo = (int)cmbMoneda.SelectedValue;
                cuentaActual.Cliente = clienteActual.Codigo;

                if (rbCerrada.Checked)
                {
                    cuentaActual.Estado = new EstadoCuenta() { Codigo = (int)TipoEstado.CERRADA, Descipcion = string.Empty };
                    cuentaActual.FechaCierre = cuentaActual.FechaCierre > DateTime.MinValue ? cuentaActual.FechaCierre: DateTime.Now;
                }
                else if (rbHabilitada.Checked)
                {
                    cuentaActual.Estado = new EstadoCuenta() { Codigo = (int)TipoEstado.HABILITADA, Descipcion = string.Empty };
                }
                else if (rbInhabilitada.Checked)
                {
                    cuentaActual.Estado = new EstadoCuenta() { Codigo = (int)TipoEstado.INHABILITADA, Descipcion = string.Empty };
                }
                else if (rbPendiente.Checked)
                {
                    cuentaActual.Estado = new EstadoCuenta() { Codigo = (int)TipoEstado.PENDIENTE, Descipcion = string.Empty };
                }

                return cuentaActual;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void GuardarCuenta()
        {
            try
            {
                bool esAlta = false;
                miCuentaNegocio = new CuentaNegocio();
                cuentaActual = ObtenerCuentaFormulario(ref esAlta);
                miCuentaNegocio.GuardarCuenta(cuentaActual, esAlta);
                MessageBox.Show("¡Se guardaron los datos correctamente!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Padre.CargarGrilla(clienteActual);
                //Cierro el formulario actual.
                this.Dispose();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PK"))
                {
                    var result = MessageBox.Show("El Número de cuenta ya existe, por favor intente con otro.", "Numero existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar guardar la cuenta.", "Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar guardar la cuenta.", "Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region - Eventos -

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                GuardarCuenta();
            }
        }

        #endregion
    }
}
