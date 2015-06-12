namespace PagoElectronico.ControlesCustomizados
{
    partial class ucGrilla
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListado
            // 
            this.dgListado.AllowUserToAddRows = false;
            this.dgListado.AllowUserToDeleteRows = false;
            this.dgListado.AllowUserToOrderColumns = true;
            this.dgListado.AllowUserToResizeRows = false;
            this.dgListado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgListado.EnableHeadersVisualStyles = false;
            this.dgListado.Location = new System.Drawing.Point(0, 0);
            this.dgListado.MultiSelect = false;
            this.dgListado.Name = "dgListado";
            this.dgListado.ReadOnly = true;
            this.dgListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListado.ShowEditingIcon = false;
            this.dgListado.ShowRowErrors = false;
            this.dgListado.Size = new System.Drawing.Size(242, 181);
            this.dgListado.TabIndex = 2;
            this.dgListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListado_CellClick);
            // 
            // ucGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgListado);
            this.Name = "ucGrilla";
            this.Size = new System.Drawing.Size(244, 184);
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgListado;

    }
}
