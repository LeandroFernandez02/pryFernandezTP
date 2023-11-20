using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryFernandezTP
{
    public partial class frmRegistrarEmpleado : Form
    {
        clsEmpleadosBD objEmpleadosBD;
        public frmRegistrarEmpleado()
        {
            InitializeComponent();

            objEmpleadosBD = new clsEmpleadosBD();
        }

        public string rutaseleccionada;
        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Title = "Visor de Imágenes";
            imagen.Filter = "Archivos de Imagen|*.jpg;*.png;*.bmp";

            if (imagen.ShowDialog() == DialogResult.OK)
            {
                string ruta = imagen.FileName;
                pctImagen.Image = Image.FromFile(ruta);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {           
            string varDireccion = txtCalle.Text + " " + txtNumero.Text + " " + txtBarrio.Text;
            objEmpleadosBD.registrarBD(txtCodigo.Text, txtNombre.Text, txtApellido.Text, varDireccion, txtCiudad.Text, txtTelefono.Text, dtpNacimiento.Value);            
        }        
    }
}
