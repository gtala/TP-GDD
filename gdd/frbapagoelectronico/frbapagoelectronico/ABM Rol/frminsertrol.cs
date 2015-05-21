using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases;
using System.Data.Sql;
using System.Data.SqlClient;

namespace frbapagoelectronico.ABM_Rol
{
    public partial class frminsertrol : Form
    {
        public frminsertrol()
        {
            InitializeComponent();
            DataTable dt = new DataTable("funcionalidades");
            new funcionalidadsql().traerFuncionalidades().Fill(dt);

            dgvfuncionalidades.DataSource = dt;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "habilitada";
            dgvfuncionalidades.Columns.Add(checkBoxColumn);


        }

        private void frminsertrol_Load(object sender, EventArgs e)
        {

        }

        private void btnguardarrol_Click(object sender, EventArgs e)
        {
            SqlConnection unacon = new Conexiones().conectarse();
            List<int> listaderoles;
            listaderoles = new Rolsql().obtenerRolescoleccion(unacon);
            if (listaderoles.Contains(int.Parse(txtidrol.Text)))
            {
                MessageBox.Show("el numero de rol ya existe");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("gdd_maxi.sp_insertarol", unacon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtidrol.Text;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txtnombrerol.Text;
                cmd.Parameters.Add("@estado", SqlDbType.Int).Value = checkBoxhabilitado.Checked;
                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow r in dgvfuncionalidades.Rows)
                {
                    DataGridViewCheckBoxCell chk = r.Cells["habilitada"] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        SqlCommand cmd2 = new SqlCommand("gdd_maxi.sp_insertarolxfuncionalidad", unacon);

                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@idrol", SqlDbType.Int).Value = txtidrol.Text;
                        cmd2.Parameters.Add("@idfuncionalidad", SqlDbType.Int).Value = r.Cells["idfuncionalidad"].Value;
                        cmd2.ExecuteNonQuery();


                    }


                }
            }
            
            unacon.Close();
        }

        
    }
}
