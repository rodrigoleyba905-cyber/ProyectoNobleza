namespace FormNobleza
{
    partial class Tracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tracking));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnGuardarMovimiento = new Button();
            txtId = new TextBox();
            txtUbicacion = new ComboBox();
            txtComentarios = new TextBox();
            label6 = new Label();
            txtEncargado = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pctureLogo = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnProfil = new Button();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnTracking = new Button();
            btnCrud = new Button();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctureLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 70);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 111);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Nueva ubicación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 223);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Comentarios:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 323);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 387);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // btnGuardarMovimiento
            // 
            btnGuardarMovimiento.BackColor = Color.FromArgb(25, 118, 210);
            btnGuardarMovimiento.Cursor = Cursors.Hand;
            btnGuardarMovimiento.FlatAppearance.BorderSize = 0;
            btnGuardarMovimiento.FlatStyle = FlatStyle.Flat;
            btnGuardarMovimiento.Location = new Point(66, 300);
            btnGuardarMovimiento.Name = "btnGuardarMovimiento";
            btnGuardarMovimiento.Size = new Size(170, 55);
            btnGuardarMovimiento.TabIndex = 5;
            btnGuardarMovimiento.Text = "Guardar movimiento";
            btnGuardarMovimiento.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(159, 70);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // txtUbicacion
            // 
            txtUbicacion.FormattingEnabled = true;
            txtUbicacion.Location = new Point(159, 111);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(121, 23);
            txtUbicacion.TabIndex = 7;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(159, 215);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(100, 23);
            txtComentarios.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 163);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 9;
            label6.Text = "Encargado:";
            // 
            // txtEncargado
            // 
            txtEncargado.Location = new Point(159, 155);
            txtEncargado.Name = "txtEncargado";
            txtEncargado.Size = new Size(100, 23);
            txtEncargado.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F);
            label7.ForeColor = Color.FromArgb(26, 26, 26);
            label7.Location = new Point(340, 10);
            label7.Name = "label7";
            label7.Size = new Size(258, 32);
            label7.TabIndex = 11;
            label7.Text = "RASTREO DE EQUIPOS";
            label7.Click += label7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(299, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(428, 235);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 249, 250);
            panel1.Controls.Add(pctureLogo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEncargado);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnGuardarMovimiento);
            panel1.Controls.Add(txtComentarios);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtUbicacion);
            panel1.Location = new Point(190, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 415);
            panel1.TabIndex = 13;
            // 
            // pctureLogo
            // 
            pctureLogo.Location = new Point(642, 10);
            pctureLogo.Name = "pctureLogo";
            pctureLogo.Size = new Size(100, 50);
            pctureLogo.TabIndex = 13;
            pctureLogo.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(0, 115, 138);
            flowLayoutPanel2.Location = new Point(40, 479);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(911, 19);
            flowLayoutPanel2.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 115, 138);
            flowLayoutPanel1.Location = new Point(40, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(911, 19);
            flowLayoutPanel1.TabIndex = 17;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnTracking);
            panel2.Controls.Add(btnCrud);
            panel2.Controls.Add(btnHome);
            panel2.Location = new Point(40, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 415);
            panel2.TabIndex = 18;
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
            // Tracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(984, 541);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "Tracking";
            Text = "Rastreo";
            Load += Tracking_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctureLogo).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuardarMovimiento;
        private TextBox txtId;
        private ComboBox txtUbicacion;
        private TextBox txtComentarios;
        private Label label6;
        private TextBox txtEncargado;
        private Label label7;
        private DataGridView dataGridView1;
        private Panel panel1;
        private PictureBox pctureLogo;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button btnProfil;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnTracking;
        private Button btnCrud;
        private Button btnHome;
    }
}