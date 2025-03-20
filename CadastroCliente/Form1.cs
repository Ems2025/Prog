using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Cliente> NovosClientes = new List<Cliente>();

        public Form1()
        {

            InitializeComponent();

            EnderecoCliente EndEms = new EnderecoCliente() { Bairro = "Cidade Domitila", CEP = "04387002", Complemento = "casa 2", Estado = "Sao Paulo", Numero = "188", Logadouro = "travessa da rua da feira", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 2, Nome = "Emily", DataNascimento = " 19/02/1997", Email = "Emily@email.com", Telefone = "56229552", Endereco = EndEms, Genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Negro, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });

            EnderecoCliente EndSan = new EnderecoCliente() { Bairro = "Cidade Domitila", CEP = "04387002", Complemento = "casa 1", Estado = "Sao Paulo", Numero = "188", Logadouro = "rua do mercado Ricoy", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 3, Nome = "San", DataNascimento = " 04/09/1971", Email = "Sandra@email.com", Telefone = "56259522", Endereco = EndSan, Genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Pardo, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });

            EnderecoCliente EndAlex = new EnderecoCliente() { Bairro = "Vila Joaniza", CEP = "04429300", Complemento = "casa 3", Estado = "Sao Paulo", Numero = "188", Logadouro = "Ladiera 1", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 4, Nome = "Alex", DataNascimento = " 28/10/1994", Email = "Alex@email.com", Telefone = "56443558", Endereco = EndAlex, Genero = GeneroCliente.Masculino, Etnia = EtniaCliente.Branco, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });

            NovosClientes.Add(new Cliente() { Nome = textBoxNome.Text, DataNascimento = maskedDataNascimento.Text, Email = textBoxEmail.Text, Telefone = maskedTelefone.Text, });




        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxNome.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Insira Somente Letras");
                return;
            }

            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                MessageBox.Show("Nome é Obrigatório");
                textBoxNome.Focus();
                return;
            }

            if (!textBoxEmail.Text.Any(char.IsPunctuation) && !textBoxEmail.Text.Contains('@'))

            {
                MessageBox.Show("O Email não é Válido");
                return;
            }

            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Email é Obrigatório");
                textBoxEmail.Focus();
                return;

            }

            if (comboBoxEtnia.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecione a Etnia");

                return;
            }

            if (comboBoxGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor Selecione o Genero");
                return;
            }


            if (!checkBoxNão.Checked)

            {
                MessageBox.Show("Por favor informe se você é estrangeiro(a)");
                return;

            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecione o Estado");

                return;
            }

            if (string.IsNullOrEmpty(maskedCep.Text) || maskedCep.MaskCompleted == false)
            {
                MessageBox.Show("CEP invalido");
                return;
            }

            if (textBoxBairro.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Insira Somente Letras");
                return;
            }


            if (string.IsNullOrEmpty(textBoxBairro.Text))
            {
                MessageBox.Show("Bairro é Obrigatório");
                textBoxBairro.Focus();
                return;

            }


            if (string.IsNullOrEmpty(textBoxNumero.Text))
            {
                MessageBox.Show("Numero é Obrigatório");
                textBoxNumero.Focus();
                return;
            }

            if (textBoxMunicipio.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Insira Somente Letras");
                return;
            }

            if (string.IsNullOrEmpty(textBoxMunicipio.Text))
            {
                MessageBox.Show("Municipio é Obrigatório");
                textBoxNumero.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBoxlogradouro.Text))
            {
                MessageBox.Show("Numero é Obrigatório");
                textBoxlogradouro.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBoxComplemento.Text))
            {
                MessageBox.Show("Numero é Obrigatório");
                textBoxComplemento.Focus();
                return;
            }
















        }

        private void checkBoxNão_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}






