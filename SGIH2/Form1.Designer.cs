﻿namespace SGIH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            USUARIO = new TextBox();
            CONTRA = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(326, 270);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(266, 118);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "USUARIO:";
            label1.Click += label1_Click;
            // 
            // USUARIO
            // 
            USUARIO.Location = new Point(313, 141);
            USUARIO.Name = "USUARIO";
            USUARIO.Size = new Size(125, 27);
            USUARIO.TabIndex = 2;
            USUARIO.TextChanged += textBox1_TextChanged;
            // 
            // CONTRA
            // 
            CONTRA.Location = new Point(313, 224);
            CONTRA.Name = "CONTRA";
            CONTRA.Size = new Size(125, 27);
            CONTRA.TabIndex = 3;
            CONTRA.TextChanged += CONTRA_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 201);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 4;
            label2.Text = "CONTRASENA:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 9);
            label3.Name = "label3";
            label3.Size = new Size(258, 20);
            label3.TabIndex = 5;
            label3.Text = "HOSPITAL REGIONAL INSTITUCIONAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 61);
            label4.Name = "label4";
            label4.Size = new Size(364, 20);
            label4.TabIndex = 6;
            label4.Text = "Hola, para poder ingresar como usuario o trabajador ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 81);
            label5.Name = "label5";
            label5.Size = new Size(407, 20);
            label5.TabIndex = 7;
            label5.Text = "ingrese su nombre de usuario y contrasena correspondiente ";
            // 
            // button2
            // 
            button2.Location = new Point(726, 409);
            button2.Name = "button2";
            button2.Size = new Size(62, 29);
            button2.TabIndex = 8;
            button2.Text = "Salida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(611, 281);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CONTRA);
            Controls.Add(USUARIO);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox USUARIO;
        private TextBox CONTRA;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
