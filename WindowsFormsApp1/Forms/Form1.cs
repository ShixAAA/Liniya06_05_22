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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double x, y, z;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            if (Math.Pow(z, 2) == Math.Pow(y, 2) + Math.Pow(x, 2))
                label5.Text = ("Треугольник прямоугольный");
            if (Math.Pow(y, 2) == Math.Pow(z, 2) + Math.Pow(x, 2))
                label5.Text = ("Треугольник прямоугольный");
            if (Math.Pow(x, 2) == Math.Pow(y, 2) + Math.Pow(z, 2))
                label5.Text = ("Треугольник прямоугольный");
            else label5.Text = ("Треугольник не прямоугольный");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
