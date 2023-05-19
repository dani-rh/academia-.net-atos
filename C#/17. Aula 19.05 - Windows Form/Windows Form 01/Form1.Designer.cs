namespace Windows_Form_01
{
    partial class FormPrincipal
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
            LabelJogador = new Label();
            textBoxNome = new TextBox();
            buttonGerarEmail = new Button();
            textBoxSobrenome = new TextBox();
            labelSobrenome = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            textBoxListaEmail = new TextBox();
            buttonLimpar = new Button();
            SuspendLayout();
            // 
            // LabelJogador
            // 
            LabelJogador.AutoSize = true;
            LabelJogador.Location = new Point(82, 15);
            LabelJogador.Margin = new Padding(2, 0, 2, 0);
            LabelJogador.Name = "LabelJogador";
            LabelJogador.Size = new Size(101, 15);
            LabelJogador.TabIndex = 0;
            LabelJogador.Text = "Nome do jogador";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(63, 36);
            textBoxNome.Margin = new Padding(2, 1, 2, 1);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(156, 23);
            textBoxNome.TabIndex = 1;
            // 
            // buttonGerarEmail
            // 
            buttonGerarEmail.Location = new Point(98, 175);
            buttonGerarEmail.Margin = new Padding(2, 1, 2, 1);
            buttonGerarEmail.Name = "buttonGerarEmail";
            buttonGerarEmail.Size = new Size(81, 22);
            buttonGerarEmail.TabIndex = 2;
            buttonGerarEmail.Text = "Gerar Email";
            buttonGerarEmail.UseVisualStyleBackColor = true;
            buttonGerarEmail.Click += buttonGerarEmail_Click;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(63, 82);
            textBoxSobrenome.Margin = new Padding(2, 1, 2, 1);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(156, 23);
            textBoxSobrenome.TabIndex = 3;
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.Location = new Point(98, 61);
            labelSobrenome.Margin = new Padding(2, 0, 2, 0);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(68, 15);
            labelSobrenome.TabIndex = 4;
            labelSobrenome.Text = "Sobrenome";
            labelSobrenome.Click += label1_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(114, 107);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(11, 128);
            textBoxEmail.Margin = new Padding(2, 1, 2, 1);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(263, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxListaEmail
            // 
            textBoxListaEmail.Location = new Point(334, 15);
            textBoxListaEmail.Multiline = true;
            textBoxListaEmail.Name = "textBoxListaEmail";
            textBoxListaEmail.ReadOnly = true;
            textBoxListaEmail.ScrollBars = ScrollBars.Vertical;
            textBoxListaEmail.Size = new Size(290, 182);
            textBoxListaEmail.TabIndex = 7;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(98, 201);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(81, 23);
            buttonLimpar.TabIndex = 8;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 271);
            Controls.Add(buttonLimpar);
            Controls.Add(textBoxListaEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(labelSobrenome);
            Controls.Add(textBoxSobrenome);
            Controls.Add(buttonGerarEmail);
            Controls.Add(textBoxNome);
            Controls.Add(LabelJogador);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormPrincipal";
            Text = "Exemplo de Form do Windows";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelJogador;
        private TextBox textBoxNome;
        private Button buttonGerarEmail;
        private TextBox textBoxSobrenome;
        private Label labelSobrenome;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private TextBox textBoxListaEmail;
        private Button buttonLimpar;
    }
}