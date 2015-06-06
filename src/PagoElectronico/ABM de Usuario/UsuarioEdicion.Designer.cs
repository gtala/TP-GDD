namespace PagoElectronico.ABM_de_Usuario
{
    partial class UsuarioEdicion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkInhabilitado = new System.Windows.Forms.CheckBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbUsuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDesasignarTodos = new System.Windows.Forms.Button();
            this.btnAsignarTodos = new System.Windows.Forms.Button();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lstAsignados = new System.Windows.Forms.ListBox();
            this.lstNoAsignados = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gcAccion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.tbUsuario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gcAccion
            // 
            this.gcAccion.Controls.Add(this.label5);
            this.gcAccion.Controls.Add(this.lblFechaCreacion);
            this.gcAccion.Controls.Add(this.lblFechaModificacion);
            this.gcAccion.Controls.Add(this.label6);
            this.gcAccion.Location = new System.Drawing.Point(15, 341);
            this.gcAccion.Size = new System.Drawing.Size(524, 60);
            this.gcAccion.Text = "";
            this.gcAccion.Controls.SetChildIndex(this.label6, 0);
            this.gcAccion.Controls.SetChildIndex(this.lblFechaModificacion, 0);
            this.gcAccion.Controls.SetChildIndex(this.lblFechaCreacion, 0);
            this.gcAccion.Controls.SetChildIndex(this.label5, 0);
            this.gcAccion.Controls.SetChildIndex(this.btnGuardar, 0);
            this.gcAccion.Controls.SetChildIndex(this.btnCancelar, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pregunta secreta: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Respuesta secreta: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(149, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(329, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(329, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha creación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha modificación: ";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(132, 19);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(0, 13);
            this.lblFechaCreacion.TabIndex = 6;
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Location = new System.Drawing.Point(138, 43);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(0, 13);
            this.lblFechaModificacion.TabIndex = 7;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(149, 147);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(329, 63);
            this.txtRespuesta.TabIndex = 13;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(149, 78);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(330, 63);
            this.txtPregunta.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkInhabilitado);
            this.groupBox1.Controls.Add(this.txtPregunta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRespuesta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 288);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Inhabilitado: ";
            // 
            // chkInhabilitado
            // 
            this.chkInhabilitado.AutoSize = true;
            this.chkInhabilitado.Location = new System.Drawing.Point(149, 236);
            this.chkInhabilitado.Name = "chkInhabilitado";
            this.chkInhabilitado.Size = new System.Drawing.Size(15, 14);
            this.chkInhabilitado.TabIndex = 14;
            this.chkInhabilitado.UseVisualStyleBackColor = true;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Controls.Add(this.tabPage1);
            this.tbUsuario.Controls.Add(this.tabPage2);
            this.tbUsuario.Location = new System.Drawing.Point(15, 12);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.SelectedIndex = 0;
            this.tbUsuario.Size = new System.Drawing.Size(524, 323);
            this.tbUsuario.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnDesasignarTodos);
            this.tabPage2.Controls.Add(this.btnAsignarTodos);
            this.tabPage2.Controls.Add(this.btnDesasignar);
            this.tabPage2.Controls.Add(this.btnAsignar);
            this.tabPage2.Controls.Add(this.lstAsignados);
            this.tabPage2.Controls.Add(this.lstNoAsignados);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(516, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Roles";
            // 
            // btnDesasignarTodos
            // 
            this.btnDesasignarTodos.Location = new System.Drawing.Point(221, 161);
            this.btnDesasignarTodos.Name = "btnDesasignarTodos";
            this.btnDesasignarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnDesasignarTodos.TabIndex = 7;
            this.btnDesasignarTodos.Text = "<<";
            this.btnDesasignarTodos.UseVisualStyleBackColor = true;
            this.btnDesasignarTodos.Click += new System.EventHandler(this.btnDesasignarTodos_Click);
            // 
            // btnAsignarTodos
            // 
            this.btnAsignarTodos.Location = new System.Drawing.Point(221, 74);
            this.btnAsignarTodos.Name = "btnAsignarTodos";
            this.btnAsignarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarTodos.TabIndex = 6;
            this.btnAsignarTodos.Text = ">>";
            this.btnAsignarTodos.UseVisualStyleBackColor = true;
            this.btnAsignarTodos.Click += new System.EventHandler(this.btnAsignarTodos_Click);
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Location = new System.Drawing.Point(221, 132);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(75, 23);
            this.btnDesasignar.TabIndex = 5;
            this.btnDesasignar.Text = "<";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(221, 103);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = ">";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lstAsignados
            // 
            this.lstAsignados.FormattingEnabled = true;
            this.lstAsignados.Location = new System.Drawing.Point(302, 35);
            this.lstAsignados.Name = "lstAsignados";
            this.lstAsignados.Size = new System.Drawing.Size(200, 251);
            this.lstAsignados.TabIndex = 3;
            // 
            // lstNoAsignados
            // 
            this.lstNoAsignados.FormattingEnabled = true;
            this.lstNoAsignados.Location = new System.Drawing.Point(15, 35);
            this.lstNoAsignados.Name = "lstNoAsignados";
            this.lstNoAsignados.Size = new System.Drawing.Size(200, 251);
            this.lstNoAsignados.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Asignados:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "No asignados:";
            // 
            // UsuarioEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 419);
            this.Controls.Add(this.tbUsuario);
            this.Name = "UsuarioEdicion";
            this.Text = "UsuarioEdicion";
            this.Controls.SetChildIndex(this.gcAccion, 0);
            this.Controls.SetChildIndex(this.tbUsuario, 0);
            this.gcAccion.ResumeLayout(false);
            this.gcAccion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.tbUsuario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkInhabilitado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.TabControl tbUsuario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.ListBox lstAsignados;
        private System.Windows.Forms.ListBox lstNoAsignados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDesasignarTodos;
        private System.Windows.Forms.Button btnAsignarTodos;
    }
}