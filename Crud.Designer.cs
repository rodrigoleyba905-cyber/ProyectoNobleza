namespace FormNobleza
{
    partial class Crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud));
            dataGridView1 = new DataGridView();
            btnAñadir = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnProfil = new Button();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnTracking = new Button();
            btnCrud = new Button();
            btnHome = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(491, 269);
            dataGridView1.TabIndex = 0;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.FromArgb(25, 118, 210);
            btnAñadir.Cursor = Cursors.Hand;
            btnAñadir.FlatAppearance.BorderSize = 0;
            btnAñadir.FlatStyle = FlatStyle.Flat;
            btnAñadir.Location = new Point(40, 108);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(170, 55);
            btnAñadir.TabIndex = 1;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(25, 118, 210);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(40, 188);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(170, 55);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(25, 118, 210);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(40, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 55);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F);
            label1.Location = new Point(356, 21);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 4;
            label1.Text = "REGISTRO DE EQUIPOS";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 249, 250);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAñadir);
            panel1.Controls.Add(btnEditar);
            panel1.ForeColor = Color.FromArgb(26, 26, 26);
            panel1.Location = new Point(186, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 415);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnTracking);
            panel2.Controls.Add(btnCrud);
            panel2.Controls.Add(btnHome);
            panel2.Location = new Point(36, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 415);
            panel2.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(0, 115, 138);
            flowLayoutPanel2.Location = new Point(0, 421);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(911, 19);
            flowLayoutPanel2.TabIndex = 16;
            // 
            // btnProfil
            // 
            btnProfil.Cursor = Cursors.Hand;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Image = Properties.Resources.person_40dp_1F1F1F_FILL0_wght400_GRAD0_opsz40;
            btnProfil.Location = new Point(3, 61);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(64, 38);
            btnProfil.TabIndex = 10;
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(41, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(25, 118, 210);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = Properties.Resources.logout_40dp_1F1F1F_FILL0_wght400_GRAD0_opsz40;
            btnExit.Location = new Point(64, 318);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(64, 47);
            btnExit.TabIndex = 3;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnTracking
            // 
            btnTracking.BackColor = Color.FromArgb(25, 118, 210);
            btnTracking.Cursor = Cursors.Hand;
            btnTracking.FlatAppearance.BorderSize = 0;
            btnTracking.FlatStyle = FlatStyle.Flat;
            btnTracking.Image = Properties.Resources.analytics_40dp_1F1F1F_FILL0_wght400_GRAD0_opsz40;
            btnTracking.Location = new Point(64, 254);
            btnTracking.Name = "btnTracking";
            btnTracking.Size = new Size(64, 47);
            btnTracking.TabIndex = 2;
            btnTracking.UseVisualStyleBackColor = false;
            // 
            // btnCrud
            // 
            btnCrud.BackColor = Color.FromArgb(25, 118, 210);
            btnCrud.Cursor = Cursors.Hand;
            btnCrud.FlatAppearance.BorderSize = 0;
            btnCrud.FlatStyle = FlatStyle.Flat;
            btnCrud.Image = Properties.Resources.table_edit_40dp_1F1F1F_FILL0_wght400_GRAD0_opsz40;
            btnCrud.Location = new Point(64, 191);
            btnCrud.Name = "btnCrud";
            btnCrud.Size = new Size(64, 47);
            btnCrud.TabIndex = 1;
            btnCrud.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(25, 118, 210);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.FromArgb(141, 122, 104);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(64, 131);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(64, 47);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 115, 138);
            flowLayoutPanel1.Location = new Point(36, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(911, 19);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(0, 115, 138);
            flowLayoutPanel3.Location = new Point(36, 476);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(911, 19);
            flowLayoutPanel3.TabIndex = 16;
            // 
            // Crud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 532);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Crud";
            Text = "Crud";
            Load += Crud_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAñadir;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnProfil;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnTracking;
        private Button btnCrud;
        private Button btnHome;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}