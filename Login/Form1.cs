namespace Login
{
    public partial class Formslogin : Form
    {
        public Formslogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string login = Usuario.Text;

            Resultado.Text = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string login = Usuario.Text;
            
            string Senha = Caixasenha.Text;
            Resultado.Text = login;

            if(login == null || login == "")
            {
                Resultado.Text = "Usuario eh obrigatorio!!";
                Resultado.ForeColor = Color.Red;
                return;
            }

            if (login == "Ems.Sousa" && Senha == "12345")
            {
                Resultado.Text = "Autentificado com sucesso!";
                Resultado.ForeColor = Color.Green;
            }
            else
            {
                Resultado.Text = "Usuario ou senha incorretos...";
                Resultado.ForeColor = Color.Red;
            }
        }
    }
}
