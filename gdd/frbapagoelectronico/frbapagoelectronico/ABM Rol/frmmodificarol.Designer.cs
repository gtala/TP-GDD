namespace frbapagoelectronico.ABM_Rol
{
    partial class frmmodificarol
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
            this.txtidrol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombrederol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfuncionalidades = new System.Windows.Forms.Label();
            this.checkBoxhabilitado = new System.Windows.Forms.CheckBox();
            this.dgvfuncionalidades = new System.Windows.Forms.DataGridView();
            this.btnmodif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidrol
            // 
            this.txtidrol.Location = new System.Drawing.Point(110, 26);
            this.txtidrol.Name = "txtidrol";
            this.txtidrol.Size = new System.Drawing.Size(99, 20);
            this.txtidrol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "idrol";
            // 
            // txtnombrederol
            // 
            this.txtnombrederol.Location = new System.Drawing.Point(350, 29);
            this.txtnombrederol.Name = "txtnombrederol";
            this.txtnombrederol.Size = new System.Drawing.Size(110, 20);
            this.txtnombrederol.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "nombre de rol";
            // 
            // lblfuncionalidades
            // 
            this.lblfuncionalidades.AutoSize = true;
            this.lblfuncionalidades.Location = new System.Drawing.Point(46, 60);
            this.lblfuncionalidades.Name = "lblfuncionalidades";
            this.lblfuncionalidades.Size = new System.Drawing.Size(81, 13);
            this.lblfuncionalidades.TabIndex = 7;
            this.lblfuncionalidades.Text = "funcionalidades";
            // 
            // checkBoxhabilitado
            // 
            this.checkBoxhabilitado.AutoSize = true;
            this.checkBoxhabilitado.Location = new System.Drawing.Point(49, 90);
            this.checkBoxhabilitado.Name = "checkBoxhabilitado";
            this.checkBoxhabilitado.Size = new System.Drawing.Size(71, 17);
            this.checkBoxhabilitado.TabIndex = 8;
            this.checkBoxhabilitado.Text = "habilitado";
            this.checkBoxhabilitado.UseVisualStyleBackColor = true;
            // 
            // dgvfuncionalidades
            // 
            this.dgvfuncionalidades.AllowUserToAddRows = false;
            this.dgvfuncionalidades.AllowUserToDeleteRows = false;
            this.dgvfuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionalidades.Location = new System.Drawing.Point(49, 126);
            this.dgvfuncionalidades.Name = "dgvfuncionalidades";
            this.dgvfuncionalidades.Size = new System.Drawing.Size(342, 266);
            this.dgvfuncionalidades.TabIndex = 9;
            // 
            // btnmodif
            // 
            this.btnmodif.Location = new System.Drawing.Point(387, 73);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(73, 34);
            this.btnmodif.TabIndex = 10;
            this.btnmodif.Text = "modificar";
            this.btnmodif.UseVisualStyleBackColor = true;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // frmmodificarol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 440);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.dgvfuncionalidades);
            this.Controls.Add(this.checkBoxhabilitado);
            this.Controls.Add(this.lblfuncionalidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombrederol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidrol);
            this.Name = "frmmodificarol";
            this.Text = "modificar rol";
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombrederol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfuncionalidades;
        private System.Windows.Forms.CheckBox checkBoxhabilitado;
        private System.Windows.Forms.DataGridView dgvfuncionalidades;
        private System.Windows.Forms.Button btnmodif;
    }
}