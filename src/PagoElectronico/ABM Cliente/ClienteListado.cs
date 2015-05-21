using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.FormulariosBase;
using PagoElectronico.Negocio.Clases;

namespace PagoElectronico.ABM_Cliente
{
    partial class ClienteListado : FormularioListadoBase
    {
        private ClienteNegocio miClienteNegocio;
        private ClienteEdicion miClienteEdicion;

        #region - Métodos -

        public ClienteListado()
        {
            InitializeComponent();
        }

        private void BuscarClientes()
        {
            try
            {
                miClienteNegocio = new ClienteNegocio();
                List<Cliente> lstClientes = new List<Cliente>();
                lstClientes = miClienteNegocio.ObtenerClientes();
                dgListado.DataSource = lstClientes;
            }
            catch (Exception)
            {
                MessageBox.Show(MensajesError.ErrMensajeBusqueda);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                dgListado.DataSource = null;
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
                    miCliente = ObtenerClienteEdicion(miFilaSeleccionada);
                    miClienteEdicion = new ClienteEdicion(miCliente);
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

        private Cliente ObtenerClienteEdicion(DataGridViewRow miFilaSeleccionada)
        {
            try
            {
                Cliente miCliente = new Cliente();
                miCliente.Nombre =  Convert.ToString(miFilaSeleccionada.Cells["Nombre"].Value);
                miCliente.Apellido = Convert.ToString(miFilaSeleccionada.Cells["Apellido"].Value);
                miCliente.Tipo_Doc_Codigo = Convert.ToInt32(miFilaSeleccionada.Cells["Tipo_Doc_Codigo"].Value);
                miCliente.Tipo_Doc_Desc = Convert.ToString(miFilaSeleccionada.Cells["Tipo_Doc_Desc"].Value);
                miCliente.Tipo_Doc_Codigo = Convert.ToInt32(miFilaSeleccionada.Cells["Tipo_Doc_Codigo"].Value);
                miCliente.Nro_Documento = Convert.ToInt32(miFilaSeleccionada.Cells["Nro_Documento"].Value);
                //miCliente.Pais.Pais_Codigo = Convert.ToString(miFilaSeleccionada.Cells["Pais_Codigo"].Value);
                //miCliente.Pais.Pais_Descipcion = Convert.ToString(miFilaSeleccionada.Cells["Pais_Descipcion"].Value);
                miCliente.Fecha_Nacimiento = Convert.ToDateTime(miFilaSeleccionada.Cells["Fecha_Nacimiento"].Value);
                miCliente.Mail = Convert.ToString(miFilaSeleccionada.Cells["Mail"].Value);
                miCliente.Domicilio_Calle = Convert.ToString(miFilaSeleccionada.Cells["Domicilio_Calle"].Value);
                miCliente.Domicilio_Depto = Convert.ToString(miFilaSeleccionada.Cells["Domicilio_Depto"].Value);
                miCliente.Domicilio_Nro = Convert.ToInt32(miFilaSeleccionada.Cells["Domicilio_Nro"].Value);
                miCliente.Domicilio_Piso = Convert.ToInt32(miFilaSeleccionada.Cells["Domicilio_Piso"].Value);

                return miCliente;
            }
            catch (Exception ex)
            {
                throw ex;
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

        }

        #endregion
    }
}
