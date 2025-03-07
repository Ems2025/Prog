namespace Login
{
    partial class Formslogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formslogin));
            TextboxLogin = new TextBox();
            textboxSenha = new TextBox();
            buttonEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            Resultado = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            Cadastrar = new Label();
            ResultadoCadastrar = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TextboxLogin
            // 
            TextboxLogin.Location = new Point(429, 150);
            TextboxLogin.Name = "TextboxLogin";
            TextboxLogin.Size = new Size(100, 23);
            TextboxLogin.TabIndex = 0;
            // 
            // textboxSenha
            // 
            textboxSenha.Location = new Point(429, 189);
            textboxSenha.Name = "textboxSenha";
            textboxSenha.Size = new Size(100, 23);
            textboxSenha.TabIndex = 1;
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = SystemColors.Control;
            buttonEntrar.Location = new Point(445, 260);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(75, 23);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 158);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 197);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 197);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = SystemColors.GradientInactiveCaption;
            labelTitulo.Font = new Font("Segoe Script", 30F);
            labelTitulo.Location = new Point(142, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(362, 64);
            labelTitulo.TabIndex = 6;
            labelTitulo.Text = "Bike For Health";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-86, -276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(786, 936);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(429, 224);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(38, 15);
            Resultado.TabIndex = 8;
            Resultado.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 158);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 9;
            label4.Text = "LabelEmail";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 205);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 12;
            label5.Text = "Senha";
            // 
            // button1
            // 
            button1.Location = new Point(142, 260);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Cadastrar
            // 
            Cadastrar.AutoSize = true;
            Cadastrar.Location = new Point(162, 105);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(57, 15);
            Cadastrar.TabIndex = 14;
            Cadastrar.Text = "Cadastrar";
            // 
            // ResultadoCadastrar
            // 
            ResultadoCadastrar.AutoSize = true;
            ResultadoCadastrar.Location = new Point(142, 224);
            ResultadoCadastrar.Name = "ResultadoCadastrar";
            ResultadoCadastrar.Size = new Size(38, 15);
            ResultadoCadastrar.TabIndex = 15;
            ResultadoCadastrar.Text = "label6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(445, 105);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 16;
            label6.Text = "Entrar";
            // 
            // Formslogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(576, 402);
            Controls.Add(label6);
            Controls.Add(ResultadoCadastrar);
            Controls.Add(Cadastrar);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(Resultado);
            Controls.Add(labelTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEntrar);
            Controls.Add(textboxSenha);
            Controls.Add(TextboxLogin);
            Controls.Add(pictureBox1);
            Name = "Formslogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextboxLogin;
        private TextBox textboxSenha;
        private Button buttonEntrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelTitulo;
        private PictureBox pictureBox1;
        private Label Resultado;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Button button1;
        private Label Cadastrar;
        private Label ResultadoCadastrar;
        private Label label6;
    }
}
