namespace PagoElectronico
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnSeguridad = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnCuentas = new System.Windows.Forms.ToolStripButton();
            this.btnTransferencias = new System.Windows.Forms.ToolStripButton();
            this.btnTarjetas = new System.Windows.Forms.ToolStripButton();
            this.btnDepositos = new System.Windows.Forms.ToolStripButton();
            this.btnRetiro = new System.Windows.Forms.ToolStripButton();
            this.btnFacturacion = new System.Windows.Forms.ToolStripButton();
            this.btnSaldo = new System.Windows.Forms.ToolStripButton();
            this.btnEstadisticas = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSeguridad,
            this.btnClientes,
            this.btnCuentas,
            this.btnTransferencias,
            this.btnTarjetas,
            this.btnDepositos,
            this.btnRetiro,
            this.btnFacturacion,
            this.btnSaldo,
            this.btnEstadisticas,
            this.btnSalir});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1243, 55);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "Menú";
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.AccessibleName = "Seguridad";
            this.btnSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnRoles});
            this.btnSeguridad.Image = ((System.Drawing.Image)(resources.GetObject("btnSeguridad.Image")));
            this.btnSeguridad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(121, 52);
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.Visible = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AccessibleName = "ABM de Usuario";
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(184, 54);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.AccessibleName = "ABM de Rol";
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(184, 54);
            this.btnRoles.Text = "Roles";
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AccessibleName = "ABM de Cliente";
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(101, 52);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.AccessibleName = "ABM de Cuenta";
            this.btnCuentas.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentas.Image")));
            this.btnCuentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(102, 52);
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.Visible = false;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.AccessibleName = "Transferencias entre cuentas";
            this.btnTransferencias.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferencias.Image")));
            this.btnTransferencias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(135, 52);
            this.btnTransferencias.Text = "Transferencias";
            this.btnTransferencias.Visible = false;
            this.btnTransferencias.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.Image = ((System.Drawing.Image)(resources.GetObject("btnTarjetas.Image")));
            this.btnTarjetas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(100, 52);
            this.btnTarjetas.Text = "Tarjetas";
            this.btnTarjetas.Visible = false;
            this.btnTarjetas.Click += new System.EventHandler(this.btnTarjetas_Click);
            // 
            // btnDepositos
            // 
            this.btnDepositos.AccessibleName = "Depósitos";
            this.btnDepositos.Image = ((System.Drawing.Image)(resources.GetObject("btnDepositos.Image")));
            this.btnDepositos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(111, 52);
            this.btnDepositos.Text = "Depositos";
            this.btnDepositos.Visible = false;
            this.btnDepositos.Click += new System.EventHandler(this.btnDepositos_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.AccessibleName = "Retiro de Efectivo";
            this.btnRetiro.Image = ((System.Drawing.Image)(resources.GetObject("btnRetiro.Image")));
            this.btnRetiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(90, 52);
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.Visible = false;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.AccessibleName = "Facturación de Costos";
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(121, 52);
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.Visible = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.AccessibleName = "Consulta de saldos";
            this.btnSaldo.Image = ((System.Drawing.Image)(resources.GetObject("btnSaldo.Image")));
            this.btnSaldo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(88, 52);
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.Visible = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.AccessibleName = "Listado Estadístico";
            this.btnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.Image")));
            this.btnEstadisticas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(119, 52);
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.Visible = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 52);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1243, 300);
            this.Controls.Add(this.tsMenu);
            this.Name = "Principal";
            this.Text = "Pago Electronico";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnTransferencias;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripButton btnCuentas;
        private System.Windows.Forms.ToolStripButton btnTarjetas;
        private System.Windows.Forms.ToolStripDropDownButton btnSeguridad;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnRoles;
        private System.Windows.Forms.ToolStripButton btnDepositos;
        private System.Windows.Forms.ToolStripButton btnRetiro;
        private System.Windows.Forms.ToolStripButton btnFacturacion;
        private System.Windows.Forms.ToolStripButton btnSaldo;
        private System.Windows.Forms.ToolStripButton btnEstadisticas;
        private System.Windows.Forms.ToolStripButton btnSalir;

    }
}

