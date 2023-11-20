using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFernandezTP
{
    public partial class frmPrincipal : Form
    {
        clsEmpleadosBD objEmpleadosBD;
        public frmPrincipal()
        {
            InitializeComponent();
            objEmpleadosBD = new clsEmpleadosBD();
            objEmpleadosBD.ConectarBD();

            lblConexion.Text = objEmpleadosBD.estadoConexion;
            lblConexion.BackColor = Color.Green;
            
            string hora = DateTime.Now.ToLongTimeString();
            string fecha = DateTime.Now.ToShortDateString();
            lblFechaHora.Text = hora + " " + fecha;           
        }

        private void btnFrmRegistrar_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmRegistrarEmpleado());
        }
        private void btnFrmListado_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmListadoEmpleado());
        }

        private void btnFrmModificar_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmModificarEmpleado());
        }

        private Form formActivo = null;
        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlFormHijo.Controls.Add(formHijo);
            pnlFormHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
    }
}
