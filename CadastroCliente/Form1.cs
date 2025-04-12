using System.Text.RegularExpressions;
using CadastroCliente.Dominio;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        private readonly Cliente Cliente = new();

        private readonly List<Cliente> clientes = [];
        private readonly BindingSource BindingSource = [];

        
       

        public Form1()
        {

            InitializeComponent();

           

        }

        private MaskedTextBox GetMaskedDataNascimento()
        {
            return maskedDataNascimento;
        }

        private void button1_Click(object sender, EventArgs e, MaskedTextBox maskedDataNascimento)
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

            // verifica se o campo email está vazio 
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


            //Valida Telefone
            string telefone = Regex.Replace(maskedTelefone.Text, "[^0-9]", "");

            // Verifica se o telefone tem 10 ou 11 dígitos (fixo ou celular)
            if (telefone.Length == 10 || telefone.Length == 11)
            {
            }
            else
            {
                MessageBox.Show("Telefone inválido!");
            }

            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Telefone == maskedTelefone.Text)
                {
                    MessageBox.Show("Numero de telefone já cadastrado");
                    return;
                }

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


            //Valida  etnia
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

            if (!radioButtonPF.Checked && !radioButtonPJ.Checked) 
            {
                MessageBox.Show("Por Favor, informe se você é pessoa fisica ou juridica");
                return;
            }
            if (string.IsNullOrEmpty(textBoxEndereco.Text))
            {
                MessageBox.Show(" Endereço é Obrigatório");
                textBoxEndereco.Focus();
                return;

            }
            if (string.IsNullOrEmpty(maskedCep.Text) || maskedCep.MaskCompleted == false)
            {
                MessageBox.Show("CEP invalido");
                return;
            }
            if (string.IsNullOrEmpty(textBoxNumero.Text))
            {
                MessageBox.Show("Numero é Obrigatório");
                textBoxNumero.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxlogradouro.Text))
            {
                MessageBox.Show("Logradouro é Obrigatório");
                textBoxlogradouro.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBoxBairro.Text))
            {
                MessageBox.Show("Bairro é Obrigatório");
                textBoxBairro.Focus();
                return;

            }
            if (string.IsNullOrEmpty(textBoxMunicipio.Text))
            {
                MessageBox.Show("Municipio é Obrigatório");
                textBoxNumero.Focus();
                return;
            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecione o Estado");

                return;
            }
            TipoCliente tipo = 0;
            if (radioButtonPJ.Checked)
            {
                tipo = TipoCliente.PJ;  
            }
            if (radioButtonPF.Checked)
            {
                tipo = TipoCliente.PF;
            }

            clientes.Add(new Cliente()
            {
                Nome = textBoxNome.Text,
                DataNascimento = maskedDataNascimento.Text,
                Email = textBoxEmail.Text,
                NomeSocial = textBoxNomeSocial.Text,
                Endereco = new EnderecoCliente()
                {
                    Bairro = textBoxBairro.Text,
                    CEP = maskedCep.Text,
                    Logradouro = textBoxlogradouro.Text,
                    Complemento = textBoxComplemento.Text,
                    Estado = comboBoxEstado.Text,
                    Municipio = textBoxMunicipio.Text,
                    Numero = textBoxNumero.Text
                },
                Genero = (GeneroCliente)comboBoxGenero.SelectedIndex,
                Etnia = (EtniaCliente)comboBoxEtnia.SelectedIndex,
                Estrangeiro = checkBoxNão.Checked,
                Tipo = tipo,
                Telefone = maskedTelefone.Text, 

            });

            BindingSource.ResetBindings(false);


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}








































