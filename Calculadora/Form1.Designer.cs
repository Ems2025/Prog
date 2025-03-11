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
            resultado = new Button();
            LabelRsultado = new Label();
            Subtração = new Button();
            multiplicação = new Button();
            divisão = new Button();
            SuspendLayout();
            // 
            // Numero1
            // 
            Numero1.Location = new Point(56, 57);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(100, 23);
            Numero1.TabIndex = 0;
            Numero1.TextChanged += Numero1_TextChanged;
            // 
            // Numerodois
            // 
            Numerodois.Location = new Point(195, 57);
            Numerodois.Name = "Numerodois";
            Numerodois.Size = new Size(100, 23);
            Numerodois.TabIndex = 1;
            // 
            // resultado
            // 
            resultado.Location = new Point(56, 107);
            resultado.Name = "resultado";
            resultado.Size = new Size(75, 23);
            resultado.TabIndex = 2;
            resultado.Text = "+";
            resultado.UseVisualStyleBackColor = true;
            resultado.Click += button1_Click;
            // 
            // LabelRsultado
            // 
            LabelRsultado.AutoSize = true;
            LabelRsultado.Location = new Point(231, 177);
            LabelRsultado.Name = "LabelRsultado";
            LabelRsultado.Size = new Size(0, 15);
            LabelRsultado.TabIndex = 3;
            LabelRsultado.Click += label1_Click;
            // 
            // Subtração
            // 
            Subtração.Location = new Point(156, 107);
            Subtração.Name = "Subtração";
            Subtração.Size = new Size(75, 23);
            Subtração.TabIndex = 4;
            Subtração.Text = "-";
            Subtração.UseVisualStyleBackColor = true;
            Subtração.Click += Subtração_Click;
            // 
            // multiplicação
            // 
            multiplicação.Location = new Point(252, 107);
            multiplicação.Name = "multiplicação";
            multiplicação.Size = new Size(75, 23);
            multiplicação.TabIndex = 5;
            multiplicação.Text = "*";
            multiplicação.UseVisualStyleBackColor = true;
            multiplicação.Click += multiplicação_Click;
            // 
            // divisão
            // 
            divisão.Location = new Point(345, 107);
            divisão.Name = "divisão";
            divisão.Size = new Size(75, 23);
            divisão.TabIndex = 6;
            divisão.Text = "/";
            divisão.UseVisualStyleBackColor = true;
            divisão.Click += divisão_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 372);
            Controls.Add(divisão);
            Controls.Add(multiplicação);
            Controls.Add(Subtração);
            Controls.Add(LabelRsultado);
            Controls.Add(resultado);
            Controls.Add(Numerodois);
            Controls.Add(Numero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numero1;
        private TextBox Numerodois;
        private Button resultado;
        private Label LabelRsultado;
        private Button Subtração;
        private Button multiplicação;
        private Button divisão;
    }
}
