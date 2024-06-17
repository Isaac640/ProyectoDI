namespace Proyecto_Limbo
{
    partial class FrmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            panel1 = new Panel();
            txtRazon = new TextBox();
            txtTipo = new TextBox();
            txtTexto = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnVolver = new Button();
            lblDenuncia = new Label();
            lblRpPub = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(txtRazon);
            panel1.Controls.Add(txtTipo);
            panel1.Controls.Add(txtTexto);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(lblDenuncia);
            panel1.Controls.Add(lblRpPub);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 492);
            panel1.TabIndex = 3;
            // 
            // txtRazon
            // 
            txtRazon.Location = new Point(14, 319);
            txtRazon.Multiline = true;
            txtRazon.Name = "txtRazon";
            txtRazon.ReadOnly = true;
            txtRazon.Size = new Size(352, 93);
            txtRazon.TabIndex = 15;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(14, 246);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(352, 23);
            txtTipo.TabIndex = 14;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(14, 98);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.ReadOnly = true;
            txtTexto.Size = new Size(352, 102);
            txtTexto.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(14, 36);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(352, 23);
            txtUsuario.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(14, 293);
            label2.Name = "label2";
            label2.Size = new Size(178, 23);
            label2.TabIndex = 11;
            label2.Text = "Razón de denuncia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(14, 220);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 10;
            label1.Text = "Tipo de ofensa";
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
            btnVolver.Location = new Point(117, 418);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(131, 52);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "           Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblDenuncia
            // 
            lblDenuncia.AutoSize = true;
            lblDenuncia.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDenuncia.ForeColor = Color.Gold;
            lblDenuncia.Location = new Point(14, 72);
            lblDenuncia.Name = "lblDenuncia";
            lblDenuncia.Size = new Size(114, 23);
            lblDenuncia.TabIndex = 4;
            lblDenuncia.Text = "Publicación";
            // 
            // lblRpPub
            // 
            lblRpPub.AutoSize = true;
            lblRpPub.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRpPub.ForeColor = Color.Gold;
            lblRpPub.Location = new Point(14, 10);
            lblRpPub.Name = "lblRpPub";
            lblRpPub.Size = new Size(234, 23);
            lblRpPub.TabIndex = 2;
            lblRpPub.Text = "Usuario de la publicación";
            // 
            // FrmReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 480);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmReporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalles Reporte";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVolver;
        private Label lblDenuncia;
        private Label lblRpPub;
        private TextBox txtRazon;
        private TextBox txtTipo;
        private TextBox txtTexto;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
    }
}