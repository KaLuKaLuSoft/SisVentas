using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmVistaProveedor_Ingreso : Form
    {
        public FrmVistaProveedor_Ingreso()
        {
            InitializeComponent();
        }

        private void FrmVistaProveedor_Ingreso_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NProveedor.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarRazon_Social
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = NProveedor.BuscarRazon_social(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNum_Documento
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = NProveedor.BuscarNum_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Razon Social"))
            {
                this.BuscarRazon_Social();
            }
            else if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    FrmIngreso form = new FrmIngreso();
            //    foreach (Form frm in Application.OpenForms)
            //    {
            //        if (frm.Name == "FrmIngreso")
            //        {
            //            form = (FrmIngreso)frm;
            //            form.txtIdproveedor.Text = this.dataListado.CurrentRow.Cells["idproveedor"].ToString();

            //            form.txtProveedor.Text = this.dataListado.CurrentRow.Cells["razon_social"].ToString();
            //            this.Close();
            //            break;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmIngreso form = new FrmIngreso();
            foreach(Form frm in Application.OpenForms)
            {
                if(frm.Name == "FrmIngreso")
                {
                    form = (FrmIngreso)frm;
                    form.txtIdproveedor.Text = this.dataListado.Rows[e.RowIndex].Cells["idproveedor"].Value.ToString();
                    form.txtProveedor.Text = this.dataListado.Rows[e.RowIndex].Cells["razon_social"].Value.ToString();
                    this.Close();
                    break;
                }
            }
        }
    }
}
