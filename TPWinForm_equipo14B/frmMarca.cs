using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo14B
{
    public partial class frmMarca : Form
    {
        private Marca marca = null;

        public frmMarca()
        {
            InitializeComponent();
        }

        public frmMarca(Marca marcaSeleccionada)
        {
            InitializeComponent();
            this.marca = marcaSeleccionada;
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtDescripcion.Text = marca.Descripcion;
                this.Text = "Modificar Marca";
            }
            else
            {
                this.Text = "Nueva Marca";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                    marca = new Marca();

                marca.Descripcion = txtDescripcion.Text;

                if (marca.Id != 0)
                {
                    negocio.Modificar(marca);
                    MessageBox.Show("Marca modificada exitosamente.");
                }
                else
                {
                    negocio.Agregar(marca);
                    MessageBox.Show("Marca agregada exitosamente.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
