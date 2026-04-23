using Dominio;
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
    public partial class FrmArticulo : Form
    {
        private Articulo articulo = null;
        public FrmArticulo()
        {
            InitializeComponent();
        }

        public FrmArticulo(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            cboMarca.Items.Add("marca 1");
            cboMarca.Items.Add("marca 2");
            cboMarca.Items.Add("marca 3");
            cboMarca.Items.Add("marca 4");
            cboMarca.Items.Add("marca 5");
            cboCategoria.Items.Add("Categoria 1");
            cboCategoria.Items.Add("Categoria 2");
            cboCategoria.Items.Add("Categoria 3");
            cboCategoria.Items.Add("Categoria 4");
            cboCategoria.Items.Add("Categoria 5");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtboxCodArt.Clear();
            txtboxDescripcion.Clear();
            txtboxNombre.Clear();
            txtboxPrecio.Clear();
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
