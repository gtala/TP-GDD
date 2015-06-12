namespace PagoElectronico.ABM_Cuenta
{
    partial class CuentaListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentaListado));
            this.lblNroDocOrigen = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTipoDocOrigen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblApellidoOrigen = new System.Windows.Forms.Label();
            this.lblNombreOrigen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbEstados = new System.Windows.Forms.GroupBox();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.rbInhabilitada = new System.Windows.Forms.RadioButton();
            this.rbHabilitada = new System.Windows.Forms.RadioButton();
            this.rbCerrada = new System.Windows.Forms.RadioButton();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.gbFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEstados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.chkTodos);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.gbEstados);
            this.gbFiltros.Controls.Add(this.cmbTipoCuenta);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.cmbPais);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Location = new System.Drawing.Point(12, 51);
            this.gbFiltros.Size = new System.Drawing.Size(654, 108);
            this.gbFiltros.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbFiltros.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.gbFiltros.Controls.SetChildIndex(this.label2, 0);
            this.gbFiltros.Controls.SetChildIndex(this.cmbPais, 0);
            this.gbFiltros.Controls.SetChildIndex(this.label4, 0);
            this.gbFiltros.Controls.SetChildIndex(this.cmbTipoCuenta, 0);
            this.gbFiltros.Controls.SetChildIndex(this.gbEstados, 0);
            this.gbFiltros.Controls.SetChildIndex(this.label5, 0);
            this.gbFiltros.Controls.SetChildIndex(this.chkTodos, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(397, 72);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(523, 72);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(668, 123);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(672, 15);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(672, 51);
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(668, 123);
            // 
            // lblNroDocOrigen
            // 
            this.lblNroDocOrigen.AutoSize = true;
            this.lblNroDocOrigen.Location = new System.Drawing.Point(465, 21);
            this.lblNroDocOrigen.Name = "lblNroDocOrigen";
            this.lblNroDocOrigen.Size = new System.Drawing.Size(0, 13);
            this.lblNroDocOrigen.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(401, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nro Doc:";
            // 
            // lblTipoDocOrigen
            // 
            this.lblTipoDocOrigen.AutoSize = true;
            this.lblTipoDocOrigen.Location = new System.Drawing.Point(318, 21);
            this.lblTipoDocOrigen.Name = "lblTipoDocOrigen";
            this.lblTipoDocOrigen.Size = new System.Drawing.Size(0, 13);
            this.lblTipoDocOrigen.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(249, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tipo Doc:";
            // 
            // lblApellidoOrigen
            // 
            this.lblApellidoOrigen.AutoSize = true;
            this.lblApellidoOrigen.Location = new System.Drawing.Point(188, 21);
            this.lblApellidoOrigen.Name = "lblApellidoOrigen";
            this.lblApellidoOrigen.Size = new System.Drawing.Size(0, 13);
            this.lblApellidoOrigen.TabIndex = 11;
            // 
            // lblNombreOrigen
            // 
            this.lblNombreOrigen.AutoSize = true;
            this.lblNombreOrigen.Location = new System.Drawing.Point(66, 21);
            this.lblNombreOrigen.Name = "lblNombreOrigen";
            this.lblNombreOrigen.Size = new System.Drawing.Size(0, 13);
            this.lblNombreOrigen.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarClientes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblNroDocOrigen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblNombreOrigen);
            this.groupBox1.Controls.Add(this.lblTipoDocOrigen);
            this.groupBox1.Controls.Add(this.lblApellidoOrigen);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 48);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClientes.Image")));
            this.btnBuscarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarClientes.Location = new System.Drawing.Point(523, 12);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBuscarClientes.Size = new System.Drawing.Size(120, 30);
            this.btnBuscarClientes.TabIndex = 19;
            this.btnBuscarClientes.Text = "Buscar Cliente";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(55, 17);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(313, 21);
            this.cmbPais.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pais: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Estado:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbEstados
            // 
            this.gbEstados.Controls.Add(this.rbPendiente);
            this.gbEstados.Controls.Add(this.rbInhabilitada);
            this.gbEstados.Controls.Add(this.rbHabilitada);
            this.gbEstados.Controls.Add(this.rbCerrada);
            this.gbEstados.Enabled = false;
            this.gbEstados.Location = new System.Drawing.Point(54, 63);
            this.gbEstados.Name = "gbEstados";
            this.gbEstados.Size = new System.Drawing.Size(313, 37);
            this.gbEstados.TabIndex = 20;
            this.gbEstados.TabStop = false;
            this.gbEstados.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Checked = true;
            this.rbPendiente.Location = new System.Drawing.Point(7, 14);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(73, 17);
            this.rbPendiente.TabIndex = 19;
            this.rbPendiente.TabStop = true;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbInhabilitada
            // 
            this.rbInhabilitada.AutoSize = true;
            this.rbInhabilitada.Location = new System.Drawing.Point(160, 14);
            this.rbInhabilitada.Name = "rbInhabilitada";
            this.rbInhabilitada.Size = new System.Drawing.Size(79, 17);
            this.rbInhabilitada.TabIndex = 18;
            this.rbInhabilitada.Text = "Inhabilitada";
            this.rbInhabilitada.UseVisualStyleBackColor = true;
            // 
            // rbHabilitada
            // 
            this.rbHabilitada.AutoSize = true;
            this.rbHabilitada.Location = new System.Drawing.Point(82, 14);
            this.rbHabilitada.Name = "rbHabilitada";
            this.rbHabilitada.Size = new System.Drawing.Size(72, 17);
            this.rbHabilitada.TabIndex = 17;
            this.rbHabilitada.Text = "Habilitada";
            this.rbHabilitada.UseVisualStyleBackColor = true;
            // 
            // rbCerrada
            // 
            this.rbCerrada.AutoSize = true;
            this.rbCerrada.Location = new System.Drawing.Point(245, 14);
            this.rbCerrada.Name = "rbCerrada";
            this.rbCerrada.Size = new System.Drawing.Size(62, 17);
            this.rbCerrada.TabIndex = 16;
            this.rbCerrada.Text = "Cerrada";
            this.rbCerrada.UseVisualStyleBackColor = true;
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Location = new System.Drawing.Point(468, 17);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(173, 21);
            this.cmbTipoCuenta.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo cuenta: ";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Checked = true;
            this.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTodos.Location = new System.Drawing.Point(55, 45);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 22;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // CuentaListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.groupBox1);
            this.Name = "CuentaListado";
            this.Text = "CuentaListado";
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.gbFiltros, 0);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEstados.ResumeLayout(false);
            this.gbEstados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNroDocOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNombreOrigen;
        private System.Windows.Forms.Label lblTipoDocOrigen;
        private System.Windows.Forms.Label lblApellidoOrigen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbEstados;
        private System.Windows.Forms.RadioButton rbPendiente;
        private System.Windows.Forms.RadioButton rbInhabilitada;
        private System.Windows.Forms.RadioButton rbHabilitada;
        private System.Windows.Forms.RadioButton rbCerrada;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTodos;
    }
}