namespace SGIH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correctUsername = "david";
            string correctPassword = "1234";

            string Username = USUARIO.Text;
            string Password = CONTRA.Text;

            if (Username == correctUsername && Password == correctPassword)
            {
                Form2
             form2 = new Form2();
                form2.FormClosed += (s, args) => this.Close();

                this.Hide();
                form2.Show();


               
            }

            else
            {
                MessageBox.Show("Acceso Denegado.No deberia estar aqui");
            }

        }

        private void CONTRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

