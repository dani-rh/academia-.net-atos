namespace Exemplo_01
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
            textBox1 = new TextBox();
            button1 = new Button();
            lblDescripto = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 48);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 0;
            label1.Text = "Msg arquivo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(469, 39);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(245, 136);
            button1.Name = "button1";
            button1.Size = new Size(249, 46);
            button1.TabIndex = 2;
            button1.Text = "Descriptografar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDescripto
            // 
            lblDescripto.AutoSize = true;
            lblDescripto.Location = new Point(93, 245);
            lblDescripto.Name = "lblDescripto";
            lblDescripto.Size = new Size(78, 32);
            lblDescripto.TabIndex = 3;
            lblDescripto.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDescripto);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label lblDescripto;
    }
}