using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using clases;


namespace frbapagoelectronico.ABM_Rol
{
    public partial class frmmodificarol : Form
    {
        Rol unrolglobal;
        public frmmodificarol(Rol unrol)
        {
            InitializeComponent();
            unrolglobal = unrol;
            txtidrol.Text = unrol.getidrol().ToString();
            txtidrol.Enabled = false;
            txtnombrederol.Text = unrol.getnombre();
            txtnombrederol.Enabled = false;
            if (unrol.getestado() == 1)
            {
                checkBoxhabilitado.Checked = true;
            }
            else
            {
                checkBoxhabilitado.Checked = false;
            }
            Usuario user = new Usuario();
            user.setrol(unrol.getidrol());
            DataTable dt = new DataTable();
            
            new funcionalidadsql().traerFuncionalidades().Fill(dt);
            dgvfuncionalidades.DataSource = dt;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "habilitada";
            dgvfuncionalidades.Columns.Add(checkBoxColumn);
                      
            

        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            SqlConnection unacon = new Conexiones().conectarse();
            SqlCommand cmd2 = new SqlCommand("delete from gdd_maxi.Rolxfuncionalidad where idrol = " + txtidrol.Text, unacon);
            
            cmd2.ExecuteNonQuery();
            int estado = 0;
            if (checkBoxhabilitado.Checked) estado = 1;

            SqlCommand cmd3 = new SqlCommand("update gdd_maxi.Roles set estado = " + estado.ToString() + " where idrol = " + txtidrol.Text, unacon);
                                 
            cmd3.ExecuteNonQuery();
            foreach (DataGridViewRow r in dgvfuncionalidades.Rows)
            {
                DataGridViewCheckBoxCell chk = r.Cells["habilitada"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(chk.Value) == true)
                {
                    SqlCommand cmd4 = new SqlCommand("gdd_maxi.sp_insertarolxfuncionalidad", unacon);

                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.Add("@idrol", SqlDbType.Int).Value = txtidrol.Text;
                    cmd4.Parameters.Add("@idfuncionalidad", SqlDbType.Int).Value = r.Cells["idfuncionalidad"].Value;
                    cmd4.ExecuteNonQuery();
                }
            }

            unacon.Close();
        }
    }
}
