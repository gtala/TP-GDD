using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;
using PagoElectronico.Negocio.Clases;
using PagoElectronico.Util;

namespace PagoElectronico.ABM_Rol
{
    public partial class RolEdicion : FormulariosBase.FormularioEdicionBase
    {
        #region - Propiedades -

        private RolNegocio miRolNegocio;
        private Rol rol;
        public RolListado Padre;
        public Rol Rol
        {
            get
            {
                return rol;
            }
            set
            {
                rol = value;
            }
        }

        #endregion

        #region - Métodos -

        /// <summary>
        /// Constructor para el Alta.
        /// </summary>
        public RolEdicion()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        private void IniciarFormulario()
        {
            this.AutoValidate = AutoValidate.Disable;
            CargarCombos();
            ValidacionesIniciales();
            Util.ManejadorValidaciones util = new Util.ManejadorValidaciones(this.errProvider);
            util.CrearValidacionesTextBox(ref txtNombre, MensajesInfo.infoCampoRequerido.Replace("|@|", "Nombre"));
            util.CrearValidacionesCheckListBox(ref chkListaFuncionalidades, "Debe seleccionar al menos una Funcionalidad");
        }

        private void ValidacionesIniciales()
        {
            ////GDT: Me aseguro que no rompa la base.
            txtNombre.MaxLength = 255;
        }

        private void CargarCombos()
        {
            try
            {
                ManejadorCombos.CargarCheckListFuncionalidades(ref chkListaFuncionalidades);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Constructor usado cuando se realiza una edición.
        /// </summary>
        /// <param name="miRol"></param>
        public RolEdicion(Rol miRol)
        {
            InitializeComponent();
            IniciarFormulario();
            Rol = miRol;
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            try
            {
                txtNombre.Text = Rol.Nombre;
                chkInhabilitado.Checked = Rol.Estado;
                Funcionalidad miFuncionalidad;

                for (int i = 0; i < chkListaFuncionalidades.Items.Count; i++)
                {
                    miFuncionalidad = (Funcionalidad)chkListaFuncionalidades.Items[i];
                    bool estaEnLaColeccion = Rol.Funcionalidades.Exists(x => x.Codigo == miFuncionalidad.Codigo);
                    chkListaFuncionalidades.SetItemChecked(i, estaEnLaColeccion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Rol ObtenerRolFormulario()
        {
            try
            {
                //Si es un Alta
                if (rol == null)
                {
                    rol = new Rol();
                }
                rol.Nombre = txtNombre.Text;
                rol.Estado = chkInhabilitado.Checked;
                rol.Funcionalidades = new List<Funcionalidad>();
                foreach (Funcionalidad item in chkListaFuncionalidades.CheckedItems)
                {
                    rol.Funcionalidades.Add(item);
                }

                return rol;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void GuardarRol()
        {
            try
            {
                miRolNegocio = new RolNegocio();
                rol = ObtenerRolFormulario();
                miRolNegocio.GuardarRol(rol);
                MessageBox.Show("¡Se guardaron los datos correctamente!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Padre.CargarGrilla();
                //Cierro el formulario actual.
                this.Dispose();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("U_Rol_Nombre"))
                {
                    var result = MessageBox.Show("El Nombre ingresado ya se encuentra en uso, por favor intente con otro.", "Nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   // MessageBox.Show(MensajesError.ErrMensajeGuardarRol);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(MensajesError.ErrMensajeGuardarRol);
            }
        }

        #endregion

        #region - Eventos -

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                GuardarRol();
            }
        }

        #endregion

        private void chkSeleccionarTodas_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListaFuncionalidades.Items.Count; i++)
            {
                chkListaFuncionalidades.SetItemChecked(i, ((CheckBox)sender).Checked);
            }
        }

        private void chkListaFuncionalidades_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool todosChckeados = true;
            for (int i = 0; i < chkListaFuncionalidades.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    if (!chkListaFuncionalidades.GetItemChecked(i))
                    {
                        todosChckeados = false;
                        break;
                    }
                }
            }

            if (todosChckeados && e.NewValue == CheckState.Checked)
            {
                chkSeleccionarTodas.Checked = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
