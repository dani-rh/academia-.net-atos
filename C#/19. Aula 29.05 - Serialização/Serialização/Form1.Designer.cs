namespace Serialização
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbNome = new TextBox();
            txbIdade = new TextBox();
            txbSalario = new TextBox();
            btnSerializaXML = new Button();
            btnDesserializa = new Button();
            labelNome = new Label();
            labelIdade = new Label();
            labelSalario = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(199, 17);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(128, 22);
            button1.TabIndex = 0;
            button1.Text = "Serializando";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 50);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(199, 62);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(128, 22);
            button2.TabIndex = 3;
            button2.Text = "Desserializar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 170);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 215);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 262);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Salário";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(91, 170);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(100, 23);
            txbNome.TabIndex = 7;
            // 
            // txbIdade
            // 
            txbIdade.Location = new Point(91, 212);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(100, 23);
            txbIdade.TabIndex = 8;
            // 
            // txbSalario
            // 
            txbSalario.Location = new Point(91, 254);
            txbSalario.Name = "txbSalario";
            txbSalario.Size = new Size(100, 23);
            txbSalario.TabIndex = 9;
            // 
            // btnSerializaXML
            // 
            btnSerializaXML.Location = new Point(278, 123);
            btnSerializaXML.Name = "btnSerializaXML";
            btnSerializaXML.Size = new Size(124, 23);
            btnSerializaXML.TabIndex = 10;
            btnSerializaXML.Text = "SerializaXML";
            btnSerializaXML.UseVisualStyleBackColor = true;
            btnSerializaXML.Click += btnSerializaXML_Click;
            // 
            // btnDesserializa
            // 
            btnDesserializa.Location = new Point(278, 152);
            btnDesserializa.Name = "btnDesserializa";
            btnDesserializa.Size = new Size(124, 23);
            btnDesserializa.TabIndex = 11;
            btnDesserializa.Text = "DesserializaXML";
            btnDesserializa.UseVisualStyleBackColor = true;
            btnDesserializa.Click += btnDesserializa_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(512, 174);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 12;
            labelNome.Text = "Nome";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(512, 212);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(36, 15);
            labelIdade.TabIndex = 13;
            labelIdade.Text = "Idade";
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Location = new Point(512, 249);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(42, 15);
            labelSalario.TabIndex = 14;
            labelSalario.Text = "Salario";
            // 
            // button3
            // 
            button3.Location = new Point(278, 199);
            button3.Name = "button3";
            button3.Size = new Size(124, 23);
            button3.TabIndex = 15;
            button3.Text = "SerializaJson";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(278, 232);
            button4.Name = "button4";
            button4.Size = new Size(124, 23);
            button4.TabIndex = 16;
            button4.Text = "DesserializaJson";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(278, 311);
            button5.Name = "button5";
            button5.Size = new Size(124, 23);
            button5.TabIndex = 18;
            button5.Text = "Desserializa SOAP";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(278, 278);
            button6.Name = "button6";
            button6.Size = new Size(124, 23);
            button6.TabIndex = 17;
            button6.Text = "Serializa SOAP";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 531);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(labelSalario);
            Controls.Add(labelIdade);
            Controls.Add(labelNome);
            Controls.Add(btnDesserializa);
            Controls.Add(btnSerializaXML);
            Controls.Add(txbSalario);
            Controls.Add(txbIdade);
            Controls.Add(txbNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbNome;
        private TextBox txbIdade;
        private TextBox txbSalario;
        private Button btnSerializaXML;
        private Button btnDesserializa;
        private Label labelNome;
        private Label labelIdade;
        private Label labelSalario;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}