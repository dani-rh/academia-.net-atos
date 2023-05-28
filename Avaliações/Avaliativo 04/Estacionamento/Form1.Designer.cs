namespace Estacionamento
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
            components = new System.ComponentModel.Container();
            label_Placa = new Label();
            textBox_Placa = new TextBox();
            button_Entrada = new Button();
            button_saida = new Button();
            label_HoraEntrada = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox_listaEntradaDeVeiculos = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox_listaSaidaDeVeiculos = new TextBox();
            dateTimePicker_dataAtual = new DateTimePicker();
            label_horarioAtual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox_horaEntrada = new TextBox();
            textBox_horaSaida = new TextBox();
            label5 = new Label();
            textBox_tempoDePermanencia = new TextBox();
            label6 = new Label();
            textBox_cobrar = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label_Placa
            // 
            label_Placa.AutoSize = true;
            label_Placa.Location = new Point(160, 69);
            label_Placa.Margin = new Padding(2, 0, 2, 0);
            label_Placa.Name = "label_Placa";
            label_Placa.Size = new Size(99, 15);
            label_Placa.TabIndex = 0;
            label_Placa.Text = "Placa do Veículo: ";
            // 
            // textBox_Placa
            // 
            textBox_Placa.Location = new Point(286, 69);
            textBox_Placa.Margin = new Padding(2, 1, 2, 1);
            textBox_Placa.Name = "textBox_Placa";
            textBox_Placa.Size = new Size(132, 23);
            textBox_Placa.TabIndex = 2;
            // 
            // button_Entrada
            // 
            button_Entrada.Location = new Point(155, 177);
            button_Entrada.Margin = new Padding(2, 1, 2, 1);
            button_Entrada.Name = "button_Entrada";
            button_Entrada.Size = new Size(175, 22);
            button_Entrada.TabIndex = 5;
            button_Entrada.Text = "Entrada do veículo";
            button_Entrada.UseVisualStyleBackColor = true;
            button_Entrada.Click += button_Entrada_Click;
            // 
            // button_saida
            // 
            button_saida.Location = new Point(352, 177);
            button_saida.Margin = new Padding(2, 1, 2, 1);
            button_saida.Name = "button_saida";
            button_saida.Size = new Size(176, 22);
            button_saida.TabIndex = 6;
            button_saida.Text = "Saída do veículo";
            button_saida.UseVisualStyleBackColor = true;
            button_saida.Click += button_saida_Click;
            // 
            // label_HoraEntrada
            // 
            label_HoraEntrada.AutoSize = true;
            label_HoraEntrada.Location = new Point(179, 105);
            label_HoraEntrada.Margin = new Padding(2, 0, 2, 0);
            label_HoraEntrada.Name = "label_HoraEntrada";
            label_HoraEntrada.Size = new Size(79, 15);
            label_HoraEntrada.TabIndex = 4;
            label_HoraEntrada.Text = "Hora Entrada:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 139);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "Hora Saída:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 6;
            label2.Text = "Data:";
            // 
            // textBox_listaEntradaDeVeiculos
            // 
            textBox_listaEntradaDeVeiculos.Location = new Point(24, 332);
            textBox_listaEntradaDeVeiculos.Margin = new Padding(2, 1, 2, 1);
            textBox_listaEntradaDeVeiculos.Multiline = true;
            textBox_listaEntradaDeVeiculos.Name = "textBox_listaEntradaDeVeiculos";
            textBox_listaEntradaDeVeiculos.ScrollBars = ScrollBars.Vertical;
            textBox_listaEntradaDeVeiculos.Size = new Size(336, 163);
            textBox_listaEntradaDeVeiculos.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 309);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 8;
            label3.Text = "Lista Entrada de Veículos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 309);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 10;
            label4.Text = "Lista Saída de Veículos:";
            // 
            // textBox_listaSaidaDeVeiculos
            // 
            textBox_listaSaidaDeVeiculos.Location = new Point(375, 332);
            textBox_listaSaidaDeVeiculos.Margin = new Padding(2, 1, 2, 1);
            textBox_listaSaidaDeVeiculos.Multiline = true;
            textBox_listaSaidaDeVeiculos.Name = "textBox_listaSaidaDeVeiculos";
            textBox_listaSaidaDeVeiculos.ScrollBars = ScrollBars.Vertical;
            textBox_listaSaidaDeVeiculos.Size = new Size(336, 163);
            textBox_listaSaidaDeVeiculos.TabIndex = 9;
            // 
            // dateTimePicker_dataAtual
            // 
            dateTimePicker_dataAtual.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_dataAtual.Enabled = false;
            dateTimePicker_dataAtual.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_dataAtual.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataAtual.Location = new Point(286, 30);
            dateTimePicker_dataAtual.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker_dataAtual.Name = "dateTimePicker_dataAtual";
            dateTimePicker_dataAtual.Size = new Size(132, 23);
            dateTimePicker_dataAtual.TabIndex = 1;
            dateTimePicker_dataAtual.Value = new DateTime(2023, 5, 24, 19, 41, 27, 0);
            // 
            // label_horarioAtual
            // 
            label_horarioAtual.AutoSize = true;
            label_horarioAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_horarioAtual.Location = new Point(641, 32);
            label_horarioAtual.Margin = new Padding(2, 0, 2, 0);
            label_horarioAtual.Name = "label_horarioAtual";
            label_horarioAtual.Size = new Size(70, 21);
            label_horarioAtual.TabIndex = 12;
            label_horarioAtual.Text = "14:45:50";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // textBox_horaEntrada
            // 
            textBox_horaEntrada.Location = new Point(286, 102);
            textBox_horaEntrada.Margin = new Padding(2, 1, 2, 1);
            textBox_horaEntrada.Name = "textBox_horaEntrada";
            textBox_horaEntrada.Size = new Size(132, 23);
            textBox_horaEntrada.TabIndex = 3;
            // 
            // textBox_horaSaida
            // 
            textBox_horaSaida.Location = new Point(286, 136);
            textBox_horaSaida.Margin = new Padding(2, 1, 2, 1);
            textBox_horaSaida.Name = "textBox_horaSaida";
            textBox_horaSaida.Size = new Size(132, 23);
            textBox_horaSaida.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 219);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 15;
            label5.Text = "Tempo de Permanencia:";
            // 
            // textBox_tempoDePermanencia
            // 
            textBox_tempoDePermanencia.Location = new Point(286, 216);
            textBox_tempoDePermanencia.Margin = new Padding(2, 1, 2, 1);
            textBox_tempoDePermanencia.Name = "textBox_tempoDePermanencia";
            textBox_tempoDePermanencia.ReadOnly = true;
            textBox_tempoDePermanencia.Size = new Size(110, 23);
            textBox_tempoDePermanencia.TabIndex = 16;
            textBox_tempoDePermanencia.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 252);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 17;
            label6.Text = "Cobrar:";
            // 
            // textBox_cobrar
            // 
            textBox_cobrar.Location = new Point(286, 249);
            textBox_cobrar.Margin = new Padding(2, 1, 2, 1);
            textBox_cobrar.Name = "textBox_cobrar";
            textBox_cobrar.ReadOnly = true;
            textBox_cobrar.Size = new Size(110, 23);
            textBox_cobrar.TabIndex = 18;
            textBox_cobrar.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(574, 36);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 19;
            label7.Text = "Hora atual";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 540);
            Controls.Add(label7);
            Controls.Add(textBox_cobrar);
            Controls.Add(label6);
            Controls.Add(textBox_tempoDePermanencia);
            Controls.Add(label5);
            Controls.Add(textBox_horaSaida);
            Controls.Add(textBox_horaEntrada);
            Controls.Add(label_horarioAtual);
            Controls.Add(dateTimePicker_dataAtual);
            Controls.Add(label4);
            Controls.Add(textBox_listaSaidaDeVeiculos);
            Controls.Add(label3);
            Controls.Add(textBox_listaEntradaDeVeiculos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_HoraEntrada);
            Controls.Add(button_saida);
            Controls.Add(button_Entrada);
            Controls.Add(textBox_Placa);
            Controls.Add(label_Placa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Placa;
        private TextBox textBox_Placa;
        private Button button_Entrada;
        private Button button_saida;
        private Label label_HoraEntrada;
        private Label label1;
        private Label label2;
        private TextBox textBox_listaEntradaDeVeiculos;
        private Label label3;
        private Label label4;
        private TextBox textBox_listaSaidaDeVeiculos;
        private DateTimePicker dateTimePicker_dataAtual;
        private Label label_horarioAtual;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox_horaEntrada;
        private TextBox textBox_horaSaida;
        private Label label5;
        private TextBox textBox_tempoDePermanencia;
        private Label label6;
        private TextBox textBox_cobrar;
        private Label label7;
    }
}