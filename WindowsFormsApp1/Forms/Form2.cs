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
    public partial class Form2 : Form
    {
        public Form2()
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
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zadan15 zada = new zadan15();   
            zada.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            z16 z16 = new z16();
            z16.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            z17 z17 = new z17();
            z17.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            z18 z18 = new z18();
            z18.Show();
            this.Hide();
        }
    }
}
