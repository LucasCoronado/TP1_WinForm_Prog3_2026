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
    public partial class frmMarcas : Form
    {
        private MarcaNegocio negocio = new MarcaNegocio();
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                dgvMarcas.DataSource = negocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las marcas: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMarca alta = new frmMarca();
            alta.ShowDialog();

            CargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                frmMarca modificar = new frmMarca(seleccionada);
                modificar.ShowDialog();

                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná una marca de la grilla para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar esta marca?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                        negocio.Eliminar(seleccionada.Id);
                        CargarGrilla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná una marca para eliminar.");
            }
        }
    }
}
