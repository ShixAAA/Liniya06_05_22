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
    public partial class zadan15 : Form
    {
        public zadan15()
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
            double x;
            x = Convert.ToDouble(textBox1.Text);
            if (x < -2)
                label5.Text = ($"y = {2 * (Math.Log10(x + 2)):###.##}");
            else if ((x >= -2) && (x < 5))
                label5.Text = ($"y = {Math.Sqrt((x + 2) * Math.Sqrt(x + 3)):###.##}");
            else if (x >= 5)
                label5.Text = ($"y = {3 * Math.Pow(x, 2) - 5 * x - 3}");
            else label5.Text = ("Не число");
        }
    }
}
