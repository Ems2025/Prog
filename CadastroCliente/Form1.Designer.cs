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
            buttonsalvar = new Button();
            groupBox1 = new GroupBox();
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
            label10 = new Label();
            maskedDataNascimento = new MaskedTextBox();
            label17 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label18 = new Label();
            textBoxRua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 86);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(112, 80);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(200, 23);
            textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(369, 80);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(112, 114);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(201, 23);
            textBoxNomeSocial.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 157);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 115);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 6;
            label4.Text = "Nome Social";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(84, 151);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(243, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calisto MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(232, 27);
            label5.Name = "label5";
            label5.Size = new Size(155, 31);
            label5.TabIndex = 8;
            label5.Text = "Cadastre-se";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(341, 157);
            label6.Name = "label6";
            label6.Size = new Size(115, 14);
            label6.TabIndex = 9;
            label6.Text = "Data de Nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(375, 113);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 11;
            label7.Text = "Genero";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Feminino ", "Mascullino", "Prefiro Não Informar" });
            comboBoxGenero.Location = new Point(441, 112);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 211);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 13;
            label8.Text = "Etnia";
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco(a)", "Negro(a)", "Pardo (a)", "Indigena ", "Asiatico (a)", "outros", "Prefiro Não Informar" });
            comboBoxEtnia.Location = new Point(117, 203);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(121, 23);
            comboBoxEtnia.TabIndex = 14;
            // 
            // maskedTelefone
            // 
            maskedTelefone.Location = new Point(441, 75);
            maskedTelefone.Mask = "(00)00000-0000";
            maskedTelefone.Name = "maskedTelefone";
            maskedTelefone.Size = new Size(121, 23);
            maskedTelefone.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(376, 202);
            label9.Name = "label9";
            label9.Size = new Size(80, 17);
            label9.TabIndex = 16;
            label9.Text = "Estrangeiro";
            // 
            // checkBoxNão
            // 
            checkBoxNão.AutoSize = true;
            checkBoxNão.Location = new Point(463, 202);
            checkBoxNão.Name = "checkBoxNão";
            checkBoxNão.Size = new Size(48, 19);
            checkBoxNão.TabIndex = 18;
            checkBoxNão.Text = "Não";
            checkBoxNão.UseVisualStyleBackColor = true;
            checkBoxNão.CheckedChanged += checkBoxNão_CheckedChanged;
            // 
            // buttonsalvar
            // 
            buttonsalvar.Location = new Point(205, 224);
            buttonsalvar.Name = "buttonsalvar";
            buttonsalvar.Size = new Size(75, 23);
            buttonsalvar.TabIndex = 19;
            buttonsalvar.Text = "Salvar";
            buttonsalvar.UseVisualStyleBackColor = true;
            buttonsalvar.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxRua);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(maskedCep);
            groupBox1.Controls.Add(textBoxComplemento);
            groupBox1.Controls.Add(buttonsalvar);
            groupBox1.Controls.Add(textBoxBairro);
            groupBox1.Controls.Add(textBoxNumero);
            groupBox1.Controls.Add(comboBoxEstado);
            groupBox1.Controls.Add(textBoxlogradouro);
            groupBox1.Controls.Add(textBoxMunicipio);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(labelLogradouro);
            groupBox1.Location = new Point(56, 345);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 248);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // maskedCep
            // 
            maskedCep.Location = new Point(83, 125);
            maskedCep.Mask = "00000-000";
            maskedCep.Name = "maskedCep";
            maskedCep.Size = new Size(121, 23);
            maskedCep.TabIndex = 21;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(190, 195);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(100, 23);
            textBoxComplemento.TabIndex = 13;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(310, 44);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(100, 23);
            textBoxBairro.TabIndex = 11;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(310, 92);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(100, 23);
            textBoxNumero.TabIndex = 10;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            comboBoxEstado.Location = new Point(83, 92);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 23);
            comboBoxEstado.TabIndex = 9;
            // 
            // textBoxlogradouro
            // 
            textBoxlogradouro.Location = new Point(83, 166);
            textBoxlogradouro.Name = "textBoxlogradouro";
            textBoxlogradouro.Size = new Size(121, 23);
            textBoxlogradouro.TabIndex = 8;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(310, 149);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(100, 23);
            textBoxMunicipio.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 133);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 6;
            label16.Text = "Cep";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 100);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 5;
            label15.Text = "Estado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(249, 157);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 4;
            label14.Text = "Municipio ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(259, 44);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 3;
            label13.Text = "Bairro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(83, 203);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 2;
            label12.Text = "Complemento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(253, 100);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 1;
            label11.Text = "Numero";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(8, 174);
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calisto MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(56, 311);
            label10.Name = "label10";
            label10.Size = new Size(123, 31);
            label10.TabIndex = 22;
            label10.Text = "Endereço";
            // 
            // maskedDataNascimento
            // 
            maskedDataNascimento.Location = new Point(462, 151);
            maskedDataNascimento.Mask = "00/00/0000";
            maskedDataNascimento.Name = "maskedDataNascimento";
            maskedDataNascimento.Size = new Size(100, 23);
            maskedDataNascimento.TabIndex = 23;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(366, 278);
            label17.Name = "label17";
            label17.Size = new Size(85, 15);
            label17.TabIndex = 24;
            label17.Text = "Tipo de Pessoa";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(462, 296);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(36, 19);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "PJ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(462, 257);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(39, 19);
            checkBox2.TabIndex = 26;
            checkBox2.Text = "PF";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(9, 61);
            label18.Name = "label18";
            label18.Size = new Size(27, 15);
            label18.TabIndex = 22;
            label18.Text = "Rua";
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(82, 58);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(100, 23);
            textBoxRua.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 605);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label17);
            Controls.Add(maskedDataNascimento);
            Controls.Add(label10);
            Controls.Add(labelErro);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button buttonsalvar;
        private GroupBox groupBox1;
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
        private Label label10;
        private MaskedTextBox maskedCep;
        private MaskedTextBox maskedDataNascimento;
        private Label label17;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBoxRua;
        private Label label18;
    }
}
