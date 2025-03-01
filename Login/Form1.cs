using System.Diagnostics.Eventing.Reader;

namespace Login
{

    public partial class Formslogin : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.Vittar}", "sukuna.silva" }; // Criar o array de nomes de usuários
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };
        public Formslogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string loginbuscado = TextboxLogin.Text;
            string Senha = textboxSenha.Text;
            Resultado.Text = loginbuscado;

            if (string.IsNullOrWhiteSpace(loginbuscado))
            {
                Resultado.Text = "Usuario eh obrigatorio!!";
                Resultado.ForeColor = Color.Red;
                return;
            }

            if (Senha == null || Senha == "")

            {
                Resultado.Text = " Senha eh Obrigatória !!";
                Resultado.ForeColor = Color.Red;
                return;
            }

            int posicaologinEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++) //3 condicoes de execucao,i representa o indice ou posicao ela é uma variavel 
                                                          //i acrescenta 1 toda vez que codigo roda, até chegar no 3 onde o programa para
            {
                if (loginbuscado == listaUsuarios[i])
                {
                    posicaologinEncontrado = i;
                }
            }
            if (posicaologinEncontrado > -1 && Senha == listaSenhas[posicaologinEncontrado])
            {
                Resultado.Text = "Autenticado com sucesso!";
                Resultado.ForeColor = Color.Green;
            }
            else
            {
                Resultado.Text = "Usuario ou senha incorretos...";
                Resultado.ForeColor = Color.Red;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {       // novas varias criadas para a parte CADASTRAR
            string novoUsuario = TextboxLogin.Text;
            string novaSenha = TextboxLogin.Text;

            // Comando para caso o usuario deixe em branco o login
            if(string.IsNullOrEmpty(novoUsuario))
            {
                ResultadoCadastrar.Text = "Usuario eh Obrigatorio!";
                return;
            }
            // comando caso o usuario deixe o espaço senha em branco 
            if (string.IsNullOrEmpty(novaSenha))
            {
                ResultadoCadastrar.Text = "Senha eh Obrigatoria!";
                return;
            }
             // comando para verificar se há usuarios com o mesmo nome 
            bool UsuarioEncontrado = false;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (novoUsuario == listaUsuarios[i])
                {
                    UsuarioEncontrado = true;

                }
            }
            // comando para adicionar novo usuario com nomes diferentes a lista
            if (UsuarioEncontrado == false)
            {
                listaUsuarios.Add(novoUsuario); // adiciona a lista usuario
                listaSenhas.Add(novaSenha);// addciona a lista Senhas
                ResultadoCadastrar.Text = "Usuario Cadastrado";
                ResultadoCadastrar.ForeColor = Color.Green;
          
            }

            // comando para avisar que ja esxiste usuario com o mesmo nome 
            else
            {
                ResultadoCadastrar.Text = "Usuario já existente";
                ResultadoCadastrar.ForeColor = Color.Red;
            }
            




            
        }
    }
}
            
           

        
      




