namespace frbapagoelectronico.ABM_Rol
{
    partial class frminsertrol
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
            this.lblnombrerol = new System.Windows.Forms.Label();
            this.txtnombrerol = new System.Windows.Forms.TextBox();
            this.dgvfuncionalidades = new System.Windows.Forms.DataGridView();
            this.btnguardarrol = new System.Windows.Forms.Button();
            this.lblidrol = new System.Windows.Forms.Label();
            this.txtidrol = new System.Windows.Forms.TextBox();
            this.lblfuncionalidades = new System.Windows.Forms.Label();
            this.checkBoxhabilitado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombrerol
            // 
            this.lblnombrerol.AutoSize = true;
            this.lblnombrerol.Location = new System.Drawing.Point(251, 25);
            this.lblnombrerol.Name = "lblnombrerol";
            this.lblnombrerol.Size = new System.Drawing.Size(71, 13);
            this.lblnombrerol.TabIndex = 0;
            this.lblnombrerol.Text = "nombre de rol";
            // 
            // txtnombrerol
            // 
            this.txtnombrerol.Location = new System.Drawing.Point(346, 22);
            this.txtnombrerol.Name = "txtnombrerol";
            this.txtnombrerol.Size = new System.Drawing.Size(110, 20);
            this.txtnombrerol.TabIndex = 1;
            // 
            // dgvfuncionalidades
            // 
            this.dgvfuncionalidades.AllowUserToAddRows = false;
            this.dgvfuncionalidades.AllowUserToDeleteRows = false;
            this.dgvfuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionalidades.Location = new System.Drawing.Point(53, 119);
            this.dgvfuncionalidades.Name = "dgvfuncionalidades";
            this.dgvfuncionalidades.Size = new System.Drawing.Size(334, 266);
            this.dgvfuncionalidades.TabIndex = 2;
            // 
            // btnguardarrol
            // 
            this.btnguardarrol.Location = new System.Drawing.Point(359, 63);
            this.btnguardarrol.Name = "btnguardarrol";
            this.btnguardarrol.Size = new System.Drawing.Size(97, 28);
            this.btnguardarrol.TabIndex = 3;
            this.btnguardarrol.Text = "guardar rol";
            this.btnguardarrol.UseVisualStyleBackColor = true;
            this.btnguardarrol.Click += new System.EventHandler(this.btnguardarrol_Click);
            // 
            // lblidrol
            // 
            this.lblidrol.AutoSize = true;
            this.lblidrol.Location = new System.Drawing.Point(54, 23);
            this.lblidrol.Name = "lblidrol";
            this.lblidrol.Size = new System.Drawing.Size(44, 13);
            this.lblidrol.TabIndex = 4;
            this.lblidrol.Text = "id de rol";
            // 
            // txtidrol
            // 
            this.txtidrol.Location = new System.Drawing.Point(116, 22);
            this.txtidrol.Name = "txtidrol";
            this.txtidrol.Size = new System.Drawing.Size(110, 20);
            this.txtidrol.TabIndex = 5;
            // 
            // lblfuncionalidades
            // 
            this.lblfuncionalidades.AutoSize = true;
            this.lblfuncionalidades.Location = new System.Drawing.Point(54, 71);
            this.lblfuncionalidades.Name = "lblfuncionalidades";
            this.lblfuncionalidades.Size = new System.Drawing.Size(81, 13);
            this.lblfuncionalidades.TabIndex = 6;
            this.lblfuncionalidades.Text = "funcionalidades";
            // 
            // checkBoxhabilitado
            // 
            this.checkBoxhabilitado.AutoSize = true;
            this.checkBoxhabilitado.Location = new System.Drawing.Point(53, 96);
            this.checkBoxhabilitado.Name = "checkBoxhabilitado";
            this.checkBoxhabilitado.Size = new System.Drawing.Size(71, 17);
            this.checkBoxhabilitado.TabIndex = 7;
            this.checkBoxhabilitado.Text = "habilitado";
            this.checkBoxhabilitado.UseVisualStyleBackColor = true;
            // 
            // frminsertrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 410);
            this.Controls.Add(this.checkBoxhabilitado);
            this.Controls.Add(this.lblfuncionalidades);
            this.Controls.Add(this.txtidrol);
            this.Controls.Add(this.lblidrol);
            this.Controls.Add(this.btnguardarrol);
            this.Controls.Add(this.dgvfuncionalidades);
            this.Controls.Add(this.txtnombrerol);
            this.Controls.Add(this.lblnombrerol);
            this.Name = "frminsertrol";
            this.Text = "insertar rol";
            this.Load += new System.EventHandler(this.frminsertrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombrerol;
        private System.Windows.Forms.TextBox txtnombrerol;
        private System.Windows.Forms.DataGridView dgvfuncionalidades;
        private System.Windows.Forms.Button btnguardarrol;
        private System.Windows.Forms.Label lblidrol;
        private System.Windows.Forms.TextBox txtidrol;
        private System.Windows.Forms.Label lblfuncionalidades;
        private System.Windows.Forms.CheckBox checkBoxhabilitado;
    }
}