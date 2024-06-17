namespace Proyecto_Limbo
{
    partial class FrmListaTorneos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaTorneos));
            panel1 = new Panel();
            btnVolver = new Button();
            btnCrear = new Button();
            btnElim = new Button();
            dgvHistorial = new DataGridView();
            lblHistorial = new Label();
            dgvTorneos = new DataGridView();
            lblTorneos = new Label();
            btnRefrescar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTorneos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(btnRefrescar);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(btnElim);
            panel1.Controls.Add(dgvHistorial);
            panel1.Controls.Add(lblHistorial);
            panel1.Controls.Add(dgvTorneos);
            panel1.Controls.Add(lblTorneos);
            panel1.Location = new Point(-12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 483);
            panel1.TabIndex = 3;
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
            btnVolver.Location = new Point(1098, 409);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(131, 52);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "           Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += button3_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Transparent;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Image = Properties.Resources.add_Incindent;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(30, 409);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(121, 52);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "      Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnElim
            // 
            btnElim.BackColor = Color.Transparent;
            btnElim.FlatAppearance.BorderSize = 0;
            btnElim.FlatStyle = FlatStyle.Flat;
            btnElim.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnElim.ForeColor = Color.White;
            btnElim.Image = Properties.Resources.delete_Incindent;
            btnElim.ImageAlign = ContentAlignment.MiddleLeft;
            btnElim.Location = new Point(157, 409);
            btnElim.Name = "btnElim";
            btnElim.Size = new Size(113, 52);
            btnElim.TabIndex = 6;
            btnElim.Text = "          Borrar";
            btnElim.UseVisualStyleBackColor = false;
            btnElim.Click += btnElim_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(746, 51);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(483, 341);
            dgvHistorial.TabIndex = 5;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorial.ForeColor = Color.Gold;
            lblHistorial.Location = new Point(746, 12);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(190, 23);
            lblHistorial.TabIndex = 4;
            lblHistorial.Text = "Historial de torneos:";
            // 
            // dgvTorneos
            // 
            dgvTorneos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTorneos.Location = new Point(30, 51);
            dgvTorneos.Name = "dgvTorneos";
            dgvTorneos.Size = new Size(695, 341);
            dgvTorneos.TabIndex = 3;
            // 
            // lblTorneos
            // 
            lblTorneos.AutoSize = true;
            lblTorneos.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTorneos.ForeColor = Color.Gold;
            lblTorneos.Location = new Point(30, 12);
            lblTorneos.Name = "lblTorneos";
            lblTorneos.Size = new Size(171, 23);
            lblTorneos.TabIndex = 2;
            lblTorneos.Text = "Torneos Actuales:";
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
            btnRefrescar.Location = new Point(303, 407);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(167, 57);
            btnRefrescar.TabIndex = 10;
            btnRefrescar.Text = "              Recargar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // FrmListaTorneos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 473);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmListaTorneos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Torneos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTorneos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVolver;
        private Button btnCrear;
        private Button btnElim;
        private DataGridView dgvHistorial;
        private Label lblHistorial;
        private DataGridView dgvTorneos;
        private Label lblTorneos;
        private Button btnRefrescar;
    }
}