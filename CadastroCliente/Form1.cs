using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        private readonly BindingSource BindingSource = [];

        public Form1()
        {

            InitializeComponent();

            EnderecoCliente EndEms = new EnderecoCliente() { Bairro = "Cidade Domitila", CEP = "04387002", Complemento = "casa 2", Estado = "Sao Paulo", Numero = "188", Logadouro = "travessa da rua da feira", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 2, Nome = "Emily", DataNascimento = " 19/02/1997", Email = "Emily@email.com", Telefone = "11940430014", Endereco = EndEms, Genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Negro, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });

            EnderecoCliente EndSan = new EnderecoCliente() { Bairro = "Cidade Domitila", CEP = "04387002", Complemento = "casa 1", Estado = "Sao Paulo", Numero = "188", Logadouro = "rua do mercado Ricoy", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 3, Nome = "San", DataNascimento = " 04/09/1971", Email = "Sandra@email.com", Telefone = "56259522", Endereco = EndSan, Genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Pardo, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });

            EnderecoCliente EndAlex = new EnderecoCliente() { Bairro = "Vila Joaniza", CEP = "04429300", Complemento = "casa 3", Estado = "Sao Paulo", Numero = "188", Logadouro = "Ladiera 1", Municipio = "Sao Paulo" };

            clientes.Add(new Cliente() { Id = 4, Nome = "Alex", DataNascimento = " 28/10/1994", Email = "Alex@email.com", Telefone = "56443558", Endereco = EndAlex, Genero = GeneroCliente.Masculino, Etnia = EtniaCliente.Branco, NomeSocial = "Não tenho", Estrangeiro = false, Tipo = TipoCliente.PF });

            BindingSource.DataSource = clientes;
            DataGridViewCliente.DataSource = BindingSource;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // verifica se tem numero e mostra mensagem de erro 
            if (textBoxNome.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Insira Somente Letras");
                return;
            }
            //valida nome 
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                MessageBox.Show("Nome é Obrigatório");
                textBoxNome.Focus();
                return;
            }

            // verifica se o campo emais está vazio 
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Email é Obrigatório");
                textBoxEmail.Focus();
                return;

            }

            //verifica se tem caracteres especiais no email
            if (!textBoxEmail.Text.Any(char.IsPunctuation) && !textBoxEmail.Text.Contains('@'))

            {
                MessageBox.Show(" Email invalido ");
                return;

            }

            //Verifica se o email ja existe 
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Email == textBoxEmail.Text)
                {
                    MessageBox.Show("Email já existe");
                    return;

                }
            }
            //Valida  etnia
            if (comboBoxEtnia.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecione a Etnia");

                return;
            }


            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Telefone == maskedTelefone.Text)
                {
                    MessageBox.Show("Numero de telefone já cadastrado");
                    return;
                }

            }




            // verifica se o campo telefone está em branco
            if (string.IsNullOrEmpty(maskedTelefone.Text))
            {
                MessageBox.Show("Telefone é Obrigatório");
                maskedTelefone.Focus();
                return;

            }





            if (comboBoxGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor Selecione o Genero");
                return;
            }


            // validaçao da data 
            if (string.IsNullOrEmpty(maskedDataNascimento.Text))
            {
                MessageBox.Show("Por favor insira a data de nascimento");
                maskedDataNascimento.Focus();
                return;

            }

            //verifica se a Data é Valida
            try
            {
                Convert.ToDateTime(maskedDataNascimento.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Data de nascimento não é válida");
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


            if (string.IsNullOrEmpty(textBoxMunicipio.Text))
            {
                MessageBox.Show("Municipio é Obrigatório");
                textBoxNumero.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBoxlogradouro.Text))
            {
                MessageBox.Show("Logradouro é Obrigatório");
                textBoxlogradouro.Focus();
                return;
            }

            clientes.Add(new Cliente() { Nome = textBoxNome.Text, DataNascimento = maskedDataNascimento.Text, Email = textBoxEmail.Text, NomeSocial = textBoxMunicipio.Text });  















            BindingSource.ResetBindings(false);
        }

    }
}





































