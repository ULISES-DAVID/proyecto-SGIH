namespace SGIH
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            idt = new TextBox();
            nombret = new TextBox();
            guardar = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nut = new TextBox();
            estut = new TextBox();
            corret = new TextBox();
            expt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            espet = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Salida";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.file__1_;
            pictureBox1.Location = new Point(673, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // idt
            // 
            idt.Location = new Point(206, 73);
            idt.Name = "idt";
            idt.Size = new Size(125, 27);
            idt.TabIndex = 3;
            // 
            // nombret
            // 
            nombret.Location = new Point(60, 73);
            nombret.Name = "nombret";
            nombret.Size = new Size(125, 27);
            nombret.TabIndex = 4;
            // 
            // guardar
            // 
            guardar.Location = new Point(60, 321);
            guardar.Name = "guardar";
            guardar.Size = new Size(125, 29);
            guardar.TabIndex = 6;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(689, 127);
            button3.Name = "button3";
            button3.Size = new Size(99, 89);
            button3.TabIndex = 7;
            button3.Text = "Informacion de medicos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 50);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 50);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "No.ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 114);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 10;
            label3.Text = "Especialidad:";
            // 
            // nut
            // 
            nut.Location = new Point(60, 199);
            nut.Name = "nut";
            nut.Size = new Size(125, 27);
            nut.TabIndex = 11;
            // 
            // estut
            // 
            estut.Location = new Point(206, 137);
            estut.Name = "estut";
            estut.Size = new Size(125, 27);
            estut.TabIndex = 12;
            // 
            // corret
            // 
            corret.Location = new Point(206, 199);
            corret.Name = "corret";
            corret.Size = new Size(125, 27);
            corret.TabIndex = 13;
            // 
            // expt
            // 
            expt.Location = new Point(60, 272);
            expt.Multiline = true;
            expt.Name = "expt";
            expt.Size = new Size(271, 27);
            expt.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 114);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 15;
            label4.Text = "Estudios:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 176);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 16;
            label5.Text = "Numero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 176);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 17;
            label6.Text = "Correo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 249);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 18;
            label7.Text = "Experiencia:";
            // 
            // espet
            // 
            espet.FormattingEnabled = true;
            espet.Location = new Point(60, 136);
            espet.Name = "espet";
            espet.Size = new Size(125, 28);
            espet.TabIndex = 19;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(espet);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(expt);
            Controls.Add(corret);
            Controls.Add(estut);
            Controls.Add(nut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(guardar);
            Controls.Add(nombret);
            Controls.Add(idt);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox idt;
        private TextBox nombret;
        private Button guardar;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nut;
        private TextBox estut;
        private TextBox corret;
        private TextBox expt;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox espet;
    }
}