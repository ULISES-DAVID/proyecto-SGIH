using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGIH
{
    public partial class Form7 : Form
    {
        private string carpetaRuta = @"C:\Users\leona\source\repos\SGIH\GPH";
        private string archivoSeleccionado = "";
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void guardar_Click(object sender, EventArgs e)
        {
            string nombre = nombret.Text;
            string edad = edadt.Text;
            string sexo = sexot.Text;
            string enfermedad = enfermedadt.Text;
            string curp = curpt.Text;


            string fileName = $"{curp}.txt";
            string filePath = Path.Combine(@"C:\Users\leona\source\repos\SGIH/GPH", fileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine($"Nombre: {nombre}");
                    sw.WriteLine($"Edad: {edad}");
                    sw.WriteLine($"Sexo: {sexo}");
                    sw.WriteLine($"Enfermedad: {enfermedad}");
                    sw.WriteLine($"Curp: {curp}");
                }

                MessageBox.Show("Informacion del paciente guardada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la informacion del paciente: {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\leona\source\repos\SGIH\GPH";

            if (System.IO.Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("La carpeta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nombret_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2
            form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();

            this.Hide();
            form2.Show();
        }
    }
}
        
    


        
    


