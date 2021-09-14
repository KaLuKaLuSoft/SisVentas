using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrimero : Form
    {
        public FrmPrimero()
        {
            InitializeComponent();
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            submenuProductos.Visible = false;
            submenuVentas.Visible = false;
            //panelToolsSubMenu.Visible = false;
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuProductos);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuVentas);
        }
    }
}
