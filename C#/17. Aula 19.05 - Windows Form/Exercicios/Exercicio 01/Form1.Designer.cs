namespace Exercicio_01
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
            textBox_nomeJogador = new TextBox();
            label2 = new Label();
            textBox_listaJogadores = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do jogador";
            // 
            // textBox_nomeJogador
            // 
            textBox_nomeJogador.Location = new Point(142, 17);
            textBox_nomeJogador.Margin = new Padding(2, 1, 2, 1);
            textBox_nomeJogador.Name = "textBox_nomeJogador";
            textBox_nomeJogador.Size = new Size(277, 23);
            textBox_nomeJogador.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 2;
            label2.Text = "Lista de jogadores cadastrados";
            // 
            // textBox_listaJogadores
            // 
            textBox_listaJogadores.Enabled = false;
            textBox_listaJogadores.Location = new Point(215, 50);
            textBox_listaJogadores.Margin = new Padding(2, 1, 2, 1);
            textBox_listaJogadores.Multiline = true;
            textBox_listaJogadores.Name = "textBox_listaJogadores";
            textBox_listaJogadores.ScrollBars = ScrollBars.Vertical;
            textBox_listaJogadores.Size = new Size(431, 200);
            textBox_listaJogadores.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(23, 73);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += Form1_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(119, 73);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(669, 260);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_listaJogadores);
            Controls.Add(label2);
            Controls.Add(textBox_nomeJogador);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            MaximumSize = new Size(685, 299);
            Name = "Form1";
            Text = "Formulário de Gestão de Jogadores";
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_nomeJogador;
        private Label label2;
        private TextBox textBox_listaJogadores;
        private Button button1;
        private Button button2;
    }
}