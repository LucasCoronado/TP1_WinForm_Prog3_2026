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
using Dominio;

namespace TPWinForm_equipo14B
{
    public partial class frmEliminarArticulos : Form
    {
        public frmEliminarArticulos()
        {
            InitializeComponent();
        }

        private void frmEliminarArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar el artículo?",
                    "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
