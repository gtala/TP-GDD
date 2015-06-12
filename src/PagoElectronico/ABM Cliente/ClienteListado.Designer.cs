namespace PagoElectronico.ABM_Cliente
{
    partial class ClienteListado
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
            this.cmbFiltroPais = new System.Windows.Forms.ComboBox();
            this.lblFiltroPais = new System.Windows.Forms.Label();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.lblFiltroApellido = new System.Windows.Forms.Label();
            this.txtFiltroApellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNoHabilitados = new System.Windows.Forms.RadioButton();
            this.rbHabilitados = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.numNroDocumento = new PagoElectronico.ControlesCustomizados.NumericTextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.gbFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lblFiltroNombre);
            this.gbFiltros.Controls.Add(this.txtFiltroNombre);
            this.gbFiltros.Controls.Add(this.lblFiltroApellido);
            this.gbFiltros.Controls.Add(this.numNroDocumento);
            this.gbFiltros.Controls.Add(this.txtFiltroApellido);
            this.gbFiltros.Controls.Add(this.lblDocumento);
            this.gbFiltros.Controls.Add(this.groupBox1);
            this.gbFiltros.Controls.Add(this.txtMail);
            this.gbFiltros.Controls.Add(this.cmbTipoDocumento);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.cmbFiltroPais);
            this.gbFiltros.Controls.Add(this.lblFiltroPais);
            this.gbFiltros.Size = new System.Drawing.Size(925, 150);
            this.gbFiltros.Controls.SetChildIndex(this.lblFiltroPais, 0);
            this.gbFiltros.Controls.SetChildIndex(this.cmbFiltroPais, 0);
            this.gbFiltros.Controls.SetChildIndex(this.label1, 0);
            this.gbFiltros.Controls.SetChildIndex(this.cmbTipoDocumento, 0);
            this.gbFiltros.Controls.SetChildIndex(this.txtMail, 0);
            this.gbFiltros.Controls.SetChildIndex(this.groupBox1, 0);
            this.gbFiltros.Controls.SetChildIndex(this.lblDocumento, 0);
            this.gbFiltros.Controls.SetChildIndex(this.txtFiltroApellido, 0);
            this.gbFiltros.Controls.SetChildIndex(this.numNroDocumento, 0);
            this.gbFiltros.Controls.SetChildIndex(this.lblFiltroApellido, 0);
            this.gbFiltros.Controls.SetChildIndex(this.txtFiltroNombre, 0);
            this.gbFiltros.Controls.SetChildIndex(this.lblFiltroNombre, 0);
            this.gbFiltros.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbFiltros.Controls.SetChildIndex(this.btnLimpiar, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(640, 111);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(766, 111);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cmbFiltroPais
            // 
            this.cmbFiltroPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroPais.FormattingEnabled = true;
            this.cmbFiltroPais.Location = new System.Drawing.Point(115, 98);
            this.cmbFiltroPais.Name = "cmbFiltroPais";
            this.cmbFiltroPais.Size = new System.Drawing.Size(300, 21);
            this.cmbFiltroPais.TabIndex = 13;
            // 
            // lblFiltroPais
            // 
            this.lblFiltroPais.AutoSize = true;
            this.lblFiltroPais.Location = new System.Drawing.Point(20, 98);
            this.lblFiltroPais.Name = "lblFiltroPais";
            this.lblFiltroPais.Size = new System.Drawing.Size(32, 13);
            this.lblFiltroPais.TabIndex = 3;
            this.lblFiltroPais.Text = "País:";
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Location = new System.Drawing.Point(20, 26);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(47, 13);
            this.lblFiltroNombre.TabIndex = 4;
            this.lblFiltroNombre.Text = "Nombre:";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(113, 22);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(300, 20);
            this.txtFiltroNombre.TabIndex = 3;
            // 
            // lblFiltroApellido
            // 
            this.lblFiltroApellido.AutoSize = true;
            this.lblFiltroApellido.Location = new System.Drawing.Point(517, 28);
            this.lblFiltroApellido.Name = "lblFiltroApellido";
            this.lblFiltroApellido.Size = new System.Drawing.Size(47, 13);
            this.lblFiltroApellido.TabIndex = 6;
            this.lblFiltroApellido.Text = "Apellido:";
            // 
            // txtFiltroApellido
            // 
            this.txtFiltroApellido.Location = new System.Drawing.Point(586, 24);
            this.txtFiltroApellido.Name = "txtFiltroApellido";
            this.txtFiltroApellido.Size = new System.Drawing.Size(300, 20);
            this.txtFiltroApellido.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNoHabilitados);
            this.groupBox1.Controls.Add(this.rbHabilitados);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(586, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 43);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbNoHabilitados
            // 
            this.rbNoHabilitados.AutoSize = true;
            this.rbNoHabilitados.Location = new System.Drawing.Point(180, 19);
            this.rbNoHabilitados.Name = "rbNoHabilitados";
            this.rbNoHabilitados.Size = new System.Drawing.Size(94, 17);
            this.rbNoHabilitados.TabIndex = 18;
            this.rbNoHabilitados.Text = "No Habilitados";
            this.rbNoHabilitados.UseVisualStyleBackColor = true;
            // 
            // rbHabilitados
            // 
            this.rbHabilitados.AutoSize = true;
            this.rbHabilitados.Location = new System.Drawing.Point(97, 19);
            this.rbHabilitados.Name = "rbHabilitados";
            this.rbHabilitados.Size = new System.Drawing.Size(77, 17);
            this.rbHabilitados.TabIndex = 17;
            this.rbHabilitados.Text = "Habilitados";
            this.rbHabilitados.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(36, 19);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 16;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(115, 71);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(300, 20);
            this.txtMail.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "E - mail:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(115, 45);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(123, 21);
            this.cmbTipoDocumento.TabIndex = 7;
            // 
            // numNroDocumento
            // 
            this.numNroDocumento.Location = new System.Drawing.Point(244, 45);
            this.numNroDocumento.Name = "numNroDocumento";
            this.numNroDocumento.Size = new System.Drawing.Size(171, 20);
            this.numNroDocumento.TabIndex = 9;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(20, 50);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 20;
            this.lblDocumento.Text = "Documento:";
            // 
            // ClienteListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1090, 469);
            this.Name = "ClienteListado";
            this.Text = "Listado de Clientes";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.Label lblFiltroPais;
        private System.Windows.Forms.ComboBox cmbFiltroPais;
        private System.Windows.Forms.Label lblFiltroApellido;
        private System.Windows.Forms.TextBox txtFiltroApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNoHabilitados;
        private System.Windows.Forms.RadioButton rbHabilitados;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblDocumento;
        private PagoElectronico.ControlesCustomizados.NumericTextBox numNroDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
    }
}