namespace PagoElectronico.ABM_Cliente
{
    partial class ClienteEdicion
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
            this.components = new System.ComponentModel.Container();
            this.gbDomicilio = new System.Windows.Forms.GroupBox();
            this.numDomicilioNumero = new PagoElectronico.ControlesCustomizados.NumericTextBox();
            this.numDomicilioPiso = new PagoElectronico.ControlesCustomizados.NumericTextBox();
            this.txtDomiDepto = new System.Windows.Forms.TextBox();
            this.txtDomiCalle = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.numDocumento = new PagoElectronico.ControlesCustomizados.NumericTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gcAccion.SuspendLayout();
            this.gbDomicilio.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gcAccion
            // 
            this.gcAccion.Location = new System.Drawing.Point(12, 326);
            this.gcAccion.TabIndex = 13;
            // 
            // gbDomicilio
            // 
            this.gbDomicilio.Controls.Add(this.numDomicilioNumero);
            this.gbDomicilio.Controls.Add(this.numDomicilioPiso);
            this.gbDomicilio.Controls.Add(this.txtDomiDepto);
            this.gbDomicilio.Controls.Add(this.txtDomiCalle);
            this.gbDomicilio.Controls.Add(this.lblPiso);
            this.gbDomicilio.Controls.Add(this.lblDepartamento);
            this.gbDomicilio.Controls.Add(this.lblNumero);
            this.gbDomicilio.Controls.Add(this.lblCalle);
            this.gbDomicilio.Location = new System.Drawing.Point(12, 224);
            this.gbDomicilio.Name = "gbDomicilio";
            this.gbDomicilio.Size = new System.Drawing.Size(510, 96);
            this.gbDomicilio.TabIndex = 9;
            this.gbDomicilio.TabStop = false;
            this.gbDomicilio.Text = "Domicilio";
            // 
            // numDomicilioNumero
            // 
            this.numDomicilioNumero.Location = new System.Drawing.Point(336, 27);
            this.numDomicilioNumero.Name = "numDomicilioNumero";
            this.numDomicilioNumero.Size = new System.Drawing.Size(142, 20);
            this.numDomicilioNumero.TabIndex = 11;
            // 
            // numDomicilioPiso
            // 
            this.numDomicilioPiso.Location = new System.Drawing.Point(336, 53);
            this.numDomicilioPiso.Name = "numDomicilioPiso";
            this.numDomicilioPiso.Size = new System.Drawing.Size(142, 20);
            this.numDomicilioPiso.TabIndex = 13;
            // 
            // txtDomiDepto
            // 
            this.txtDomiDepto.Location = new System.Drawing.Point(111, 53);
            this.txtDomiDepto.Name = "txtDomiDepto";
            this.txtDomiDepto.Size = new System.Drawing.Size(142, 20);
            this.txtDomiDepto.TabIndex = 12;
            // 
            // txtDomiCalle
            // 
            this.txtDomiCalle.Location = new System.Drawing.Point(111, 27);
            this.txtDomiCalle.Name = "txtDomiCalle";
            this.txtDomiCalle.Size = new System.Drawing.Size(142, 20);
            this.txtDomiCalle.TabIndex = 10;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(271, 56);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 3;
            this.lblPiso.Text = "Piso:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(12, 56);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 2;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(271, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(12, 30);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 42);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(373, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 39);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(373, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(12, 151);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(94, 13);
            this.lblFechaNac.TabIndex = 5;
            this.lblFechaNac.Text = "Fecha nacimiento:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(112, 145);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(199, 20);
            this.dtpFechaNac.TabIndex = 6;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(12, 68);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(52, 13);
            this.lblTipoDoc.TabIndex = 7;
            this.lblTipoDoc.Text = "Tipo doc:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(113, 65);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(140, 21);
            this.cmbTipoDoc.TabIndex = 3;
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Location = new System.Drawing.Point(12, 95);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroDoc.TabIndex = 9;
            this.lblNumeroDoc.Text = "Nro documento:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 121);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 11;
            this.lblPais.Text = "País:";
            // 
            // cmbPais
            // 
            this.cmbPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(112, 118);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(199, 21);
            this.cmbPais.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 174);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "E - mail: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(111, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.chkBaja);
            this.gbDatosCliente.Controls.Add(this.numDocumento);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Controls.Add(this.txtNombre);
            this.gbDatosCliente.Controls.Add(this.lblFechaNac);
            this.gbDatosCliente.Controls.Add(this.lblApellido);
            this.gbDatosCliente.Controls.Add(this.cmbPais);
            this.gbDatosCliente.Controls.Add(this.lblTipoDoc);
            this.gbDatosCliente.Controls.Add(this.txtEmail);
            this.gbDatosCliente.Controls.Add(this.lblMail);
            this.gbDatosCliente.Controls.Add(this.cmbTipoDoc);
            this.gbDatosCliente.Controls.Add(this.dtpFechaNac);
            this.gbDatosCliente.Controls.Add(this.txtApellido);
            this.gbDatosCliente.Controls.Add(this.lblPais);
            this.gbDatosCliente.Controls.Add(this.lblNumeroDoc);
            this.gbDatosCliente.Location = new System.Drawing.Point(12, 12);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(510, 206);
            this.gbDatosCliente.TabIndex = 0;
            this.gbDatosCliente.TabStop = false;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.Location = new System.Drawing.Point(336, 174);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(47, 17);
            this.chkBaja.TabIndex = 8;
            this.chkBaja.Text = "Baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // numDocumento
            // 
            this.numDocumento.Location = new System.Drawing.Point(113, 92);
            this.numDocumento.Name = "numDocumento";
            this.numDocumento.Size = new System.Drawing.Size(198, 20);
            this.numDocumento.TabIndex = 4;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ClienteEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbDomicilio);
            this.Name = "ClienteEdicion";
            this.Text = "Edición de Cliente";
            this.Controls.SetChildIndex(this.gbDomicilio, 0);
            this.Controls.SetChildIndex(this.gcAccion, 0);
            this.Controls.SetChildIndex(this.gbDatosCliente, 0);
            this.gcAccion.ResumeLayout(false);
            this.gbDomicilio.ResumeLayout(false);
            this.gbDomicilio.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDomicilio;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtDomiDepto;
        private System.Windows.Forms.TextBox txtDomiCalle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private PagoElectronico.ControlesCustomizados.NumericTextBox numDocumento;
        private PagoElectronico.ControlesCustomizados.NumericTextBox numDomicilioPiso;
        private PagoElectronico.ControlesCustomizados.NumericTextBox numDomicilioNumero;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}