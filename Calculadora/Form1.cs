namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string num1 = Numero1.Text;
            string num2 = Numerodois.Text;

            double doublenum1 = Convert.ToDouble(num1);
            double doublenum2 = Convert.ToDouble(num2);

            if (!num1.All(char.IsNumber))
            {
                LabelRsultado.Text = "o valor 1 deve ser um numero";
                return;
            }

            if (!num2.All(char.IsNumber))
            {
                LabelRsultado.Text = "o valor 2 deve ser um numero";
                return;
            }

            double resultado = doublenum1 + doublenum2;


            LabelRsultado.Text = resultado.ToString();
        }
        private void Subtração_Click(object sender, EventArgs e)
        {
            string num1 = Numero1.Text;
            string num2 = Numerodois.Text;

            double doublenum1 = Convert.ToDouble(num1);
            double doublenum2 = Convert.ToDouble(num2);

            if (!num1.All(char.IsNumber))
            {
                LabelRsultado.Text = "o valor 1 deve ser um numero";
                return;
            }

            if (!num2.All(char.IsNumber))
            {
                LabelRsultado.Text = "o valor 2 deve ser um numero";
                return;
            }

            double resultado = doublenum1 - doublenum2;


            LabelRsultado.Text = resultado.ToString();
        }
        private void multiplicação_Click(object sender, EventArgs e)
        {
            string num1 = Numero1.Text;
            string num2 = Numerodois.Text;

            double doublenum1 = Convert.ToDouble(num1);
            double doublenum2 = Convert.ToDouble(num2);

            if (!num1.All(char.IsNumber))
            {
                LabelRsultado.Text = "o valor 1 deve ser um numero";
                return;
            }

            if (!num2.All(char.IsNumber))
            {
                LabelRsultado.Text = "o valor 2 deve ser um numero";
                return;
            }

            double resultado = doublenum1 * doublenum2;


            LabelRsultado.Text = resultado.ToString();
        }
        private void divisão_Click(object sender, EventArgs e)
        {
            string num1 = Numero1.Text;
            string num2 = Numerodois.Text;

            double doublenum1 = Convert.ToDouble(num1);
            double doublenum2 = Convert.ToDouble(num2);

            if (!num1.All(char.IsNumber))
            {
                LabelRsultado.Text = "o valor 1 deve ser um numero";
                return;
            }

            if (!num2.All(char.IsNumber))
            {
                LabelRsultado.Text = "o valor 2 deve ser um numero";
                return;
            }

            double resultado = doublenum1 / doublenum2;


            LabelRsultado.Text = resultado.ToString();











        }
    }
}
