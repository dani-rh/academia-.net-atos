namespace Revisão_24._05
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
            panel1 = new Panel();
            groupBoxCampos = new GroupBox();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(518, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 213);
            panel1.TabIndex = 0;
            // 
            // groupBoxCampos
            // 
            groupBoxCampos.Location = new Point(34, 56);
            groupBoxCampos.Name = "groupBoxCampos";
            groupBoxCampos.Size = new Size(400, 468);
            groupBoxCampos.TabIndex = 1;
            groupBoxCampos.TabStop = false;
            groupBoxCampos.Text = "Agrupamento";
            // 
            // panel2
            // 
            panel2.Location = new Point(478, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 200);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(979, 836);
            Controls.Add(panel2);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxCampos;
        private Panel panel2;
    }
}