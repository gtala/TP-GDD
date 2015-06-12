namespace PagoElectronico.Transferencias
{
    partial class Transferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transferencias));
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.ucGrillaDestino = new PagoElectronico.ControlesCustomizados.ucGrilla();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOrigen = new System.Windows.Forms.GroupBox();
            this.ucGrillaOrigen = new PagoElectronico.ControlesCustomizados.ucGrilla();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.txtImporte = new PagoElectronico.ControlesCustomizados.NumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbOtra = new System.Windows.Forms.RadioButton();
            this.rbPropia = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblNroDocOrigen = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTipoDocOrigen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblApellidoOrigen = new System.Windows.Forms.Label();
            this.lblNombreOrigen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblNroDocDestino = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTipoDocDestino = new System.Windows.Forms.Label();
            this.lblNombreDestino = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblApellidoDestino = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDestino.SuspendLayout();
            this.gbOrigen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.ucGrillaDestino);
            this.gbDestino.Controls.Add(this.label2);
            this.gbDestino.Location = new System.Drawing.Point(578, 165);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(560, 240);
            this.gbDestino.TabIndex = 0;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Cuenta Destino";
            // 
            // ucGrillaDestino
            // 
            this.ucGrillaDestino.Location = new System.Drawing.Point(6, 44);
            this.ucGrillaDestino.Name = "ucGrillaDestino";
            this.ucGrillaDestino.Size = new System.Drawing.Size(550, 190);
            this.ucGrillaDestino.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la cuenta de crédito:";
            // 
            // gbOrigen
            // 
            this.gbOrigen.Controls.Add(this.ucGrillaOrigen);
            this.gbOrigen.Controls.Add(this.label1);
            this.gbOrigen.Location = new System.Drawing.Point(12, 165);
            this.gbOrigen.Name = "gbOrigen";
            this.gbOrigen.Size = new System.Drawing.Size(560, 240);
            this.gbOrigen.TabIndex = 1;
            this.gbOrigen.TabStop = false;
            this.gbOrigen.Text = "Cuenta Origen";
            // 
            // ucGrillaOrigen
            // 
            this.ucGrillaOrigen.Location = new System.Drawing.Point(6, 44);
            this.ucGrillaOrigen.Name = "ucGrillaOrigen";
            this.ucGrillaOrigen.Size = new System.Drawing.Size(550, 190);
            this.ucGrillaOrigen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la cuenta de débito:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransferir);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de la operación";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(569, 26);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(154, 36);
            this.btnTransferir.TabIndex = 2;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(135, 35);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(406, 20);
            this.txtImporte.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Importe a transferir:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnBuscarClientes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de transferencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo cuenta destino:";
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClientes.Image")));
            this.btnBuscarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarClientes.Location = new System.Drawing.Point(569, 14);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBuscarClientes.Size = new System.Drawing.Size(154, 38);
            this.btnBuscarClientes.TabIndex = 18;
            this.btnBuscarClientes.Text = "Buscar Cliente";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Visible = false;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOtra);
            this.groupBox3.Controls.Add(this.rbPropia);
            this.groupBox3.Location = new System.Drawing.Point(132, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 43);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // rbOtra
            // 
            this.rbOtra.AutoSize = true;
            this.rbOtra.Location = new System.Drawing.Point(150, 19);
            this.rbOtra.Name = "rbOtra";
            this.rbOtra.Size = new System.Drawing.Size(129, 17);
            this.rbOtra.TabIndex = 17;
            this.rbOtra.Text = "Otra Cuenta no propia";
            this.rbOtra.UseVisualStyleBackColor = true;
            this.rbOtra.CheckedChanged += new System.EventHandler(this.rbOtra_CheckedChanged);
            // 
            // rbPropia
            // 
            this.rbPropia.AutoSize = true;
            this.rbPropia.Checked = true;
            this.rbPropia.Location = new System.Drawing.Point(36, 19);
            this.rbPropia.Name = "rbPropia";
            this.rbPropia.Size = new System.Drawing.Size(92, 17);
            this.rbPropia.TabIndex = 16;
            this.rbPropia.TabStop = true;
            this.rbPropia.Text = "Cuenta Propia";
            this.rbPropia.UseVisualStyleBackColor = true;
            this.rbPropia.CheckedChanged += new System.EventHandler(this.rbPropia_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblNroDocOrigen);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblTipoDocOrigen);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lblApellidoOrigen);
            this.groupBox4.Controls.Add(this.lblNombreOrigen);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(560, 80);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Cliente Origen";
            // 
            // lblNroDocOrigen
            // 
            this.lblNroDocOrigen.AutoSize = true;
            this.lblNroDocOrigen.Location = new System.Drawing.Point(429, 46);
            this.lblNroDocOrigen.Name = "lblNroDocOrigen";
            this.lblNroDocOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblNroDocOrigen.TabIndex = 7;
            this.lblNroDocOrigen.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(279, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nro Documento:";
            // 
            // lblTipoDocOrigen
            // 
            this.lblTipoDocOrigen.AutoSize = true;
            this.lblTipoDocOrigen.Location = new System.Drawing.Point(429, 20);
            this.lblTipoDocOrigen.Name = "lblTipoDocOrigen";
            this.lblTipoDocOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblTipoDocOrigen.TabIndex = 5;
            this.lblTipoDocOrigen.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(279, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tipo Documento:";
            // 
            // lblApellidoOrigen
            // 
            this.lblApellidoOrigen.AutoSize = true;
            this.lblApellidoOrigen.Location = new System.Drawing.Point(104, 46);
            this.lblApellidoOrigen.Name = "lblApellidoOrigen";
            this.lblApellidoOrigen.Size = new System.Drawing.Size(35, 13);
            this.lblApellidoOrigen.TabIndex = 3;
            this.lblApellidoOrigen.Text = "label9";
            // 
            // lblNombreOrigen
            // 
            this.lblNombreOrigen.AutoSize = true;
            this.lblNombreOrigen.Location = new System.Drawing.Point(104, 20);
            this.lblNombreOrigen.Name = "lblNombreOrigen";
            this.lblNombreOrigen.Size = new System.Drawing.Size(35, 13);
            this.lblNombreOrigen.TabIndex = 2;
            this.lblNombreOrigen.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblNroDocDestino);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.lblTipoDocDestino);
            this.groupBox5.Controls.Add(this.lblNombreDestino);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lblApellidoDestino);
            this.groupBox5.Location = new System.Drawing.Point(578, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(560, 80);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos Cliente Destino";
            // 
            // lblNroDocDestino
            // 
            this.lblNroDocDestino.AutoSize = true;
            this.lblNroDocDestino.Location = new System.Drawing.Point(423, 46);
            this.lblNroDocDestino.Name = "lblNroDocDestino";
            this.lblNroDocDestino.Size = new System.Drawing.Size(41, 13);
            this.lblNroDocDestino.TabIndex = 15;
            this.lblNroDocDestino.Text = "label13";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(273, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nro Documento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Apellido:";
            // 
            // lblTipoDocDestino
            // 
            this.lblTipoDocDestino.AutoSize = true;
            this.lblTipoDocDestino.Location = new System.Drawing.Point(423, 20);
            this.lblTipoDocDestino.Name = "lblTipoDocDestino";
            this.lblTipoDocDestino.Size = new System.Drawing.Size(41, 13);
            this.lblTipoDocDestino.TabIndex = 13;
            this.lblTipoDocDestino.Text = "label11";
            // 
            // lblNombreDestino
            // 
            this.lblNombreDestino.AutoSize = true;
            this.lblNombreDestino.Location = new System.Drawing.Point(98, 20);
            this.lblNombreDestino.Name = "lblNombreDestino";
            this.lblNombreDestino.Size = new System.Drawing.Size(35, 13);
            this.lblNombreDestino.TabIndex = 10;
            this.lblNombreDestino.Text = "label8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(273, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tipo Documento:";
            // 
            // lblApellidoDestino
            // 
            this.lblApellidoDestino.AutoSize = true;
            this.lblApellidoDestino.Location = new System.Drawing.Point(98, 46);
            this.lblApellidoDestino.Name = "lblApellidoDestino";
            this.lblApellidoDestino.Size = new System.Drawing.Size(35, 13);
            this.lblApellidoDestino.TabIndex = 11;
            this.lblApellidoDestino.Text = "label9";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Transferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 493);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOrigen);
            this.Controls.Add(this.gbDestino);
            this.Name = "Transferencias";
            this.Text = "Transferencias";
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.gbOrigen.ResumeLayout(false);
            this.gbOrigen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.GroupBox gbOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransferir;
        private PagoElectronico.ControlesCustomizados.NumericTextBox txtImporte;
        private PagoElectronico.ControlesCustomizados.ucGrilla ucGrillaOrigen;
        private PagoElectronico.ControlesCustomizados.ucGrilla ucGrillaDestino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbOtra;
        private System.Windows.Forms.RadioButton rbPropia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblNroDocOrigen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTipoDocOrigen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblApellidoOrigen;
        private System.Windows.Forms.Label lblNombreOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNroDocDestino;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTipoDocDestino;
        private System.Windows.Forms.Label lblNombreDestino;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblApellidoDestino;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}