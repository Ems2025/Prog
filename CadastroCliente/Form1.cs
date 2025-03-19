namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {

            InitializeComponent();

            EnderecoCliente EndEms = new EnderecoCliente() { Bairro = "Cidade Domitila", CEP = "04387002", Complemento = "casa 2", Estado = "Sao Paulo", Numero = "188", Logadouro = "travessa da rua da feira", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 2, Nome = "Emily", DataNascimento = " 19/02/1997", Email = "Emily@email.com", Telefone = "56229552", Endereco = EndEms, Genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Negro, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });

            EnderecoCliente EndSan = new EnderecoCliente() { Bairro = "Cidade Domitila", CEP = "04387002", Complemento = "casa 1", Estado = "Sao Paulo", Numero = "188", Logadouro = "rua do mercado Ricoy", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 3, Nome = "San", DataNascimento = " 04/09/1971", Email = "Sandra@email.com", Telefone = "56259522", Endereco = EndSan, Genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Pardo, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });

            EnderecoCliente EndAlex = new EnderecoCliente() { Bairro = "Vila Joaniza", CEP = "04429300", Complemento = "casa 3", Estado = "Sao Paulo", Numero = "188", Logadouro = "Ladiera 1", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 4, Nome = "Alex", DataNascimento = " 28/10/1994", Email = "Alex@email.com", Telefone = "56443558", Endereco = EndAlex, Genero = GeneroCliente.Masculino, Etnia = EtniaCliente.Branco, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBoxLogradouro.Text))
            {
                labelErro.Text = "Preenchimento Obrigatorio";
                textBoxLogradouro.Focus();
                labelErro.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty (textBoxNome.Text))
            {
                labelErro.Text = "Preenchimento Obrigatorio";
                textBoxNome.Focus();
                labelErro.ForeColor = Color.Red;    
                return; 
            }
            if (string.IsNullOrWhiteSpace(textBoxNomeSocial.Text))
            {
                labelErro.Text = "Preenchimento Obrigatorio";
                textBoxNomeSocial.Focus();  
                labelErro.ForeColor = Color.Red; 
                return;

            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                labelErro.Text = "Preenchimento Obrigatorio";
                textBoxEmail.Focus();
                labelErro.ForeColor = Color.Red; 
                return;


            }



        }
    }
}






