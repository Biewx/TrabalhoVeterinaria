namespace sistema_Patas_Cuidados
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "administrador" && senha == "12345678")
            {
                telaConsultas tela2 = new telaConsultas();
                tela2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usu�rio ou senha incorretos.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
