using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hello_GitHub
{
    public partial class Form1 : Form
    {
        private readonly Random rColor = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            Hello_Label.ForeColor = Color.FromArgb(rColor.Next(0, 256), rColor.Next(0, 256), rColor.Next(0, 256));
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hello_Label_Click(object sender, EventArgs e)
        {
            if (ColorTimer.Enabled == true) ColorTimer.Stop();
            else ColorTimer.Start();
        }
    }
}
