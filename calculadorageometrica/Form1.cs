namespace calculadorageometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOpcao.SelectedItem == null)
            {
                labelErro.Text = "Selecione um opção";
                return;
            }
            if (comboBoxOpcao.SelectedItem.ToString() == "Quadrado")
            {
                groupBoxQuadrado.Visible = true;
                groupBoxRetangulo.Visible = false;
                groupBoxQuadrado.BringToFront();
                groupBoxRetangulo.SendToBack();
                return;
            }
            if (comboBoxOpcao.SelectedItem.ToString() == "Retangulo")
            {
                groupBoxQuadrado.Visible = false;
                groupBoxRetangulo.Visible = true;
                groupBoxQuadrado.SendToBack();
                groupBoxRetangulo.BringToFront();
                return;
            }

        }

        private void radioButtonPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimento.Enabled = false;
        }

        private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimento.Enabled = false;
        }

        private void radioButtonVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimento.Enabled = true;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            labelErro.Text = "";

            if (radioButtonPerimetro.Checked)
            {
                string largura = textBoxAltura.Text;
                string altura = textBoxAltura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }
                double resultado = (Convert.ToDouble(altura) * 2) + (Convert.ToDouble(largura) * 2);

                textBoxResultado.Text = resultado.ToString();
                return;
            }




            if (radioButtonArea.Checked)
            {
                string largura = textBoxAltura.Text;
                string altura = textBoxAltura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }

                double resultado = Convert.ToDouble(altura) * Convert.ToDouble(largura);

                textBoxResultado.Text = resultado.ToString();
                return;
            }
            if (radioButtonVolume.Checked)
            {
                string largura = textBoxLargura.Text;
                string altura = textBoxAltura.Text;
                string comprimento = textBoxComprimento.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(comprimento) || !comprimento.All(char.IsNumber))
                {
                    labelErro.Text = "Insira um comprimento valido.";
                    return;
                }

                double resultado = Convert.ToDouble(altura) * Convert.ToDouble(largura) * Convert.ToDouble(comprimento);

                textBoxResultado.Text = resultado.ToString();
                return;
            }

        }

        private void comboBoxOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonCalcularQuadradro_Click(object sender, EventArgs e)
        {
            labelErro.Text = "";
            if (radioButtonAreaQuadrado.Checked)
            {
                string larguraQuadrado = txtLarguraQuadrado.Text;
                string alturaQuadrado = txtAlturaQuadrado.Text;
                if 
                    (string.IsNullOrWhiteSpace(larguraQuadrado) || !larguraQuadrado.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(alturaQuadrado) || !alturaQuadrado.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }
                double resultado = Convert.ToDouble(alturaQuadrado) * Convert.ToDouble(larguraQuadrado);

                textBoxResultadoQuadrado.Text = resultado.ToString();
                return;
            }
            if (radioButtonPerimetroquadrado.Checked)
            {

                string larguraQuadrado = txtLarguraQuadrado.Text;
                string alturaQuadrado = txtAlturaQuadrado.Text;
                if
                    (string.IsNullOrWhiteSpace(larguraQuadrado) || !larguraQuadrado.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(alturaQuadrado) || !alturaQuadrado.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }
                double resultado = Convert.ToDouble(alturaQuadrado) * Convert.ToDouble(larguraQuadrado);

                textBoxResultadoQuadrado.Text = resultado.ToString();
                return;
            }

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}