namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LimparTextBox()
        {
            Numero1.Clear();
            Numerodois.Clear();
        }

        private bool ValidarForm()
        {
            if (string.IsNullOrWhiteSpace(Numero1.Text))
            {
                LabelRsultado.Text = "O valor 1 eh obrigatorio.";
                Numero1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(Numerodois.Text))
            {
                LabelRsultado.Text = "O valor 2 eh obrigatorio.";
                Numerodois.Focus();
                return false;
            }

            try
            {
                double doubleValor1 = Convert.ToDouble(Numero1.Text);
                double doubleValor2 = Convert.ToDouble(Numerodois.Text);

                return true;
            }
            catch
            {
                LabelRsultado.Text = "Insira somente numeros";
                LimparTextBox();
                Numero1.Focus();
                return false;
            }
        }

        private static double Somar(double val1, double val2)
        {
            return val1 + val2;
        }

        private static double Subtrair(double val1, double val2)
        {
            return val1 - val2;
        }

        private static double Multiplicar(double val1, double val2)
        {
            return val1 * val2;
        }

        private static double Dividir(double val1, double val2)
        {
            return val1 / val2;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
            LabelRsultado.Text = "";

            if (!ValidarForm())
            {
                return;
            }

            double doubleValor1 = Convert.ToDouble(Numero1.Text);
            double doubleValor2 = Convert.ToDouble(Numerodois.Text);
            double resultado;

            switch (labelOperacao.Text)
            {
                case "+":
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
                case "-":
                    resultado = Subtrair(doubleValor1, doubleValor2);
                    break;
                case "*":
                    resultado = Multiplicar(doubleValor1, doubleValor2);
                    break;
                case "/":
                    resultado = Dividir(doubleValor1, doubleValor2);
                    break;
                default:
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
            }

            textBoxResultado.Text = Convert.ToString(resultado);
            LimparTextBox();
        }

        private void radioButtonSoma_CheckedChanged(object sender, EventArgs e)
        {
            Numero1.Visible = true;
            labelOperacao.Text = "+";
        }

        private void radioButtonSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            labelOperacao.Text = "-";
        }

        private void radioButtonMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            labelOperacao.Text = "*";
        }

        private void radioButtonDivisao_CheckedChanged(object sender, EventArgs e)
        {
            labelOperacao.Text = "/";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoForm novoForm = new NovoForm();
            novoForm.Show();

            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
            LabelRsultado.Text = "";

            if (!ValidarForm())
            {
                return;
            }

            double doubleValor1 = Convert.ToDouble(Numero1.Text);
            double doubleValor2 = Convert.ToDouble(Numerodois.Text);
            double resultado;

            switch (labelOperacao.Text)
            {
                case "+":
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
                case "-":
                    resultado = Subtrair(doubleValor1, doubleValor2);
                    break;
                case "*":
                    resultado = Multiplicar(doubleValor1, doubleValor2);
                    break;
                case "/":
                    resultado = Dividir(doubleValor1, doubleValor2);
                    break;
                default:
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
            }

            textBoxResultado.Text = Convert.ToString(resultado);
            LimparTextBox();

        }

        private void labelOperacao_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



