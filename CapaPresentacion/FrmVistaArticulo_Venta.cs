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
    public partial class FrmVistaArticulo_Venta : Form
    {
        public FrmVistaArticulo_Venta()
        {
            InitializeComponent();
        }


        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        //Método BuscarNombre
        private void MostrarArticulo_Venta_Nombre()
        {
            this.dataListado.DataSource = NVenta.MostrarArticulo_Venta_Nombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void MostrarArticulo_Venta_Codigo()
        {
            this.dataListado.DataSource = NVenta.MostrarArticulo_Venta_Codigo(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void FrmVistaArticulo_Venta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Codigo"))
            {
                this.MostrarArticulo_Venta_Codigo();
            }
            else if (cbBuscar.Text.Equals("Nombre"))
            {
                this.MostrarArticulo_Venta_Nombre();
            }
        }
        private void dataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmVenta form = new FrmVenta();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "FrmVenta")
                {
                    form = (FrmVenta)frm;
                    form.txtIdarticulo.Text = this.dataListado.Rows[e.RowIndex].Cells["iddetalle_ingreso"].Value.ToString();
                    form.txtArticulo.Text = this.dataListado.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    form.txtPrecio_Compra.Text = this.dataListado.Rows[e.RowIndex].Cells["precio_compra"].Value.ToString();
                    form.txtPrecio_Venta.Text = this.dataListado.Rows[e.RowIndex].Cells["precio_venta"].Value.ToString();
                    form.txtStock_Actual.Text = this.dataListado.Rows[e.RowIndex].Cells["stock_actual"].Value.ToString();
                    form.dtFecha_Vencimiento.Value = (DateTime)this.dataListado.Rows[e.RowIndex].Cells["fecha_vencimiento"].Value;
                    this.Close();
                    break;
                }
            }
        }
    }
}
