namespace PagoElectronico.ABM_Cuenta
{
    partial class CuentaEdicion
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
            this.txtNumeroCuenta = new PagoElectronico.ControlesCustomizados.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.rbInhabilitada = new System.Windows.Forms.RadioButton();
            this.rbHabilitada = new System.Windows.Forms.RadioButton();
            this.rbCerrada = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gcAccion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(353, 47);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(247, 47);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gcAccion
            // 
            this.gcAccion.Controls.Add(this.lblFechaCierre);
            this.gcAccion.Controls.Add(this.lblFechaCreacion);
            this.gcAccion.Controls.Add(this.label7);
            this.gcAccion.Controls.Add(this.label6);
            this.gcAccion.Location = new System.Drawing.Point(24, 199);
            this.gcAccion.Size = new System.Drawing.Size(466, 83);
            this.gcAccion.Controls.SetChildIndex(this.btnGuardar, 0);
            this.gcAccion.Controls.SetChildIndex(this.btnCancelar, 0);
            this.gcAccion.Controls.SetChildIndex(this.label6, 0);
            this.gcAccion.Controls.SetChildIndex(this.label7, 0);
            this.gcAccion.Controls.SetChildIndex(this.lblFechaCreacion, 0);
            this.gcAccion.Controls.SetChildIndex(this.lblFechaCierre, 0);
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(102, 22);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(342, 20);
            this.txtNumeroCuenta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pais: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Moneda: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo cuenta: ";
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(102, 48);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(342, 21);
            this.cmbPais.TabIndex = 10;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(102, 75);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(342, 21);
            this.cmbMoneda.TabIndex = 11;
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Location = new System.Drawing.Point(102, 102);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(342, 21);
            this.cmbTipoCuenta.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNumeroCuenta);
            this.groupBox1.Controls.Add(this.cmbTipoCuenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMoneda);
            this.groupBox1.Controls.Add(this.cmbPais);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 181);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estado:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPendiente);
            this.groupBox2.Controls.Add(this.rbInhabilitada);
            this.groupBox2.Controls.Add(this.rbHabilitada);
            this.groupBox2.Controls.Add(this.rbCerrada);
            this.groupBox2.Location = new System.Drawing.Point(102, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 43);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Location = new System.Drawing.Point(14, 19);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(73, 17);
            this.rbPendiente.TabIndex = 19;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbInhabilitada
            // 
            this.rbInhabilitada.AutoSize = true;
            this.rbInhabilitada.Location = new System.Drawing.Point(187, 20);
            this.rbInhabilitada.Name = "rbInhabilitada";
            this.rbInhabilitada.Size = new System.Drawing.Size(79, 17);
            this.rbInhabilitada.TabIndex = 18;
            this.rbInhabilitada.Text = "Inhabilitada";
            this.rbInhabilitada.UseVisualStyleBackColor = true;
            // 
            // rbHabilitada
            // 
            this.rbHabilitada.AutoSize = true;
            this.rbHabilitada.Location = new System.Drawing.Point(93, 20);
            this.rbHabilitada.Name = "rbHabilitada";
            this.rbHabilitada.Size = new System.Drawing.Size(72, 17);
            this.rbHabilitada.TabIndex = 17;
            this.rbHabilitada.Text = "Habilitada";
            this.rbHabilitada.UseVisualStyleBackColor = true;
            // 
            // rbCerrada
            // 
            this.rbCerrada.AutoSize = true;
            this.rbCerrada.Checked = true;
            this.rbCerrada.Location = new System.Drawing.Point(280, 20);
            this.rbCerrada.Name = "rbCerrada";
            this.rbCerrada.Size = new System.Drawing.Size(62, 17);
            this.rbCerrada.TabIndex = 16;
            this.rbCerrada.TabStop = true;
            this.rbCerrada.Text = "Cerrada";
            this.rbCerrada.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha Creación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha Cerrada: ";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(110, 26);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(0, 13);
            this.lblFechaCreacion.TabIndex = 6;
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Location = new System.Drawing.Point(111, 55);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(0, 13);
            this.lblFechaCierre.TabIndex = 7;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // CuentaEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 299);
            this.Controls.Add(this.groupBox1);
            this.Name = "CuentaEdicion";
            this.Text = "CuentaEdicion";
            this.Controls.SetChildIndex(this.gcAccion, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.gcAccion.ResumeLayout(false);
            this.gcAccion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PagoElectronico.ControlesCustomizados.NumericTextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbInhabilitada;
        private System.Windows.Forms.RadioButton rbHabilitada;
        private System.Windows.Forms.RadioButton rbCerrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.RadioButton rbPendiente;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}