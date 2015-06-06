using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Util;

namespace PagoElectronico.ABM_Cliente
{
    public partial class ClienteEdicion : FormulariosBase.FormularioEdicionBase
    {
        #region - Propiedades -

        private List<Pais> lstPaises;
        private ClienteNegocio miClienteNegocio;
        private Cliente cliente;
        public ClienteListado Padre;
        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

        #endregion

        #region - Métodos -
        
        /// <summary>
        /// Constructor para el Alta.
        /// </summary>
        public ClienteEdicion()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        private void IniciarFormulario()
        {
            this.AutoValidate = AutoValidate.Disable;
            CargarCombos();
            ValidacionesIniciales();
            Util.ManejadorValidaciones util = new Util.ManejadorValidaciones(this.errorProvider);
            util.CrearValidacionesTextBox(ref txtApellido, MensajesInfo.infoCampoRequerido.Replace("|@|", "Apellido"));
            util.CrearValidacionesTextBox(ref txtNombre, MensajesInfo.infoCampoRequerido.Replace("|@|", "Nombre"));
            util.CrearValidacionesNumericTextBox(ref numDocumento, MensajesInfo.infoCampoRequerido.Replace("|@|", "Número documento"));
            util.CrearValidacionesTextBoxEmail(ref txtEmail, MensajesInfo.infoMailInvalido);
            util.CrearValidacionesComboBox(ref cmbTipoDoc, MensajesInfo.infoCampoRequerido.Replace("|@|", "Tipo documento"));
            util.CrearValidacionesComboBox(ref cmbPais, MensajesInfo.infoCampoRequerido.Replace("|@|", "País"));
        }

        private void ValidacionesIniciales()
        {
            //GDT: Me aseguro que no rompa la base.
            txtNombre.MaxLength = 255;
            txtApellido.MaxLength = 255;
            txtDomiCalle.MaxLength = 255;
            txtDomiDepto.MaxLength = 10;

        }

        private void CargarCombos()
        {
            try
            {
                ManejadorCombos.CargarComboPais(ref cmbPais);
                ManejadorCombos.CargarComoboTipoDocumento(ref cmbTipoDoc);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Constructor usado cuando se realiza una edición.
        /// </summary>
        /// <param name="miCliente"></param>
        public ClienteEdicion(Cliente miCliente)
        {
            InitializeComponent();
            IniciarFormulario();
            Cliente = miCliente;
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            try
            {
                txtNombre.Text = Cliente.Nombre;
                txtApellido.Text = Cliente.Apellido;
                numDocumento.Text = Convert.ToString(Cliente.Nro_Documento);
                dtpFechaNac.Value = Cliente.Fecha_Nacimiento;
                txtEmail.Text = Cliente.Mail;
                txtDomiCalle.Text = Cliente.Domicilio_Calle;
                txtDomiDepto.Text = Cliente.Domicilio_Depto;
                numDomicilioNumero.Text = Convert.ToString(Cliente.Domicilio_Nro);
                numDomicilioPiso.Text = Convert.ToString(Cliente.Domicilio_Piso);
                cmbPais.SelectedValue = Cliente.Pais.Codigo;
                chkBaja.Checked = Cliente.Baja;
                cmbTipoDoc.SelectedValue = Cliente.Tipo_Doc_Codigo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Cliente ObtenerClienteFormulario()
        {
            try
            {
                //Si es un Alta
                if (cliente == null)
                {
                    cliente = new Cliente();
                }
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Tipo_Doc_Codigo = Convert.ToInt32(((DataRowView)cmbTipoDoc.SelectedItem)["Tipo_Doc_Cod"]);
                cliente.Nro_Documento = Convert.ToInt32(numDocumento.Text);
                cliente.Fecha_Nacimiento = dtpFechaNac.Value;
                cliente.Domicilio_Piso = string.IsNullOrEmpty(numDomicilioPiso.Text) ? 0 : Convert.ToInt32(numDomicilioPiso.Text);
                cliente.Domicilio_Nro = string.IsNullOrEmpty(numDomicilioNumero.Text) ? 0 : Convert.ToInt32(numDomicilioNumero.Text);
                cliente.Domicilio_Depto = txtDomiDepto.Text;
                cliente.Domicilio_Calle = txtDomiCalle.Text;
                cliente.Pais.Codigo = string.IsNullOrEmpty(cmbPais.SelectedValue.ToString()) ? 0 : Convert.ToInt32(cmbPais.SelectedValue);
                cliente.Mail = txtEmail.Text;
                cliente.Baja = chkBaja.Checked;

                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void GuardarCliente()
        {
            try
            {
                miClienteNegocio = new ClienteNegocio();
                cliente = ObtenerClienteFormulario();
                miClienteNegocio.GuardarCliente(cliente);
                MessageBox.Show("¡Se guardaron los datos correctamente!","Operación exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Padre.CargarGrilla();
                //Cierro el formulario actual.
                this.Dispose();
            }
            catch (SqlException  ex)
            {
                if (ex.Message.Contains("U_Cliente_Mail"))
                {
                   var result = MessageBox.Show("El mail ingresado ya se encuentra en uso, por favor intente con otro.", "Mail duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ex.Message.Contains("U_Documento"))
                {
                    var result = MessageBox.Show("La combinación tipo y numero de documento ingresada ya existe, por favor intente con otra.", "Tipo y numero de docuemnto existente", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show(MensajesError.ErrMensajeGuardarCliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MensajesError.ErrMensajeGuardarCliente);
            }
        }

        #endregion

        #region - Eventos -

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                GuardarCliente();
            }
        }

        #endregion

    }
}
