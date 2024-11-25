namespace DemoConcurrencia
{
    public partial class FrmPatronSingleton : Form
    {
        public FrmPatronSingleton()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            cadenaConexion.cadenaConexion = txtCadenaConexion.Text;
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            lblCadenaConexionRecuperada.Text = cadenaConexion.cadenaConexion;
        }
    }
}
