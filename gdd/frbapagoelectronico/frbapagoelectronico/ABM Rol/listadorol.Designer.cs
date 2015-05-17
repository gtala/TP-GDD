namespace frbapagoelectronico.ABM_Rol
{
    partial class listadorol
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
            this.txtrollike = new System.Windows.Forms.TextBox();
            this.txtrolexacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvroles = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnalta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrollike
            // 
            this.txtrollike.Location = new System.Drawing.Point(326, 43);
            this.txtrollike.Name = "txtrollike";
            this.txtrollike.Size = new System.Drawing.Size(109, 20);
            this.txtrollike.TabIndex = 0;
            // 
            // txtrolexacto
            // 
            this.txtrolexacto.Location = new System.Drawing.Point(104, 43);
            this.txtrolexacto.Name = "txtrolexacto";
            this.txtrolexacto.Size = new System.Drawing.Size(100, 20);
            this.txtrolexacto.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "nombre de rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "nombre de rol";
            // 
            // dgvroles
            // 
            this.dgvroles.AllowUserToAddRows = false;
            this.dgvroles.AllowUserToDeleteRows = false;
            this.dgvroles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvroles.Location = new System.Drawing.Point(75, 99);
            this.dgvroles.Name = "dgvroles";
            this.dgvroles.Size = new System.Drawing.Size(327, 229);
            this.dgvroles.TabIndex = 10;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnbuscar.Location = new System.Drawing.Point(408, 69);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(72, 37);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "texto exacto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "texto libre";
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnmodificar.Location = new System.Drawing.Point(40, 359);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(72, 37);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btneliminar.Location = new System.Drawing.Point(215, 359);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(72, 37);
            this.btneliminar.TabIndex = 16;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnalta
            // 
            this.btnalta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnalta.Location = new System.Drawing.Point(376, 359);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(72, 37);
            this.btnalta.TabIndex = 17;
            this.btnalta.Text = "alta";
            this.btnalta.UseVisualStyleBackColor = false;
            // 
            // listadorol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 408);
            this.Controls.Add(this.btnalta);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgvroles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrolexacto);
            this.Controls.Add(this.txtrollike);
            this.Name = "listadorol";
            this.Text = "listado de roles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvroles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrollike;
        private System.Windows.Forms.TextBox txtrolexacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvroles;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnalta;
    }
}