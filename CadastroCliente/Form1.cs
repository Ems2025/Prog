using System.Security.Permissions;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {

            InitializeComponent();

            EnderecoCliente EndEms = new EnderecoCliente() { Bairro = "Cidade Domitila", CEP = "04387002", Complemento = "casa 2", Estado = "Sao Paulo", Numero = "188", Logadouro = "travessa da rua da feira", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 3, Nome = "Emily", DataNascimento = " 19/02/1997", Email = "Emily@email.com", Telefone = "56229552", Endereco = EndEms, Genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Negro, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });



        }
        private void label1_Click(object sender, EventArgs e)
            {

            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }
        }
    }
        





