using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SGIH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1
            form1 = new Form1();
            form1.FormClosed += (s, args) => this.Close();

            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3
              form3 = new Form3();
            form3.FormClosed += (s, args) => this.Close();

            this.Hide();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7
              form7 = new Form7();
            form7.FormClosed += (s, args) => this.Close();

            this.Hide();
            form7.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8
            form8 = new Form8();
            form8.FormClosed += (s, args) => this.Close();

            this.Hide();
            form8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9
            form9 = new Form9();
            form9.FormClosed += (s, args) => this.Close();

            this.Hide();
            form9.Show();
        }
    }
}
