namespace Criptografia
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
            txbMensagem = new TextBox();
            btn_Cripto = new Button();
            label2 = new Label();
            lblCripto = new Label();
            button1 = new Button();
            lblDescripto = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Mensagem";
            // 
            // txbMensagem
            // 
            txbMensagem.Location = new Point(105, 19);
            txbMensagem.Margin = new Padding(2, 1, 2, 1);
            txbMensagem.Name = "txbMensagem";
            txbMensagem.Size = new Size(110, 23);
            txbMensagem.TabIndex = 1;
            // 
            // btn_Cripto
            // 
            btn_Cripto.Location = new Point(245, 22);
            btn_Cripto.Margin = new Padding(2, 1, 2, 1);
            btn_Cripto.Name = "btn_Cripto";
            btn_Cripto.Size = new Size(138, 22);
            btn_Cripto.TabIndex = 2;
            btn_Cripto.Text = "Criptografia Simétrica";
            btn_Cripto.UseVisualStyleBackColor = true;
            btn_Cripto.Click += btn_Cripto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 3;
            label2.Text = "Criptografada";
            // 
            // lblCripto
            // 
            lblCripto.AutoSize = true;
            lblCripto.Location = new Point(299, 73);
            lblCripto.Margin = new Padding(2, 0, 2, 0);
            lblCripto.Name = "lblCripto";
            lblCripto.Size = new Size(80, 15);
            lblCripto.TabIndex = 4;
            lblCripto.Text = "Criptografada";
            // 
            // button1
            // 
            button1.Location = new Point(57, 116);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(188, 22);
            button1.TabIndex = 5;
            button1.Text = "Descriptografar Simétrica";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDescripto
            // 
            lblDescripto.AutoSize = true;
            lblDescripto.Location = new Point(299, 138);
            lblDescripto.Margin = new Padding(2, 0, 2, 0);
            lblDescripto.Name = "lblDescripto";
            lblDescripto.Size = new Size(97, 15);
            lblDescripto.TabIndex = 6;
            lblDescripto.Text = "Descriptografada";
            // 
            // button2
            // 
            button2.Location = new Point(416, 22);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(144, 22);
            button2.TabIndex = 7;
            button2.Text = "Criptografia Assimétrica";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(57, 157);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(188, 22);
            button3.TabIndex = 8;
            button3.Text = "Descriptografar Assimétrica";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 211);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lblDescripto);
            Controls.Add(button1);
            Controls.Add(lblCripto);
            Controls.Add(label2);
            Controls.Add(btn_Cripto);
            Controls.Add(txbMensagem);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbMensagem;
        private Button btn_Cripto;
        private Label label2;
        private Label lblCripto;
        private Button button1;
        private Label lblDescripto;
        private Button button2;
        private Button button3;
    }
}