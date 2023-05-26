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
            SuspendLayout();
            // 
            // label_Placa
            // 
            label_Placa.AutoSize = true;
            label_Placa.Location = new Point(227, 209);
            label_Placa.Name = "label_Placa";
            label_Placa.Size = new Size(199, 32);
            label_Placa.TabIndex = 0;
            label_Placa.Text = "Placa do Veículo: ";
            // 
            // textBox_Placa
            // 
            textBox_Placa.Location = new Point(455, 209);
            textBox_Placa.Name = "textBox_Placa";
            textBox_Placa.Size = new Size(458, 39);
            textBox_Placa.TabIndex = 1;
            // 
            // button_Entrada
            // 
            button_Entrada.Location = new Point(227, 429);
            button_Entrada.Name = "button_Entrada";
            button_Entrada.Size = new Size(325, 46);
            button_Entrada.TabIndex = 2;
            button_Entrada.Text = "Entrada do veículo";
            button_Entrada.UseVisualStyleBackColor = true;
            button_Entrada.Click += button_Entrada_Click;
            // 
            // button_saida
            // 
            button_saida.Location = new Point(586, 429);
            button_saida.Name = "button_saida";
            button_saida.Size = new Size(327, 46);
            button_saida.TabIndex = 3;
            button_saida.Text = "Saída do veículo";
            button_saida.UseVisualStyleBackColor = true;
            // 
            // label_HoraEntrada
            // 
            label_HoraEntrada.AutoSize = true;
            label_HoraEntrada.Location = new Point(257, 286);
            label_HoraEntrada.Name = "label_HoraEntrada";
            label_HoraEntrada.Size = new Size(157, 32);
            label_HoraEntrada.TabIndex = 4;
            label_HoraEntrada.Text = "Hora Entrada:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 359);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 5;
            label1.Text = "Hora Saída:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 65);
            label2.Name = "label2";
            label2.Size = new Size(68, 32);
            label2.TabIndex = 6;
            label2.Text = "Data:";
            // 
            // textBox_listaEntradaDeVeiculos
            // 
            textBox_listaEntradaDeVeiculos.Location = new Point(44, 676);
            textBox_listaEntradaDeVeiculos.Multiline = true;
            textBox_listaEntradaDeVeiculos.Name = "textBox_listaEntradaDeVeiculos";
            textBox_listaEntradaDeVeiculos.Size = new Size(508, 343);
            textBox_listaEntradaDeVeiculos.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 627);
            label3.Name = "label3";
            label3.Size = new Size(281, 32);
            label3.TabIndex = 8;
            label3.Text = "Lista Entrada de Veículos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(697, 627);
            label4.Name = "label4";
            label4.Size = new Size(258, 32);
            label4.TabIndex = 10;
            label4.Text = "Lista Saída de Veículos:";
            // 
            // textBox_listaSaidaDeVeiculos
            // 
            textBox_listaSaidaDeVeiculos.Location = new Point(697, 676);
            textBox_listaSaidaDeVeiculos.Multiline = true;
            textBox_listaSaidaDeVeiculos.Name = "textBox_listaSaidaDeVeiculos";
            textBox_listaSaidaDeVeiculos.Size = new Size(508, 343);
            textBox_listaSaidaDeVeiculos.TabIndex = 9;
            // 
            // dateTimePicker_dataAtual
            // 
            dateTimePicker_dataAtual.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_dataAtual.Enabled = false;
            dateTimePicker_dataAtual.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_dataAtual.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataAtual.Location = new Point(471, 65);
            dateTimePicker_dataAtual.Name = "dateTimePicker_dataAtual";
            dateTimePicker_dataAtual.Size = new Size(400, 39);
            dateTimePicker_dataAtual.TabIndex = 11;
            dateTimePicker_dataAtual.Value = new DateTime(2023, 5, 24, 19, 41, 27, 0);
            // 
            // label_horarioAtual
            // 
            label_horarioAtual.AutoSize = true;
            label_horarioAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_horarioAtual.Location = new Point(1063, 58);
            label_horarioAtual.Name = "label_horarioAtual";
            label_horarioAtual.Size = new Size(136, 45);
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
            textBox_horaEntrada.Location = new Point(455, 279);
            textBox_horaEntrada.Name = "textBox_horaEntrada";
            textBox_horaEntrada.Size = new Size(200, 39);
            textBox_horaEntrada.TabIndex = 13;
            // 
            // textBox_horaSaida
            // 
            textBox_horaSaida.Location = new Point(455, 352);
            textBox_horaSaida.Name = "textBox_horaSaida";
            textBox_horaSaida.Size = new Size(200, 39);
            textBox_horaSaida.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 1151);
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
    }
}