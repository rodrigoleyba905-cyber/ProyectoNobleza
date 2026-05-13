namespace FormNobleza
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            btnSesion = new Button();
            pctureLogo = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pctureLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 18F);
            label1.ForeColor = Color.FromArgb(26, 26, 26);
            label1.Location = new Point(360, 18);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESIÓN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 148);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 196);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(257, 140);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(257, 188);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 4;
            // 
            // btnSesion
            // 
            btnSesion.BackColor = Color.FromArgb(25, 118, 210);
            btnSesion.Cursor = Cursors.Hand;
            btnSesion.FlatAppearance.BorderSize = 0;
            btnSesion.FlatStyle = FlatStyle.Flat;
            btnSesion.Location = new Point(192, 271);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(170, 55);
            btnSesion.TabIndex = 5;
            btnSesion.Text = "Iniciar sesión";
            btnSesion.UseVisualStyleBackColor = false;
            btnSesion.Click += button1_Click;
            // 
            // pctureLogo
            // 
            pctureLogo.Location = new Point(607, 18);
            pctureLogo.Name = "pctureLogo";
            pctureLogo.Size = new Size(100, 50);
            pctureLogo.TabIndex = 7;
            pctureLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 249, 250);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pctureLogo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnSesion);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtContraseña);
            panel1.Location = new Point(183, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 415);
            panel1.TabIndex = 8;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(984, 541);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Form Login";
            ((System.ComponentModel.ISupportInitialize)pctureLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Button btnSesion;
        private PictureBox pctureLogo;
        private Panel panel1;
    }
}
