using System.Diagnostics.Eventing.Reader;

namespace Login
{

    public partial class Formslogin : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.Vittar}","sukuna.silva" }; // Criar o array de nomes de usuários

        public Formslogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string loginbuscado = TextboxLogin.Text;
            string Senha = textboxSenha.Text;
            Resultado.Text = loginbuscado;
            
            if(string.IsNullOrWhiteSpace(loginbuscado))
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
                if (posicaologinEncontrado > -1 && Senha == "12345")
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
    }
}
            
           

        
      

