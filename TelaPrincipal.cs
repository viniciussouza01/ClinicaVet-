namespace ClinicaVeterinariaForms
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void linkLblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmCadastroUsuario telaCadastroUsuario = new FrmCadastroUsuario();
            telaCadastroUsuario.ShowDialog();
            this.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPaginaInicial telaInicial = new FrmPaginaInicial();
            telaInicial.ShowDialog();
        }
    }
}
