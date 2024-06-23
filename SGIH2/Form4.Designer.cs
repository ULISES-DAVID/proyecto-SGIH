namespace SGIH
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buscador = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buscador
            // 
            buscador.Location = new Point(25, 54);
            buscador.Name = "buscador";
            buscador.Size = new Size(234, 27);
            buscador.TabIndex = 0;
            buscador.Text = "Buscar";
            buscador.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(265, 54);
            button1.Name = "button1";
            button1.Size = new Size(30, 29);
            button1.TabIndex = 1;
            button1.Text = "🔍︎";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(25, 117);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(270, 244);
            listBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2024_06_22_092021;
            pictureBox1.Location = new Point(619, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(718, 409);
            button2.Name = "button2";
            button2.Size = new Size(70, 29);
            button2.TabIndex = 4;
            button2.Text = "Salida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(buscador);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox buscador;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}