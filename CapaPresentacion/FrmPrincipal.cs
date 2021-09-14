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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
        }
        public string Idtrabajador = "";
        public string Apellidos = "";
        public string Nombre = "";
        public string Acceso = "";

        public void habilitarbotones()
        {
            Btn_Almacen.Enabled = false;
            Btn_Compras.Enabled = false;
            Btn_Ventas.Enabled = false;
            Btn_Usuarios.Enabled = false;
        }
        private void GestionUsuario()
        {
            //COntrolar los accesos
            if (Acceso == "Administrador")
            {
                this.Btn_Almacen.Enabled = true;
                this.Btn_Compras.Enabled = true;
                this.Btn_Ventas.Enabled = true;
                this.Btn_Usuarios.Enabled = true;
            }
            else if(Acceso == "Vendedor")
            {
                this.Btn_Almacen.Enabled = false;
                this.Btn_Compras.Enabled = false;
                this.Btn_Ventas.Enabled = true;
                this.Btn_Usuarios.Enabled = false;
            }
            else if (Acceso == "Almacenero")
            {
                this.Btn_Almacen.Enabled = true;
                this.Btn_Compras.Enabled = false;
                this.Btn_Ventas.Enabled = false;
                this.Btn_Usuarios.Enabled = false;
            }
            else
            {
                Btn_Almacen.Enabled = false;
                Btn_Compras.Enabled = false;
                Btn_Ventas.Enabled = false;
                Btn_Usuarios.Enabled = false;
            }
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            panel1.Visible = false;
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

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmArticulo());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCategoria());
            hideSubMenu();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPresentacion());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }
        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            frm.Idtrabajador = Convert.ToInt32(this.Idtrabajador);
            openChildForm(frm);
            hideSubMenu();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProveedor());
            hideSubMenu();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Close();
            //Application.Exit();
        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmVenta());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmCliente());
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            frm.Idtrabajador = Convert.ToInt32(this.Idtrabajador);
            openChildForm(frm);
            hideSubMenu();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            openChildForm(new frmCliente());
            hideSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmTrabajador());
            hideSubMenu();
        }
        private void FrmSegundo_Load(object sender, EventArgs e)
        {
            GestionUsuario();
        }
    }
}
