using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGIH
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\leona\source\repos\SGIH\farmacia.txt";

            string textToAdd = Agregador.Text;

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(textToAdd);
                }
                MessageBox.Show("Numero de medicamentos agregados a la farmacia");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form3
            form3 = new Form3();
            form3.FormClosed += (s, args) => this.Close();

            this.Hide();
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


    

