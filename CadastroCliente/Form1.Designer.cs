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
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            label9 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox9 = new TextBox();
            textBoxLogradouro = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            comboBox3 = new ComboBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            labelLogradouro = new Label();
            labelErro = new Label();
            label10 = new Label();
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
            label2.Location = new Point(342, 81);
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
            label3.Location = new Point(32, 157);
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
            label6.Location = new Point(260, 212);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 9;
            label6.Text = "Data de Nascimento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(378, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(342, 115);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 11;
            label7.Text = "Genero";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Feminino ", "Mascullino", "Prefiro Não Informar" });
            comboBox1.Location = new Point(411, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 211);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 13;
            label8.Text = "Etnia";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Branco(a)", "Negro(a)", "Pardo (a)", "Indigena ", "Asiatico (a)", "outros", "Prefiro Não Informar" });
            comboBox2.Location = new Point(117, 203);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 14;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(412, 78);
            maskedTextBox1.Mask = "(00)00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(121, 23);
            maskedTextBox1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(431, 147);
            label9.Name = "label9";
            label9.Size = new Size(80, 17);
            label9.TabIndex = 16;
            label9.Text = "Estrangeiro";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(487, 177);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(46, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Sim";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(411, 177);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(48, 19);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Não";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(108, 263);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxLogradouro);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(labelLogradouro);
            groupBox1.Location = new Point(66, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 292);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            button2.Location = new Point(213, 263);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(162, 189);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 13;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(83, 136);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(100, 23);
            textBoxLogradouro.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(303, 39);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(303, 89);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(83, 39);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(83, 84);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(309, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(35, 92);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 6;
            label16.Text = "Cep";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(35, 39);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 5;
            label15.Text = "Estado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(224, 47);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 4;
            label14.Text = "Municipio ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(250, 97);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 3;
            label13.Text = "Bairro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(61, 197);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 2;
            label12.Text = "Complemento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(237, 144);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 1;
            label11.Text = "Numero";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(8, 144);
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
            label10.Location = new Point(232, 267);
            label10.Name = "label10";
            label10.Size = new Size(123, 31);
            label10.TabIndex = 22;
            label10.Text = "Endereço";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 605);
            Controls.Add(label10);
            Controls.Add(labelErro);
            Controls.Add(groupBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label9);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label9;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private GroupBox groupBox1;
        private Label labelLogradouro;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBox9;
        private TextBox textBoxLogradouro;
        private TextBox textBox7;
        private TextBox textBox6;
        private ComboBox comboBox3;
        private TextBox textBox5;
        private TextBox textBox3;
        private Button button2;
        private Label labelErro;
        private Label label10;
    }
}
