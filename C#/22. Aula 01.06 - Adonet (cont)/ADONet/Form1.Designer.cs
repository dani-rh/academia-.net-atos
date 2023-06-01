namespace ADOnet
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
            btnTodos = new Button();
            dataGridView1 = new DataGridView();
            btnFiltrar = new Button();
            textBox1 = new TextBox();
            txbNome = new TextBox();
            txtProfissao = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            txbID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(47, 105);
            btnTodos.Margin = new Padding(2, 1, 2, 1);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(81, 22);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "Consultar";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(222, 22);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(258, 141);
            dataGridView1.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(47, 70);
            btnFiltrar.Margin = new Padding(2, 1, 2, 1);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(81, 22);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 35);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 3;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(33, 231);
            txbNome.Margin = new Padding(2, 1, 2, 1);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(102, 23);
            txbNome.TabIndex = 4;
            // 
            // txtProfissao
            // 
            txtProfissao.Location = new Point(33, 276);
            txtProfissao.Margin = new Padding(2, 1, 2, 1);
            txtProfissao.Name = "txtProfissao";
            txtProfissao.Size = new Size(102, 23);
            txtProfissao.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(284, 208);
            btnCadastrar.Margin = new Padding(2, 1, 2, 1);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(81, 22);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 208);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 255);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Profissão";
            // 
            // button1
            // 
            button1.Location = new Point(284, 243);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(81, 22);
            button1.TabIndex = 9;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 306);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 11;
            label4.Text = "ID";
            // 
            // txbID
            // 
            txbID.Location = new Point(33, 322);
            txbID.Margin = new Padding(2, 1, 2, 1);
            txbID.Name = "txbID";
            txbID.Size = new Size(102, 23);
            txbID.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 431);
            Controls.Add(label4);
            Controls.Add(txbID);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtProfissao);
            Controls.Add(txbNome);
            Controls.Add(textBox1);
            Controls.Add(btnFiltrar);
            Controls.Add(dataGridView1);
            Controls.Add(btnTodos);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTodos;
        private DataGridView dataGridView1;
        private Button btnFiltrar;
        private TextBox textBox1;
        private TextBox txbNome;
        private TextBox txtProfissao;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label4;
        private TextBox txbID;
    }
}