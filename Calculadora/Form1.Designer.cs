namespace Calculadora
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
            Numero1 = new TextBox();
            Numerodois = new TextBox();
            LabelRsultado = new Label();
            label1 = new Label();
            RadBSoma = new RadioButton();
            radioButtonSubtração = new RadioButton();
            radioButtonDivisao = new RadioButton();
            radioButtonMultiplicacao = new RadioButton();
            buttonCalcular = new Button();
            textBoxResultado = new TextBox();
            labelOperacao = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Numero1
            // 
            Numero1.Location = new Point(21, 60);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(100, 23);
            Numero1.TabIndex = 0;
            Numero1.TextChanged += Numero1_TextChanged;
            // 
            // Numerodois
            // 
            Numerodois.Location = new Point(140, 60);
            Numerodois.Name = "Numerodois";
            Numerodois.Size = new Size(100, 23);
            Numerodois.TabIndex = 1;
            // 
            // LabelRsultado
            // 
            LabelRsultado.AutoSize = true;
            LabelRsultado.Location = new Point(140, 195);
            LabelRsultado.Name = "LabelRsultado";
            LabelRsultado.Size = new Size(0, 15);
            LabelRsultado.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 7;
            label1.Text = "Digite os numeros ";
            // 
            // RadBSoma
            // 
            RadBSoma.AutoSize = true;
            RadBSoma.Location = new Point(21, 98);
            RadBSoma.Name = "RadBSoma";
            RadBSoma.Size = new Size(55, 19);
            RadBSoma.TabIndex = 8;
            RadBSoma.TabStop = true;
            RadBSoma.Text = "Soma";
            RadBSoma.UseVisualStyleBackColor = true;
            RadBSoma.CheckedChanged += radioButtonSoma_CheckedChanged;
            // 
            // radioButtonSubtração
            // 
            radioButtonSubtração.AutoSize = true;
            radioButtonSubtração.Location = new Point(21, 123);
            radioButtonSubtração.Name = "radioButtonSubtração";
            radioButtonSubtração.Size = new Size(78, 19);
            radioButtonSubtração.TabIndex = 9;
            radioButtonSubtração.TabStop = true;
            radioButtonSubtração.Text = "Subtração";
            radioButtonSubtração.UseVisualStyleBackColor = true;
            radioButtonSubtração.CheckedChanged += radioButtonSubtracao_CheckedChanged;
            // 
            // radioButtonDivisao
            // 
            radioButtonDivisao.AutoSize = true;
            radioButtonDivisao.Location = new Point(143, 98);
            radioButtonDivisao.Name = "radioButtonDivisao";
            radioButtonDivisao.Size = new Size(63, 19);
            radioButtonDivisao.TabIndex = 10;
            radioButtonDivisao.TabStop = true;
            radioButtonDivisao.Text = "Divisão";
            radioButtonDivisao.UseVisualStyleBackColor = true;
            radioButtonDivisao.CheckedChanged += radioButtonDivisao_CheckedChanged;
            // 
            // radioButtonMultiplicacao
            // 
            radioButtonMultiplicacao.AutoSize = true;
            radioButtonMultiplicacao.Location = new Point(140, 123);
            radioButtonMultiplicacao.Name = "radioButtonMultiplicacao";
            radioButtonMultiplicacao.Size = new Size(97, 19);
            radioButtonMultiplicacao.TabIndex = 11;
            radioButtonMultiplicacao.TabStop = true;
            radioButtonMultiplicacao.Text = "Multiplicação";
            radioButtonMultiplicacao.UseVisualStyleBackColor = true;
            radioButtonMultiplicacao.CheckedChanged += radioButtonMultiplicacao_CheckedChanged;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(59, 195);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 13;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += button1_Click_1;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(287, 60);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 14;
            // 
            // labelOperacao
            // 
            labelOperacao.AutoSize = true;
            labelOperacao.Location = new Point(83, 158);
            labelOperacao.Name = "labelOperacao";
            labelOperacao.Size = new Size(0, 15);
            labelOperacao.TabIndex = 15;
            labelOperacao.Click += labelOperacao_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 63);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 16;
            label2.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 372);
            Controls.Add(label2);
            Controls.Add(labelOperacao);
            Controls.Add(textBoxResultado);
            Controls.Add(buttonCalcular);
            Controls.Add(radioButtonMultiplicacao);
            Controls.Add(radioButtonDivisao);
            Controls.Add(radioButtonSubtração);
            Controls.Add(RadBSoma);
            Controls.Add(label1);
            Controls.Add(LabelRsultado);
            Controls.Add(Numerodois);
            Controls.Add(Numero1);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numero1;
        private TextBox Numerodois;
        private Label LabelRsultado;
        private Label label1;
        private RadioButton RadBSoma;
        private RadioButton radioButtonSubtração;
        private RadioButton radioButtonDivisao;
        private RadioButton radioButtonMultiplicacao;
        private Button buttonCalcular;
        private TextBox textBoxResultado;
        private Label labelOperacao;
        private Label label2;
    }
}
