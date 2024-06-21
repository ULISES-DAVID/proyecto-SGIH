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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string archivoRuta = @"C:\Users\leona\source\repos\SGIH\farmacia.txt";
            string terminoBusqueda = buscador.Text.Trim();
            if (File.Exists(archivoRuta))
            {
                var lineas = File.ReadAllLines(archivoRuta);
                var resultados = lineas.Where(linea => linea.Contains(terminoBusqueda, StringComparison.OrdinalIgnoreCase)).ToList();

                listBox1.Items.Clear();
                if (resultados.Count > 0 )
                {
                    listBox1.Items.AddRange(resultados.ToArray());
                }
                else
                {
                    MessageBox.Show("EL ARCHIVO DE ALMACENAMIENTO NO SE ENCONTRO.", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
