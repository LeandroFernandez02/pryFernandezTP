
namespace pryFernandezTP
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stpConexion = new System.Windows.Forms.StatusStrip();
            this.lblConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.btnEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFrmRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFrmListado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFrmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaHora = new System.Windows.Forms.Timer(this.components);
            this.pnlFormHijo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stpConexion.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.pnlFormHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stpConexion
            // 
            this.stpConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConexion,
            this.lblFechaHora});
            this.stpConexion.Location = new System.Drawing.Point(0, 428);
            this.stpConexion.Name = "stpConexion";
            this.stpConexion.Size = new System.Drawing.Size(800, 22);
            this.stpConexion.TabIndex = 0;
            this.stpConexion.Text = "statusStrip1";
            // 
            // lblConexion
            // 
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(22, 17);
            this.lblConexion.Text = "***";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(22, 17);
            this.lblFechaHora.Text = "***";
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEmpleados,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(800, 24);
            this.mnsMenu.TabIndex = 1;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFrmRegistrar,
            this.btnFrmListado,
            this.btnFrmModificar});
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(77, 20);
            this.btnEmpleados.Text = "Empleados";
            // 
            // btnFrmRegistrar
            // 
            this.btnFrmRegistrar.Name = "btnFrmRegistrar";
            this.btnFrmRegistrar.Size = new System.Drawing.Size(265, 22);
            this.btnFrmRegistrar.Text = "Registrar Empleado";
            this.btnFrmRegistrar.Click += new System.EventHandler(this.btnFrmRegistrar_Click);
            // 
            // btnFrmListado
            // 
            this.btnFrmListado.Name = "btnFrmListado";
            this.btnFrmListado.Size = new System.Drawing.Size(265, 22);
            this.btnFrmListado.Text = "Listado de Empleados";
            this.btnFrmListado.Click += new System.EventHandler(this.btnFrmListado_Click);
            // 
            // btnFrmModificar
            // 
            this.btnFrmModificar.Name = "btnFrmModificar";
            this.btnFrmModificar.Size = new System.Drawing.Size(265, 22);
            this.btnFrmModificar.Text = "Modificar Informacion de Empleado";
            this.btnFrmModificar.Click += new System.EventHandler(this.btnFrmModificar_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Enabled = false;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Enabled = false;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Enabled = false;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // fechaHora
            // 
            // 
            // pnlFormHijo
            // 
            this.pnlFormHijo.BackColor = System.Drawing.Color.White;
            this.pnlFormHijo.Controls.Add(this.pictureBox1);
            this.pnlFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormHijo.Location = new System.Drawing.Point(0, 24);
            this.pnlFormHijo.Name = "pnlFormHijo";
            this.pnlFormHijo.Size = new System.Drawing.Size(800, 404);
            this.pnlFormHijo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryFernandezTP.Properties.Resources._84f48effb1900180d338684be6c2467b;
            this.pictureBox1.Location = new System.Drawing.Point(52, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFormHijo);
            this.Controls.Add(this.stpConexion);
            this.Controls.Add(this.mnsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Empleados";
            this.stpConexion.ResumeLayout(false);
            this.stpConexion.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.pnlFormHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stpConexion;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem btnEmpleados;
        private System.Windows.Forms.ToolStripStatusLabel lblConexion;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
        private System.Windows.Forms.Timer fechaHora;
        private System.Windows.Forms.ToolStripMenuItem btnFrmRegistrar;
        private System.Windows.Forms.ToolStripMenuItem btnFrmListado;
        private System.Windows.Forms.ToolStripMenuItem btnFrmModificar;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFormHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

