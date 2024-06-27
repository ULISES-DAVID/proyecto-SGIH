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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5
            form5 = new Form5();
            form5.FormClosed += (s, args) => this.Close();

            this.Hide();
            form5.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2
            form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();

            this.Hide();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4
            form4 = new Form4();
            form4.FormClosed += (s, args) => this.Close();

            this.Hide();
            form4.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6
            form6 = new Form6();
            form6.FormClosed += (s, args) => this.Close();

            this.Hide();
            form6.Show();
        }
    }
}
