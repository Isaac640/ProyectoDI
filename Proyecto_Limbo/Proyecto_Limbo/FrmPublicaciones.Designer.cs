namespace Proyecto_Limbo
{
    partial class FrmPublicaciones
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublicaciones));
            panel1 = new Panel();
            btnVolver = new Button();
            btnDetalles = new Button();
            dgvPublicaciones = new DataGridView();
            cmsPublicacion = new ContextMenuStrip(components);
            tsmiBorrar = new ToolStripMenuItem();
            tsmiBan = new ToolStripMenuItem();
            lblPostsNumber = new Label();
            btnRefrescar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).BeginInit();
            cmsPublicacion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(btnRefrescar);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnDetalles);
            panel1.Controls.Add(dgvPublicaciones);
            panel1.Controls.Add(lblPostsNumber);
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 417);
            panel1.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Image = Properties.Resources.exit_icon;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(378, 331);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(131, 52);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "           Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.Transparent;
            btnDetalles.FlatAppearance.BorderSize = 0;
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnDetalles.ForeColor = Color.White;
            btnDetalles.Image = Properties.Resources.icons_posts;
            btnDetalles.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetalles.Location = new Point(30, 331);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(133, 52);
            btnDetalles.TabIndex = 6;
            btnDetalles.Text = "          Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // dgvPublicaciones
            // 
            dgvPublicaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublicaciones.ContextMenuStrip = cmsPublicacion;
            dgvPublicaciones.Location = new Point(30, 51);
            dgvPublicaciones.Name = "dgvPublicaciones";
            dgvPublicaciones.Size = new Size(479, 260);
            dgvPublicaciones.TabIndex = 3;
            // 
            // cmsPublicacion
            // 
            cmsPublicacion.Items.AddRange(new ToolStripItem[] { tsmiBorrar, tsmiBan });
            cmsPublicacion.Name = "cmsPublicacion";
            cmsPublicacion.Size = new Size(172, 48);
            // 
            // tsmiBorrar
            // 
            tsmiBorrar.Name = "tsmiBorrar";
            tsmiBorrar.Size = new Size(171, 22);
            tsmiBorrar.Text = "Borrar Publicacion";
            tsmiBorrar.Click += tsmiBorrar_Click;
            // 
            // tsmiBan
            // 
            tsmiBan.Name = "tsmiBan";
            tsmiBan.Size = new Size(171, 22);
            tsmiBan.Text = "Banear usuario";
            tsmiBan.Click += tsmiBan_Click;
            // 
            // lblPostsNumber
            // 
            lblPostsNumber.AutoSize = true;
            lblPostsNumber.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostsNumber.ForeColor = Color.Gold;
            lblPostsNumber.Location = new Point(30, 12);
            lblPostsNumber.Name = "lblPostsNumber";
            lblPostsNumber.Size = new Size(140, 23);
            lblPostsNumber.TabIndex = 2;
            lblPostsNumber.Text = "Publicaciones:";
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
            btnRefrescar.Location = new Point(181, 329);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(167, 57);
            btnRefrescar.TabIndex = 10;
            btnRefrescar.Text = "              Recargar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // FrmPublicaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 407);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPublicaciones";
            Text = "Publicaciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).EndInit();
            cmsPublicacion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvPublicaciones;
        private Label lblPostsNumber;
        private Button btnVolver;
        private Button btnDetalles;
        private ContextMenuStrip cmsPublicacion;
        private ToolStripMenuItem tsmiBorrar;
        private ToolStripMenuItem marcarComoFalsoReporteToolStripMenuItem;
        private ToolStripMenuItem tsmiBan;
        private Button btnRefrescar;
    }
}