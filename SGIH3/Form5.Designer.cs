namespace SGIH
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            Agregar = new Button();
            Agregador = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Agregar
            // 
            Agregar.Location = new Point(161, 66);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(94, 29);
            Agregar.TabIndex = 0;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += button1_Click_1;
            // 
            // Agregador
            // 
            Agregador.Location = new Point(12, 66);
            Agregador.Name = "Agregador";
            Agregador.Size = new Size(143, 27);
            Agregador.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Salida";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.file__1_;
            pictureBox1.Location = new Point(12, 339);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(247, 20);
            label1.TabIndex = 4;
            label1.Text = "Agrega el medicamento y cantidad ";
            label1.Click += label1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Agregador);
            Controls.Add(Agregar);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Agregar;
        private TextBox Agregador;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}