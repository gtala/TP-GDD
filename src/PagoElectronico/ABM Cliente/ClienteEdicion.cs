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

namespace PagoElectronico.ABM_Cliente
{
    public partial class ClienteEdicion : Form
    {
        #region - Propiedades -
        private List<Pais> lstPaises;
        private Cliente cliente;
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

        /// <summary>
        /// Constructor para el Alta.
        /// </summary>
        public ClienteEdicion()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            //Carga del combo País
            cmbPais.DisplayMember = "Pais_Descipcion";
            cmbPais.ValueMember = "Pais_Codigo";

            PaisNegocio miPaisNegocio = new PaisNegocio();
            lstPaises = miPaisNegocio.ObtenerPaises();
            cmbPais.DataSource = lstPaises;
        }

        /// <summary>
        /// Constructor usado cuando se realiza una edición.
        /// </summary>
        /// <param name="miCliente"></param>
        public ClienteEdicion(Cliente miCliente)
        {
            InitializeComponent();
            Cliente = miCliente;
            CargarCombos();
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            try
            {
                txtNombre.Text = Cliente.Nombre;
                txtApellido.Text = Cliente.Apellido;
                txtNumeroDoc.Text = Convert.ToString(Cliente.Nro_Documento);
                dtpFechaNac.Value = Cliente.Fecha_Nacimiento;
                txtEmail.Text = Cliente.Mail;
                txtDomiCalle.Text = Cliente.Domicilio_Calle;
                txtDomiDepto.Text = Cliente.Domicilio_Depto;
                txtDomiNumero.Text = Convert.ToString(Cliente.Domicilio_Nro);
                txtDomiPiso.Text = Convert.ToString(Cliente.Domicilio_Piso);
               // cmbPais.ValueMember = Cliente.Pais.Pais_Codigo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
