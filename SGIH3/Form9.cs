using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGIH
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void Salida_Click(object sender, EventArgs e)
        {
            Form2
            form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();

            this.Hide();
            form2.Show();
        }
    }
}  