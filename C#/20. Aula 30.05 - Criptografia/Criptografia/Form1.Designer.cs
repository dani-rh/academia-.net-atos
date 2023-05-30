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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 55);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 0;
            label1.Text = "Mensagem";
            // 
            // txbMensagem
            // 
            txbMensagem.Location = new Point(207, 52);
            txbMensagem.Name = "txbMensagem";
            txbMensagem.Size = new Size(200, 39);
            txbMensagem.TabIndex = 1;
            // 
            // btn_Cripto
            // 
            btn_Cripto.Location = new Point(465, 48);
            btn_Cripto.Name = "btn_Cripto";
            btn_Cripto.Size = new Size(150, 46);
            btn_Cripto.TabIndex = 2;
            btn_Cripto.Text = "Criptografia";
            btn_Cripto.UseVisualStyleBackColor = true;
            btn_Cripto.Click += btn_Cripto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 144);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 3;
            label2.Text = "Criptografada";
            // 
            // lblCripto
            // 
            lblCripto.AutoSize = true;
            lblCripto.Location = new Point(329, 144);
            lblCripto.Name = "lblCripto";
            lblCripto.Size = new Size(78, 32);
            lblCripto.TabIndex = 4;
            lblCripto.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(12, 237);
            button1.Name = "button1";
            button1.Size = new Size(217, 46);
            button1.TabIndex = 5;
            button1.Text = "Descriptografar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDescripto
            // 
            lblDescripto.AutoSize = true;
            lblDescripto.Location = new Point(329, 244);
            lblDescripto.Name = "lblDescripto";
            lblDescripto.Size = new Size(78, 32);
            lblDescripto.TabIndex = 6;
            lblDescripto.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDescripto);
            Controls.Add(button1);
            Controls.Add(lblCripto);
            Controls.Add(label2);
            Controls.Add(btn_Cripto);
            Controls.Add(txbMensagem);
            Controls.Add(label1);
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
    }
}