using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(textBox1.Text);
            if (x % 4 == 0)
            {
                double y = x / 4;
                Convert.ToString(y);
                label5.Text = ($"y = {y}");
            }
            else
            {
                label5.Text = ("Введенное число не делится нацело");
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
