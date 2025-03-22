namespace CadastroCliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            textBoxNomeSocial = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxGenero = new ComboBox();
            label8 = new Label();
            comboBoxEtnia = new ComboBox();
            maskedTelefone = new MaskedTextBox();
            label9 = new Label();
            checkBoxNão = new CheckBox();
            textBoxEndereco = new TextBox();
            label18 = new Label();
            maskedCep = new MaskedTextBox();
            textBoxComplemento = new TextBox();
            textBoxBairro = new TextBox();
            textBoxNumero = new TextBox();
            comboBoxEstado = new ComboBox();
            textBoxlogradouro = new TextBox();
            textBoxMunicipio = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            labelLogradouro = new Label();
            labelErro = new Label();
            maskedDataNascimento = new MaskedTextBox();
            label17 = new Label();
            DataGridViewCliente = new DataGridView();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            radioButtonPJ = new RadioButton();
            radioButtonPF = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 94);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome*";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(108, 93);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(200, 23);
            textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 2;
            label2.Text = "Telefone *";
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(108, 128);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(201, 23);
            textBoxNomeSocial.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 4;
            label3.Text = "Email*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 6;
            label4.Text = "Nome Social";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(108, 157);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(229, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calisto MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(210, 24);
            label5.Name = "label5";
            label5.Size = new Size(263, 31);
            label5.TabIndex = 8;
            label5.Text = "Cadastro de Clientes";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 220);
            label6.Name = "label6";
            label6.Size = new Size(115, 14);
            label6.TabIndex = 9;
            label6.Text = "Data de Nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 293);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 11;
            label7.Text = "Genero";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Feminino ", "Mascullino", "Prefiro Não Informar" });
            comboBoxGenero.Location = new Point(108, 287);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 248);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 13;
            label8.Text = "Etnia";
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco(a)", "Negro(a)", "Pardo (a)", "Indigena ", "Asiatico (a)", "outros", "Prefiro Não Informar" });
            comboBoxEtnia.Location = new Point(108, 248);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(121, 23);
            comboBoxEtnia.TabIndex = 14;
            // 
            // maskedTelefone
            // 
            maskedTelefone.Location = new Point(108, 186);
            maskedTelefone.Mask = "(00)00000-0000";
            maskedTelefone.Name = "maskedTelefone";
            maskedTelefone.Size = new Size(121, 23);
            maskedTelefone.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 343);
            label9.Name = "label9";
            label9.Size = new Size(80, 17);
            label9.TabIndex = 16;
            label9.Text = "Estrangeiro";
            // 
            // checkBoxNão
            // 
            checkBoxNão.AutoSize = true;
            checkBoxNão.Location = new Point(108, 344);
            checkBoxNão.Name = "checkBoxNão";
            checkBoxNão.Size = new Size(48, 19);
            checkBoxNão.TabIndex = 18;
            checkBoxNão.Text = "Não";
            checkBoxNão.UseVisualStyleBackColor = true;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(479, 94);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(121, 23);
            textBoxEndereco.TabIndex = 23;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(420, 101);
            label18.Name = "label18";
            label18.Size = new Size(27, 15);
            label18.TabIndex = 22;
            label18.Text = "Rua";
            // 
            // maskedCep
            // 
            maskedCep.Location = new Point(479, 129);
            maskedCep.Mask = "00000-000";
            maskedCep.Name = "maskedCep";
            maskedCep.Size = new Size(121, 23);
            maskedCep.TabIndex = 21;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(479, 229);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(121, 23);
            textBoxComplemento.TabIndex = 13;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(479, 258);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(121, 23);
            textBoxBairro.TabIndex = 11;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(479, 162);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(121, 23);
            textBoxNumero.TabIndex = 10;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            comboBoxEstado.Location = new Point(479, 322);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 23);
            comboBoxEstado.TabIndex = 9;
            // 
            // textBoxlogradouro
            // 
            textBoxlogradouro.Location = new Point(479, 197);
            textBoxlogradouro.Name = "textBoxlogradouro";
            textBoxlogradouro.Size = new Size(121, 23);
            textBoxlogradouro.TabIndex = 8;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(479, 287);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(121, 23);
            textBoxMunicipio.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(420, 137);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 6;
            label16.Text = "Cep";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(420, 330);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 5;
            label15.Text = "Estado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(409, 295);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 4;
            label14.Text = "Municipio ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(420, 266);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 3;
            label13.Text = "Bairro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(389, 237);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 2;
            label12.Text = "Complemento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(407, 170);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 1;
            label11.Text = "Numero";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(404, 200);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(69, 15);
            labelLogradouro.TabIndex = 0;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(112, 177);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 21;
            // 
            // maskedDataNascimento
            // 
            maskedDataNascimento.Location = new Point(133, 216);
            maskedDataNascimento.Mask = "00/00/0000";
            maskedDataNascimento.Name = "maskedDataNascimento";
            maskedDataNascimento.Size = new Size(100, 23);
            maskedDataNascimento.TabIndex = 23;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(269, 205);
            label17.Name = "label17";
            label17.Size = new Size(85, 15);
            label17.TabIndex = 24;
            label17.Text = "Tipo de Pessoa";
            // 
            // DataGridViewCliente
            // 
            DataGridViewCliente.AllowUserToAddRows = false;
            DataGridViewCliente.AllowUserToDeleteRows = false;
            DataGridViewCliente.AllowUserToOrderColumns = true;
            DataGridViewCliente.AllowUserToResizeRows = false;
            DataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCliente.Location = new Point(12, 432);
            DataGridViewCliente.MultiSelect = false;
            DataGridViewCliente.Name = "DataGridViewCliente";
            DataGridViewCliente.ReadOnly = true;
            DataGridViewCliente.Size = new Size(588, 161);
            DataGridViewCliente.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(279, 321);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 29;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Clients_27015;
            pictureBox1.Location = new Point(108, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(20, 0, 0, 0);
            pictureBox1.Size = new Size(92, 49);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // radioButtonPJ
            // 
            radioButtonPJ.AutoSize = true;
            radioButtonPJ.Location = new Point(319, 235);
            radioButtonPJ.Name = "radioButtonPJ";
            radioButtonPJ.Size = new Size(35, 19);
            radioButtonPJ.TabIndex = 31;
            radioButtonPJ.TabStop = true;
            radioButtonPJ.Text = "PJ";
            radioButtonPJ.UseVisualStyleBackColor = true;
            // 
            // radioButtonPF
            // 
            radioButtonPF.AutoSize = true;
            radioButtonPF.Location = new Point(269, 237);
            radioButtonPF.Name = "radioButtonPF";
            radioButtonPF.Size = new Size(38, 19);
            radioButtonPF.TabIndex = 32;
            radioButtonPF.TabStop = true;
            radioButtonPF.Text = "PF";
            radioButtonPF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(627, 605);
            Controls.Add(radioButtonPF);
            Controls.Add(radioButtonPJ);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBoxComplemento);
            Controls.Add(label12);
            Controls.Add(maskedCep);
            Controls.Add(label18);
            Controls.Add(textBoxlogradouro);
            Controls.Add(labelLogradouro);
            Controls.Add(textBoxEndereco);
            Controls.Add(label16);
            Controls.Add(DataGridViewCliente);
            Controls.Add(comboBoxEstado);
            Controls.Add(textBoxBairro);
            Controls.Add(label15);
            Controls.Add(textBoxMunicipio);
            Controls.Add(textBoxNumero);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label17);
            Controls.Add(maskedDataNascimento);
            Controls.Add(labelErro);
            Controls.Add(label11);
            Controls.Add(checkBoxNão);
            Controls.Add(label9);
            Controls.Add(maskedTelefone);
            Controls.Add(comboBoxEtnia);
            Controls.Add(label8);
            Controls.Add(comboBoxGenero);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGridViewCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private TextBox textBoxNomeSocial;
        private Label label3;
        private Label label4;
        private TextBox textBoxEmail;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxGenero;
        private Label label8;
        private ComboBox comboBoxEtnia;
        private MaskedTextBox maskedTelefone;
        private Label label9;
        private CheckBox checkBoxNão;
        private Label labelLogradouro;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBoxComplemento;
        private TextBox textBoxLogradouro;
        private TextBox textBoxBairro;
        private TextBox textBoxNumero;
        private ComboBox comboBoxEstado;
        private TextBox textBoxlogradouro;
        private TextBox textBoxMunicipio;
        private Label labelErro;
        private MaskedTextBox maskedCep;
        private MaskedTextBox maskedDataNascimento;
        private Label label17;
        private TextBox textBoxEndereco;
        private Label label18;
        private DataGridView DataGridViewCliente;
        private Button button1;
        private PictureBox pictureBox1;
        private RadioButton radioButtonPJ;
        private RadioButton radioButtonPF;
    }
}
