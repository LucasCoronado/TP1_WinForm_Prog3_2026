namespace TPWinForm_equipo14B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            FrmArticulo articulo = new FrmArticulo();
            articulo.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
