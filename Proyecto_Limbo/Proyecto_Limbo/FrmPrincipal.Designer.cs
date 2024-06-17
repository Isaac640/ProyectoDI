namespace Proyecto_Limbo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            dgvUsuarios = new DataGridView();
            lblUserNumber = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnReportes = new Button();
            btnPublicaciones = new Button();
            btnTorneos = new Button();
            panel3 = new Panel();
            lblNombreApe = new Label();
            lblDay = new Label();
            lblTime = new Label();
            lblUser = new Label();
            pbFotoPerfil = new PictureBox();
            btnRefrescar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoPerfil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(btnRefrescar);
            panel1.Controls.Add(dgvUsuarios);
            panel1.Controls.Add(lblUserNumber);
            panel1.Location = new Point(172, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 361);
            panel1.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(30, 63);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(586, 260);
            dgvUsuarios.TabIndex = 3;
            // 
            // lblUserNumber
            // 
            lblUserNumber.AutoSize = true;
            lblUserNumber.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserNumber.ForeColor = Color.Gold;
            lblUserNumber.Location = new Point(30, 25);
            lblUserNumber.Name = "lblUserNumber";
            lblUserNumber.Size = new Size(93, 23);
            lblUserNumber.TabIndex = 2;
            lblUserNumber.Text = "Usuarios:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.limbo_logo;
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnReportes);
            panel2.Controls.Add(btnPublicaciones);
            panel2.Controls.Add(btnTorneos);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 456);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkSlateBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Image = Properties.Resources.icon_off;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(13, 389);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 52);
            btnExit.TabIndex = 4;
            btnExit.Text = "    Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.DarkSlateBlue;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = Properties.Resources.icon_report;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(3, 143);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(169, 52);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "      Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPublicaciones
            // 
            btnPublicaciones.BackColor = Color.DarkSlateBlue;
            btnPublicaciones.FlatAppearance.BorderSize = 0;
            btnPublicaciones.FlatStyle = FlatStyle.Flat;
            btnPublicaciones.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnPublicaciones.ForeColor = Color.White;
            btnPublicaciones.Image = Properties.Resources.icons_posts;
            btnPublicaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnPublicaciones.Location = new Point(3, 201);
            btnPublicaciones.Name = "btnPublicaciones";
            btnPublicaciones.Size = new Size(169, 52);
            btnPublicaciones.TabIndex = 2;
            btnPublicaciones.Text = "              Publicaciones";
            btnPublicaciones.UseVisualStyleBackColor = false;
            btnPublicaciones.Click += btnPublicaciones_Click;
            // 
            // btnTorneos
            // 
            btnTorneos.BackColor = Color.DarkSlateBlue;
            btnTorneos.FlatAppearance.BorderSize = 0;
            btnTorneos.FlatStyle = FlatStyle.Flat;
            btnTorneos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnTorneos.ForeColor = Color.White;
            btnTorneos.Image = Properties.Resources.icons_tournaments;
            btnTorneos.ImageAlign = ContentAlignment.MiddleLeft;
            btnTorneos.Location = new Point(3, 85);
            btnTorneos.Name = "btnTorneos";
            btnTorneos.Size = new Size(169, 52);
            btnTorneos.TabIndex = 1;
            btnTorneos.Text = "      Torneos";
            btnTorneos.UseVisualStyleBackColor = false;
            btnTorneos.Click += btnTorneos_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateBlue;
            panel3.Controls.Add(lblNombreApe);
            panel3.Controls.Add(lblDay);
            panel3.Controls.Add(lblTime);
            panel3.Controls.Add(lblUser);
            panel3.Controls.Add(pbFotoPerfil);
            panel3.Location = new Point(172, 358);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 98);
            panel3.TabIndex = 3;
            // 
            // lblNombreApe
            // 
            lblNombreApe.AutoSize = true;
            lblNombreApe.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreApe.ForeColor = Color.Gold;
            lblNombreApe.Location = new Point(121, 67);
            lblNombreApe.Name = "lblNombreApe";
            lblNombreApe.Size = new Size(163, 23);
            lblNombreApe.TabIndex = 7;
            lblNombreApe.Text = "Isaac Cabria Diez";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Microsoft Sans Serif", 12F);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(381, 53);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(224, 20);
            lblDay.TabIndex = 6;
            lblDay.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 30F);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(411, 7);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(174, 46);
            lblTime.TabIndex = 5;
            lblTime.Text = "21:00:00";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.Gold;
            lblUser.Location = new Point(121, 26);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(90, 23);
            lblUser.TabIndex = 4;
            lblUser.Text = "Isaac_V1";
            // 
            // pbFotoPerfil
            // 
            pbFotoPerfil.Image = Properties.Resources.icon_person;
            pbFotoPerfil.Location = new Point(8, 16);
            pbFotoPerfil.Name = "pbFotoPerfil";
            pbFotoPerfil.Size = new Size(97, 86);
            pbFotoPerfil.SizeMode = PictureBoxSizeMode.CenterImage;
            pbFotoPerfil.TabIndex = 0;
            pbFotoPerfil.TabStop = false;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.MediumPurple;
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.White;
            btnRefrescar.Image = Properties.Resources.recargar_icon;
            btnRefrescar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefrescar.Location = new Point(449, 3);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(167, 57);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.Text = "              Recargar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            Text = "Menú Principal";
            Load += FrmPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoPerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblUserNumber;
        private DataGridView dgvUsuarios;
        private Panel panel2;
        private Button btnTorneos;
        private Panel panel3;
        private Button btnReportes;
        private Button btnPublicaciones;
        private Label lblUser;
        private PictureBox pbFotoPerfil;
        private Label lblDay;
        private Label lblTime;
        private Button btnExit;
        private Label lblNombreApe;
        private Button btnRefrescar;
    }
}