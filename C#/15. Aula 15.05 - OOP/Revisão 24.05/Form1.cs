namespace Revisão_24._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.Name = "btnDinamico";
            btn.Text = "Clique!";

            btn.Click += Btn_Click;

            panel1.Controls.Add(btn);


        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}