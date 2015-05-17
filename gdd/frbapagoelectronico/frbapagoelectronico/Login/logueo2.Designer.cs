namespace frbapagoelectronico.Login
{
    partial class logueo2
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
            this.btncontinuar = new System.Windows.Forms.Button();
            this.lblseleccionar = new System.Windows.Forms.Label();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btncontinuar
            // 
            this.btncontinuar.Location = new System.Drawing.Point(151, 90);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(95, 30);
            this.btncontinuar.TabIndex = 0;
            this.btncontinuar.Text = "continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // lblseleccionar
            // 
            this.lblseleccionar.AutoSize = true;
            this.lblseleccionar.Location = new System.Drawing.Point(38, 33);
            this.lblseleccionar.Name = "lblseleccionar";
            this.lblseleccionar.Size = new System.Drawing.Size(75, 13);
            this.lblseleccionar.TabIndex = 1;
            this.lblseleccionar.Text = "seleccionar rol";
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(151, 33);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(173, 21);
            this.cbRoles.TabIndex = 2;
            // 
            // logueo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 192);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.lblseleccionar);
            this.Controls.Add(this.btncontinuar);
            this.Name = "logueo2";
            this.Text = "logueo2";
            this.Load += new System.EventHandler(this.logueo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.Label lblseleccionar;
        private System.Windows.Forms.ComboBox cbRoles;
    }
}