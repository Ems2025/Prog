using System.Diagnostics.Eventing.Reader;

namespace Login
{

    public partial class Formslogin : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.Vittar}", "sukuna.silva" }; // Criar o array de nomes de usuários
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };

        List<string> listaMaiusculas = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        List<string> listaNumeros = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        List<string> listaMinusculas = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        List<char> listaEspaco = new List<char>() { '!', '@', '#', '$', '%', '&', '*' };


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
        {       // novas variaveis criadas para a parte CADASTRAR
            string novoUsuario = TextboxLogin.Text;
            string novaSenha = TextboxLogin.Text;

            // Comando para caso o usuario deixe em branco o login
            if (string.IsNullOrEmpty(novoUsuario))
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



            bool UsuarioEncontrado = false;
            for (int i = 0; i < listaUsuarios.Count; i++)


            {
                if (novaSenha.Length < 8) ;
                {
                    if (novoUsuario == listaUsuarios[i])
                    {
                        UsuarioEncontrado = true;

                    }
                    ResultadoCadastrar.Text = "A senha deve ter pelo menos 8 caracteres";
                    return;
                }
            }
            if (!UsuarioEncontrado)
                if (!novaSenha.Any(char.IsUpper))
                {
                    listaUsuarios.Add(novoUsuario); // adiciona a lista usuario
                    listaSenhas.Add(novaSenha);// addciona a lista Senhas
                    ResultadoCadastrar.Text = "Usuario Cadastrado";
                    ResultadoCadastrar.ForeColor = Color.Green;
                    ResultadoCadastrar.Text = "A senha deve ter pelo menos uma letra maiuscula";
                    return;
                }




                // comando para avisar que ja esxiste usuario com o mesmo nome 
                else
             if (!novaSenha.Any(char.IsLower))
                {
                    ResultadoCadastrar.Text = "A senha deve ter pelo menos uma letra minuscula";
                    return;
                }
            if (!novaSenha.Any(char.IsDigit))
            {
                ResultadoCadastrar.Text = "Já existe um usuário cadastrado";
                ResultadoCadastrar.Text = "A senha deve ter pelo menos um numero";
                return;
                {


                }
            }
            if (!novaSenha.Any(char.IsPunctuation))
            {
                ResultadoCadastrar.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }
            if (novaSenha.Contains(' '))
            {
                ResultadoCadastrar.Text = "A senha nao deve ter espacos em branco";
                return;

            }
            if (listaUsuarios.Contains(novoUsuario))
            {
                ResultadoCadastrar.Text = "Já existe um usuário cadastrado";
                return;
            }
            
            
            listaUsuarios.Add(novoUsuario);
            listaSenhas.Add(novaSenha);
            ResultadoCadastrar.Text = "Usuário cadastrado com sucesso!";
            








        }
           


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailCadastrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
            
           

        
      




