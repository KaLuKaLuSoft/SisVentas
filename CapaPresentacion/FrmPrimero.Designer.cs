
namespace CapaPresentacion
{
    partial class FrmPrimero
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.submenuProductos = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnPresentaciones = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.submenuVentas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.submenuProductos.SuspendLayout();
            this.submenuVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.submenuVentas);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.submenuProductos);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 714);
            this.panel1.TabIndex = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Location = new System.Drawing.Point(-1, -6);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1174, 48);
            this.BarraTitulo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Location = new System.Drawing.Point(3, 100);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(187, 45);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // submenuProductos
            // 
            this.submenuProductos.Controls.Add(this.btnPresentaciones);
            this.submenuProductos.Controls.Add(this.btnCategoria);
            this.submenuProductos.Controls.Add(this.btnArticulos);
            this.submenuProductos.Controls.Add(this.button2);
            this.submenuProductos.Location = new System.Drawing.Point(26, 145);
            this.submenuProductos.Name = "submenuProductos";
            this.submenuProductos.Size = new System.Drawing.Size(164, 144);
            this.submenuProductos.TabIndex = 2;
            this.submenuProductos.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnArticulos
            // 
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Location = new System.Drawing.Point(3, 0);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(158, 45);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "Artículos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Location = new System.Drawing.Point(3, 47);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(158, 45);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Categoría";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnPresentaciones
            // 
            this.btnPresentaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresentaciones.Location = new System.Drawing.Point(3, 95);
            this.btnPresentaciones.Name = "btnPresentaciones";
            this.btnPresentaciones.Size = new System.Drawing.Size(158, 45);
            this.btnPresentaciones.TabIndex = 3;
            this.btnPresentaciones.Text = "Presentaciones";
            this.btnPresentaciones.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Location = new System.Drawing.Point(3, 291);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(184, 45);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "Productos";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // submenuVentas
            // 
            this.submenuVentas.Controls.Add(this.button1);
            this.submenuVentas.Controls.Add(this.button3);
            this.submenuVentas.Controls.Add(this.button4);
            this.submenuVentas.Controls.Add(this.button5);
            this.submenuVentas.Location = new System.Drawing.Point(23, 338);
            this.submenuVentas.Name = "submenuVentas";
            this.submenuVentas.Size = new System.Drawing.Size(164, 144);
            this.submenuVentas.TabIndex = 4;
            this.submenuVentas.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Presentaciones";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(3, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Categoría";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 45);
            this.button4.TabIndex = 1;
            this.button4.Text = "Artículos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(35, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(8, 8);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FrmPrimero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 749);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrimero";
            this.Text = "Presentaciones";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.submenuProductos.ResumeLayout(false);
            this.submenuVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel submenuProductos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnPresentaciones;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel submenuVentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}