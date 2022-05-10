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
    public partial class z16 : Form
    {
        public z16()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(textBox1.Text);
            if (x >= 250)
                label5.Text = ("Вы будете обедать?");
            else if (x < 220.50)
                label5.Text = ("Вы взяли мало денег!");
            else if ((x >= 220.50) && (x < 250))
                label5.Text = ("Вам хватит на завтрак!");
        }
    }
}
