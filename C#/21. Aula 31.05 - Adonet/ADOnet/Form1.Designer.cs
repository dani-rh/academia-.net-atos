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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(87, 223);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(150, 46);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "Consultar";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(413, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(480, 300);
            dataGridView1.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(87, 149);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(150, 46);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 3;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(81, 561);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(186, 39);
            txbNome.TabIndex = 4;
            // 
            // txtProfissao
            // 
            txtProfissao.Location = new Point(81, 658);
            txtProfissao.Name = "txtProfissao";
            txtProfissao.Size = new Size(186, 39);
            txtProfissao.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(97, 723);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 46);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 513);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 614);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 8;
            label2.Text = "Profissão";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 920);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtProfissao);
            Controls.Add(txbNome);
            Controls.Add(textBox1);
            Controls.Add(btnFiltrar);
            Controls.Add(dataGridView1);
            Controls.Add(btnTodos);
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
    }
}