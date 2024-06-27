namespace SGIH
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            label1 = new Label();
            nombret = new TextBox();
            edadt = new TextBox();
            enfermedadt = new TextBox();
            guardar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            sexot = new TextBox();
            curpt = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "PACIENTES";
            label1.Click += label1_Click;
            // 
            // nombret
            // 
            nombret.BackColor = SystemColors.ButtonHighlight;
            nombret.Location = new Point(12, 74);
            nombret.Name = "nombret";
            nombret.Size = new Size(125, 27);
            nombret.TabIndex = 4;
            nombret.TextChanged += nombret_TextChanged;
            // 
            // edadt
            // 
            edadt.Location = new Point(12, 159);
            edadt.Name = "edadt";
            edadt.Size = new Size(125, 27);
            edadt.TabIndex = 5;
            // 
            // enfermedadt
            // 
            enfermedadt.Location = new Point(165, 159);
            enfermedadt.Name = "enfermedadt";
            enfermedadt.Size = new Size(125, 27);
            enfermedadt.TabIndex = 7;
            // 
            // guardar
            // 
            guardar.Location = new Point(165, 238);
            guardar.Name = "guardar";
            guardar.Size = new Size(125, 27);
            guardar.TabIndex = 8;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 10;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 51);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 11;
            label4.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 136);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 12;
            label5.Text = "Enfermedad:";
            // 
            // sexot
            // 
            sexot.Location = new Point(165, 74);
            sexot.Name = "sexot";
            sexot.Size = new Size(125, 27);
            sexot.TabIndex = 13;
            sexot.TextChanged += textBox1_TextChanged;
            // 
            // curpt
            // 
            curpt.Location = new Point(12, 238);
            curpt.Name = "curpt";
            curpt.Size = new Size(125, 27);
            curpt.TabIndex = 14;
            curpt.TextChanged += textBox1_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 215);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 15;
            label6.Text = "Curp:";
            // 
            // button1
            // 
            button1.Location = new Point(688, 72);
            button1.Name = "button1";
            button1.Size = new Size(100, 84);
            button1.TabIndex = 16;
            button1.Text = "Buscar Paciente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(694, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "Salida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.file__1_;
            pictureBox1.Location = new Point(12, 339);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(curpt);
            Controls.Add(sexot);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(guardar);
            Controls.Add(enfermedadt);
            Controls.Add(edadt);
            Controls.Add(nombret);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox nombret;
        private TextBox edadt;
        private TextBox enfermedadt;
        private Button guardar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox sexot;
        private TextBox curpt;
        private Label label6;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}