namespace PagoElectronico.ABM_Rol
{
    partial class RolEdicion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkListaFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.chkSeleccionarTodas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkInhabilitado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gcAccion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gcAccion
            // 
            this.gcAccion.Location = new System.Drawing.Point(12, 275);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkListaFuncionalidades);
            this.groupBox1.Controls.Add(this.chkSeleccionarTodas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.chkInhabilitado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 257);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chkListaFuncionalidades
            // 
            this.chkListaFuncionalidades.FormattingEnabled = true;
            this.chkListaFuncionalidades.Location = new System.Drawing.Point(135, 69);
            this.chkListaFuncionalidades.Name = "chkListaFuncionalidades";
            this.chkListaFuncionalidades.Size = new System.Drawing.Size(350, 154);
            this.chkListaFuncionalidades.TabIndex = 6;
            this.chkListaFuncionalidades.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListaFuncionalidades_ItemCheck);
            // 
            // chkSeleccionarTodas
            // 
            this.chkSeleccionarTodas.AutoSize = true;
            this.chkSeleccionarTodas.Location = new System.Drawing.Point(135, 45);
            this.chkSeleccionarTodas.Name = "chkSeleccionarTodas";
            this.chkSeleccionarTodas.Size = new System.Drawing.Size(111, 17);
            this.chkSeleccionarTodas.TabIndex = 5;
            this.chkSeleccionarTodas.Text = "Seleccionar todas";
            this.chkSeleccionarTodas.UseVisualStyleBackColor = true;
            this.chkSeleccionarTodas.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Funcionalidades:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(350, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // chkInhabilitado
            // 
            this.chkInhabilitado.AutoSize = true;
            this.chkInhabilitado.Location = new System.Drawing.Point(135, 228);
            this.chkInhabilitado.Name = "chkInhabilitado";
            this.chkInhabilitado.Size = new System.Drawing.Size(80, 17);
            this.chkInhabilitado.TabIndex = 2;
            this.chkInhabilitado.Text = "Inhabilitado";
            this.chkInhabilitado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre: ";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // RolEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 345);
            this.Controls.Add(this.groupBox1);
            this.Name = "RolEdicion";
            this.Text = "RolEdicion";
            this.Controls.SetChildIndex(this.gcAccion, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.gcAccion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkInhabilitado;
        private System.Windows.Forms.CheckBox chkSeleccionarTodas;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.CheckedListBox chkListaFuncionalidades;
    }
}