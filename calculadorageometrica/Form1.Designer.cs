namespace calculadorageometrica
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
            textBoxLargura = new TextBox();
            textBoxComprimento = new TextBox();
            textBoxAltura = new TextBox();
            labelcomprimento = new Label();
            labelLargura = new Label();
            labelAltura = new Label();
            buttonCalcularRetangulo = new Button();
            radioButtonPerimetro = new RadioButton();
            radioButtonVolume = new RadioButton();
            radioButtonArea = new RadioButton();
            comboBoxOpcao = new ComboBox();
            groupBoxRetangulo = new GroupBox();
            label3 = new Label();
            textBoxResultado = new TextBox();
            comboBox1_Selected = new ComboBox();
            groupBoxQuadrado = new GroupBox();
            textBoxResultadoQuadrado = new TextBox();
            radioButtonPerimetroquadrado = new RadioButton();
            radioButtonAreaQuadrado = new RadioButton();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAlturaQuadrado = new TextBox();
            buttonCalcularQuadradro = new Button();
            txtLarguraQuadrado = new TextBox();
            labelErro = new Label();
            groupBoxRetangulo.SuspendLayout();
            groupBoxQuadrado.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxLargura
            // 
            textBoxLargura.Location = new Point(121, 95);
            textBoxLargura.Name = "textBoxLargura";
            textBoxLargura.Size = new Size(100, 23);
            textBoxLargura.TabIndex = 0;
            textBoxLargura.TextChanged += textBox1_TextChanged;
            // 
            // textBoxComprimento
            // 
            textBoxComprimento.Location = new Point(121, 124);
            textBoxComprimento.Name = "textBoxComprimento";
            textBoxComprimento.Size = new Size(100, 23);
            textBoxComprimento.TabIndex = 1;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(121, 66);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(100, 23);
            textBoxAltura.TabIndex = 2;
            // 
            // labelcomprimento
            // 
            labelcomprimento.AutoSize = true;
            labelcomprimento.Location = new Point(227, 132);
            labelcomprimento.Name = "labelcomprimento";
            labelcomprimento.Size = new Size(82, 15);
            labelcomprimento.TabIndex = 3;
            labelcomprimento.Text = "Comprimento";
            // 
            // labelLargura
            // 
            labelLargura.AutoSize = true;
            labelLargura.Location = new Point(227, 103);
            labelLargura.Name = "labelLargura";
            labelLargura.Size = new Size(47, 15);
            labelLargura.TabIndex = 4;
            labelLargura.Text = "Largura";
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Location = new Point(227, 74);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(39, 15);
            labelAltura.TabIndex = 5;
            labelAltura.Text = "Altura";
            // 
            // buttonCalcularRetangulo
            // 
            buttonCalcularRetangulo.Location = new Point(227, 216);
            buttonCalcularRetangulo.Name = "buttonCalcularRetangulo";
            buttonCalcularRetangulo.Size = new Size(75, 23);
            buttonCalcularRetangulo.TabIndex = 7;
            buttonCalcularRetangulo.Text = "Calcular";
            buttonCalcularRetangulo.UseVisualStyleBackColor = true;
            buttonCalcularRetangulo.Click += buttonCalcular_Click;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Location = new Point(19, 72);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 8;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perimetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            radioButtonPerimetro.CheckedChanged += radioButtonPerimetro_CheckedChanged;
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.Location = new Point(19, 132);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(65, 19);
            radioButtonVolume.TabIndex = 9;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume";
            radioButtonVolume.UseVisualStyleBackColor = true;
            radioButtonVolume.CheckedChanged += radioButtonVolume_CheckedChanged;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(19, 103);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 10;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Area";
            radioButtonArea.UseVisualStyleBackColor = true;
            radioButtonArea.CheckedChanged += radioButtonArea_CheckedChanged;
            // 
            // comboBoxOpcao
            // 
            comboBoxOpcao.FormattingEnabled = true;
            comboBoxOpcao.Items.AddRange(new object[] { "Quadradro", "Retangulo" });
            comboBoxOpcao.Location = new Point(244, 124);
            comboBoxOpcao.Name = "comboBoxOpcao";
            comboBoxOpcao.Size = new Size(121, 23);
            comboBoxOpcao.TabIndex = 11;
            comboBoxOpcao.SelectedIndexChanged += comboBoxOpcao_SelectedIndexChanged;
            // 
            // groupBoxRetangulo
            // 
            groupBoxRetangulo.Controls.Add(label3);
            groupBoxRetangulo.Controls.Add(textBoxAltura);
            groupBoxRetangulo.Controls.Add(textBoxResultado);
            groupBoxRetangulo.Controls.Add(radioButtonVolume);
            groupBoxRetangulo.Controls.Add(radioButtonArea);
            groupBoxRetangulo.Controls.Add(comboBox1_Selected);
            groupBoxRetangulo.Controls.Add(buttonCalcularRetangulo);
            groupBoxRetangulo.Controls.Add(textBoxLargura);
            groupBoxRetangulo.Controls.Add(radioButtonPerimetro);
            groupBoxRetangulo.Controls.Add(textBoxComprimento);
            groupBoxRetangulo.Controls.Add(labelLargura);
            groupBoxRetangulo.Controls.Add(labelAltura);
            groupBoxRetangulo.Controls.Add(labelcomprimento);
            groupBoxRetangulo.Location = new Point(315, 182);
            groupBoxRetangulo.Name = "groupBoxRetangulo";
            groupBoxRetangulo.Size = new Size(315, 267);
            groupBoxRetangulo.TabIndex = 12;
            groupBoxRetangulo.TabStop = false;
            groupBoxRetangulo.Text = "Retangulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 220);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 14;
            label3.Text = "Resultado";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(6, 217);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 12;
            // 
            // comboBox1_Selected
            // 
            comboBox1_Selected.FormattingEnabled = true;
            comboBox1_Selected.Items.AddRange(new object[] { "Quadrado", "Retangulo" });
            comboBox1_Selected.Location = new Point(188, 22);
            comboBox1_Selected.Name = "comboBox1_Selected";
            comboBox1_Selected.Size = new Size(121, 23);
            comboBox1_Selected.TabIndex = 12;
            comboBox1_Selected.SelectedIndexChanged += comboBox1_Selected_SelectedIndexChanged;
            // 
            // groupBoxQuadrado
            // 
            groupBoxQuadrado.Controls.Add(textBoxResultadoQuadrado);
            groupBoxQuadrado.Controls.Add(radioButtonPerimetroquadrado);
            groupBoxQuadrado.Controls.Add(radioButtonAreaQuadrado);
            groupBoxQuadrado.Controls.Add(label4);
            groupBoxQuadrado.Controls.Add(label2);
            groupBoxQuadrado.Controls.Add(label1);
            groupBoxQuadrado.Controls.Add(txtAlturaQuadrado);
            groupBoxQuadrado.Controls.Add(buttonCalcularQuadradro);
            groupBoxQuadrado.Controls.Add(txtLarguraQuadrado);
            groupBoxQuadrado.Location = new Point(2, 182);
            groupBoxQuadrado.Name = "groupBoxQuadrado";
            groupBoxQuadrado.Size = new Size(307, 267);
            groupBoxQuadrado.TabIndex = 13;
            groupBoxQuadrado.TabStop = false;
            groupBoxQuadrado.Text = "Quadrado";
            // 
            // textBoxResultadoQuadrado
            // 
            textBoxResultadoQuadrado.Location = new Point(90, 211);
            textBoxResultadoQuadrado.Name = "textBoxResultadoQuadrado";
            textBoxResultadoQuadrado.Size = new Size(100, 23);
            textBoxResultadoQuadrado.TabIndex = 27;
            // 
            // radioButtonPerimetroquadrado
            // 
            radioButtonPerimetroquadrado.AutoSize = true;
            radioButtonPerimetroquadrado.Location = new Point(223, 132);
            radioButtonPerimetroquadrado.Name = "radioButtonPerimetroquadrado";
            radioButtonPerimetroquadrado.Size = new Size(77, 19);
            radioButtonPerimetroquadrado.TabIndex = 26;
            radioButtonPerimetroquadrado.TabStop = true;
            radioButtonPerimetroquadrado.Text = "Perimetro";
            radioButtonPerimetroquadrado.UseVisualStyleBackColor = true;
            // 
            // radioButtonAreaQuadrado
            // 
            radioButtonAreaQuadrado.AutoSize = true;
            radioButtonAreaQuadrado.Location = new Point(223, 101);
            radioButtonAreaQuadrado.Name = "radioButtonAreaQuadrado";
            radioButtonAreaQuadrado.Size = new Size(49, 19);
            radioButtonAreaQuadrado.TabIndex = 25;
            radioButtonAreaQuadrado.TabStop = true;
            radioButtonAreaQuadrado.Text = "Area";
            radioButtonAreaQuadrado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 140);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 24;
            label4.Text = "Largura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 77);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 23;
            label2.Text = "Altura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 214);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 22;
            label1.Text = "Resultado";
            // 
            // txtAlturaQuadrado
            // 
            txtAlturaQuadrado.Location = new Point(6, 74);
            txtAlturaQuadrado.Name = "txtAlturaQuadrado";
            txtAlturaQuadrado.Size = new Size(100, 23);
            txtAlturaQuadrado.TabIndex = 21;
            // 
            // buttonCalcularQuadradro
            // 
            buttonCalcularQuadradro.Location = new Point(211, 211);
            buttonCalcularQuadradro.Name = "buttonCalcularQuadradro";
            buttonCalcularQuadradro.Size = new Size(75, 23);
            buttonCalcularQuadradro.TabIndex = 15;
            buttonCalcularQuadradro.Text = "Calcular";
            buttonCalcularQuadradro.UseVisualStyleBackColor = true;
            buttonCalcularQuadradro.Click += buttonCalcularQuadradro_Click;
            // 
            // txtLarguraQuadrado
            // 
            txtLarguraQuadrado.Location = new Point(6, 132);
            txtLarguraQuadrado.Name = "txtLarguraQuadrado";
            txtLarguraQuadrado.Size = new Size(100, 23);
            txtLarguraQuadrado.TabIndex = 14;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(321, 68);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErro);
            Controls.Add(groupBoxQuadrado);
            Controls.Add(groupBoxRetangulo);
            Controls.Add(comboBoxOpcao);
            Name = "Form1";
            Text = "Form1";
            groupBoxRetangulo.ResumeLayout(false);
            groupBoxRetangulo.PerformLayout();
            groupBoxQuadrado.ResumeLayout(false);
            groupBoxQuadrado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLargura;
        private TextBox textBoxComprimento;
        private TextBox textBoxAltura;
        private Label labelcomprimento;
        private Label labelLargura;
        private Label labelAltura;
        private Button buttonCalcularRetangulo;
        private RadioButton radioButtonPerimetro;
        private RadioButton radioButtonVolume;
        private RadioButton radioButtonArea;
        private ComboBox comboBoxOpcao;
        private GroupBox groupBoxRetangulo;
        private GroupBox groupBoxQuadrado;
        private TextBox txtLarguraQuadrado;
        private ComboBox comboBox1_Selected;
        private Label labelErro;
        private TextBox textBoxResultado;
        private Label label3;
        private Button buttonCalcularQuadradro;
        private Label label1;
        private TextBox txtAlturaQuadrado;
        private Label label4;
        private Label label2;
        private TextBox textBoxResultadoQuadrado;
        private RadioButton radioButtonPerimetroquadrado;
        private RadioButton radioButtonAreaQuadrado;
    }
}
