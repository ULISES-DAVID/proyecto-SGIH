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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SGIH
{
    public partial class Form8 : Form
    {

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            espet.Items.Add("Radiologia");
            espet.Items.Add("Ortopedia");
            espet.Items.Add("Psiquiatria");
            espet.Items.Add("Cardiologia");
            espet.Items.Add("Neurologia");
            espet.Items.Add("Ginecologia");
            espet.Items.Add("Pediatria");
            espet.Items.Add("Enfermero");
            espet.Items.Add("Pasante");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2
            form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();

            this.Hide();
            form2.Show();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            string nombre = nombret.Text;
            string id = idt.Text;
            string especialidad = espet.Text;
            string estudios = estut.Text;
            string numero = nut.Text;
            string correo = corret.Text;
            string experiencia = expt.Text;


            string basePath = @"C:\Users\leona\source\repos\SGIH\RMH";
            string folderPath = Path.Combine(basePath, especialidad);

            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = $"{id}.txt";
            string filePath = Path.Combine(folderPath, fileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine($"Nombre: {nombre}");
                    sw.WriteLine($"ID: {id}");
                    sw.WriteLine($"Especialidad: {especialidad}");
                    sw.WriteLine($"Estudios: {estudios}");
                    sw.WriteLine($"Numero: {numero}");
                    sw.WriteLine($"Correo: {correo}");
                    sw.WriteLine($"Experiencia: {experiencia}");
                }

                MessageBox.Show("Informacion del medico guardada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la informacion del medico: {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\leona\source\repos\SGIH\RMH";

            if (System.IO.Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("La carpeta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
    

