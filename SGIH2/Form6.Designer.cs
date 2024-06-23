namespace SGIH
{
    partial class Form6
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
            label1 = new Label();
            eliminador = new TextBox();
            boton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 0;
            label1.Text = "Elimina el medicamento que desees ";
            // 
            // eliminador
            // 
            eliminador.Location = new Point(32, 79);
            eliminador.Name = "eliminador";
            eliminador.Size = new Size(159, 27);
            eliminador.TabIndex = 1;
            eliminador.TextChanged += eliminador_TextChanged;
            // 
            // boton
            // 
            boton.Location = new Point(197, 79);
            boton.Name = "boton";
            boton.Size = new Size(94, 29);
            boton.TabIndex = 2;
            boton.Text = "Eliminar";
            boton.UseVisualStyleBackColor = true;
            boton.Click += boton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Salida";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(boton);
            Controls.Add(eliminador);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox eliminador;
        private Button boton;
        private Button button1;
    }
}