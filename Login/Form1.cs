using System.Diagnostics.Eventing.Reader;

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
            string login = TextboxLogin.Text;

            Resultado.Text = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string login = TextboxLogin.Text;
            
            string Senha = textboxSenha.Text;
            Resultado.Text = login;

            if(login == null || login == "")// null=nulo, caso o usuario seja nulo, mensagem de erro.
            {
                Resultado.Text = "Usuario eh obrigatorio!!";
                Resultado.ForeColor = Color.Red;
                return; // termina a execucao do programa 
            }
              // se condição for verdadeira,condinua a condiçao
            else if (Senha == null || Senha == "") ;
            
                {
                    Resultado.Text = " Senha Obrigatória !!";
                    Resultado.ForeColor = Color.Red;
                return;
                    

                }
              
            // 


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
