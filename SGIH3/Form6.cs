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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void eliminador_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\leona\source\repos\SGIH\farmacia.txt";
            string textToRemove = eliminador.Text;
            try
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                lines.RemoveAll(line => line.Equals(textToRemove));

                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Medicamento eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3
            form3 = new Form3();
            form3.FormClosed += (s, args) => this.Close();

            this.Hide();
            form3.Show();
        }
    }
}
