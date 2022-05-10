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
    public partial class z17 : Form
    {
        public z17()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, y1;
            x1 = Convert.ToDouble(textBox1.Text);
            y1 = Convert.ToDouble(textBox2.Text);
            if (x1 == 0 && y1 == 0) 
            {
                label5.Text = "Нулевая координата";
            }
            else
            {
                if (x1 > 0 && y1 > 0)
                    label5.Text = "Переменная лежит в Первой четверти";
                else if (x1 < 0 && y1 > 0)
                    label5.Text = "Переменная лежит во Второй четверти";
                else if (x1 < 0 && y1 < 0)
                    label5.Text = "Переменная лежит во Третьей четверти";
                else if (x1 > 0 && y1 < 0)
                    label5.Text = "Переменная лежит во Четвертой четверти";
            }
        }
    }
}
