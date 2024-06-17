namespace Proyecto_Limbo
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            panel1 = new Panel();
            btnVolver = new Button();
            dgvRpComentarios = new DataGridView();
            cmsComentario = new ContextMenuStrip(components);
            borrarComentarioTsm = new ToolStripMenuItem();
            falsoReporteTsm2 = new ToolStripMenuItem();
            banearUsuarioTsm2 = new ToolStripMenuItem();
            detallesToolStripMenuItem = new ToolStripMenuItem();
            lblRpCom = new Label();
            dgvRpPublicaciones = new DataGridView();
            cmsPublicacion = new ContextMenuStrip(components);
            borrarPublicacionTsm = new ToolStripMenuItem();
            falsoReporteTsm = new ToolStripMenuItem();
            banearUsuariotsm = new ToolStripMenuItem();
            detallesToolStripMenuItem1 = new ToolStripMenuItem();
            lblRpPub = new Label();
            btnRefrescar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRpComentarios).BeginInit();
            cmsComentario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRpPublicaciones).BeginInit();
            cmsPublicacion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(btnRefrescar);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(dgvRpComentarios);
            panel1.Controls.Add(lblRpCom);
            panel1.Controls.Add(dgvRpPublicaciones);
            panel1.Controls.Add(lblRpPub);
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 395);
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
            btnVolver.Location = new Point(520, 327);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(131, 52);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "           Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvRpComentarios
            // 
            dgvRpComentarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRpComentarios.ContextMenuStrip = cmsComentario;
            dgvRpComentarios.Location = new Point(441, 51);
            dgvRpComentarios.Name = "dgvRpComentarios";
            dgvRpComentarios.Size = new Size(348, 260);
            dgvRpComentarios.TabIndex = 5;
            // 
            // cmsComentario
            // 
            cmsComentario.Items.AddRange(new ToolStripItem[] { borrarComentarioTsm, falsoReporteTsm2, banearUsuarioTsm2, detallesToolStripMenuItem });
            cmsComentario.Name = "cmsPublicacion";
            cmsComentario.Size = new Size(215, 92);
            // 
            // borrarComentarioTsm
            // 
            borrarComentarioTsm.Name = "borrarComentarioTsm";
            borrarComentarioTsm.Size = new Size(214, 22);
            borrarComentarioTsm.Text = "Borrar Comentario";
            borrarComentarioTsm.Click += borrarComentarioTsm_Click;
            // 
            // falsoReporteTsm2
            // 
            falsoReporteTsm2.Name = "falsoReporteTsm2";
            falsoReporteTsm2.Size = new Size(214, 22);
            falsoReporteTsm2.Text = "Marcar como falso reporte";
            falsoReporteTsm2.Click += falsoReporteTsm2_Click;
            // 
            // banearUsuarioTsm2
            // 
            banearUsuarioTsm2.Name = "banearUsuarioTsm2";
            banearUsuarioTsm2.Size = new Size(214, 22);
            banearUsuarioTsm2.Text = "Banear usuario";
            banearUsuarioTsm2.Click += banearUsuarioTsm2_Click;
            // 
            // detallesToolStripMenuItem
            // 
            detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            detallesToolStripMenuItem.Size = new Size(214, 22);
            detallesToolStripMenuItem.Text = "Detalles";
            detallesToolStripMenuItem.Click += detallesToolStripMenuItem_Click;
            // 
            // lblRpCom
            // 
            lblRpCom.AutoSize = true;
            lblRpCom.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRpCom.ForeColor = Color.Gold;
            lblRpCom.Location = new Point(441, 12);
            lblRpCom.Name = "lblRpCom";
            lblRpCom.Size = new Size(239, 23);
            lblRpCom.TabIndex = 4;
            lblRpCom.Text = "Reportes de comentarios:";
            // 
            // dgvRpPublicaciones
            // 
            dgvRpPublicaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRpPublicaciones.ContextMenuStrip = cmsPublicacion;
            dgvRpPublicaciones.Location = new Point(30, 51);
            dgvRpPublicaciones.Name = "dgvRpPublicaciones";
            dgvRpPublicaciones.Size = new Size(348, 260);
            dgvRpPublicaciones.TabIndex = 3;
            // 
            // cmsPublicacion
            // 
            cmsPublicacion.Items.AddRange(new ToolStripItem[] { borrarPublicacionTsm, falsoReporteTsm, banearUsuariotsm, detallesToolStripMenuItem1 });
            cmsPublicacion.Name = "cmsPublicacion";
            cmsPublicacion.Size = new Size(215, 92);
            // 
            // borrarPublicacionTsm
            // 
            borrarPublicacionTsm.Name = "borrarPublicacionTsm";
            borrarPublicacionTsm.Size = new Size(214, 22);
            borrarPublicacionTsm.Text = "Borrar Publicacion";
            borrarPublicacionTsm.Click += borrarPublicacionTsm_Click;
            // 
            // falsoReporteTsm
            // 
            falsoReporteTsm.Name = "falsoReporteTsm";
            falsoReporteTsm.Size = new Size(214, 22);
            falsoReporteTsm.Text = "Marcar como falso reporte";
            // 
            // banearUsuariotsm
            // 
            banearUsuariotsm.Name = "banearUsuariotsm";
            banearUsuariotsm.Size = new Size(214, 22);
            banearUsuariotsm.Text = "Banear usuario";
            // 
            // detallesToolStripMenuItem1
            // 
            detallesToolStripMenuItem1.Name = "detallesToolStripMenuItem1";
            detallesToolStripMenuItem1.Size = new Size(214, 22);
            detallesToolStripMenuItem1.Text = "Detalles";
            detallesToolStripMenuItem1.Click += detallesToolStripMenuItem1_Click;
            // 
            // lblRpPub
            // 
            lblRpPub.AutoSize = true;
            lblRpPub.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRpPub.ForeColor = Color.Gold;
            lblRpPub.Location = new Point(30, 12);
            lblRpPub.Name = "lblRpPub";
            lblRpPub.Size = new Size(252, 23);
            lblRpPub.TabIndex = 2;
            lblRpPub.Text = "Reportes de publicaciones:";
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
            btnRefrescar.Location = new Point(188, 325);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(167, 57);
            btnRefrescar.TabIndex = 6;
            btnRefrescar.Text = "              Recargar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 387);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmReportes";
            Text = "Reportes";
            Load += FrmReportes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRpComentarios).EndInit();
            cmsComentario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRpPublicaciones).EndInit();
            cmsPublicacion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvRpPublicaciones;
        private Label lblRpPub;
        private DataGridView dgvRpComentarios;
        private Label lblRpCom;
        private Button btnVolver;
        private ContextMenuStrip cmsPublicacion;
        private ToolStripMenuItem borrarPublicacionTsm;
        private ToolStripMenuItem falsoReporteTsm;
        private ToolStripMenuItem banearUsuariotsm;
        private ContextMenuStrip cmsComentario;
        private ToolStripMenuItem borrarComentarioTsm;
        private ToolStripMenuItem falsoReporteTsm2;
        private ToolStripMenuItem banearUsuarioTsm2;
        private ToolStripMenuItem detallesToolStripMenuItem;
        private ToolStripMenuItem detallesToolStripMenuItem1;
        private Button btnRefrescar;
    }
}