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

            if(usuario == "administrador" && senha == "12345678")
            {
               telaPrinciapal tela2 = new telaPrinciapal();
                tela2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }
    }
}
