using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico
{
    public partial class Principal : Form
    {
        private Usuario usuarioActivo;
        public Usuario UsuarioActivo
        {
            get
            {
                return usuarioActivo;
            }
            set
            {
                usuarioActivo = value;
            }
        }


        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Form login, Usuario usuarioLogin)
        {
            InitializeComponent();
            login.Visible = false;
            usuarioActivo = usuarioLogin;

            foreach (ToolStripItem item in tsMenu.Items)
            {
                foreach (Funcionalidad funcionalidad in usuarioActivo.RolActivo.Funcionalidades)
                {
                    if (item.AccessibleName != null && (funcionalidad.Nombre.ToUpper().Trim() == item.AccessibleName.ToUpper().Trim()))
                    {
                        item.Visible = true;
                        break;
                    }

                    if (item.AccessibleName == "Seguridad" && (funcionalidad.Nombre == "ABM de Rol" || funcionalidad.Nombre == "ABM de Usuario"))
                    {
                        item.Visible = true;
                        break; 
                    }
                }
            }
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Transferencias.TransferenciaFormulario formTrans = new Transferencias.TransferenciaFormulario();
            formTrans.ShowDialog(this);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ABM_Cliente.ClienteListado formCliente = new ABM_Cliente.ClienteListado();
            formCliente.ShowDialog(this);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.UsuarioListado formUsuarios = new ABM_de_Usuario.UsuarioListado();
            formUsuarios.ShowDialog(this);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            ABM_Rol.RolListado formRoles = new ABM_Rol.RolListado();
            formRoles.ShowDialog(this);
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            ABM_Cuenta.CuentaListado formCuentas = new ABM_Cuenta.CuentaListado();
            formCuentas.ShowDialog(this);
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {

        }

        private void btnDepositos_Click(object sender, EventArgs e)
        {

        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.Show();
            this.Dispose();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
