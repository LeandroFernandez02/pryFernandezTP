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
    public partial class frmListadoEmpleado : Form
    {
        clsEmpleadosBD objEmpleadosBD;
        public frmListadoEmpleado()
        {
            InitializeComponent();

            objEmpleadosBD = new clsEmpleadosBD();
            objEmpleadosBD.leerBD(dgvMostrar);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvMostrar.Rows.Clear();
            dgvMostrar.Columns.Clear();
            objEmpleadosBD.leerBD(dgvMostrar, txtApellido.Text, txtDireccion.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtDireccion.Clear();

            dgvMostrar.Rows.Clear();
            dgvMostrar.Columns.Clear();

            objEmpleadosBD.leerBD(dgvMostrar);
        }
    }
}
