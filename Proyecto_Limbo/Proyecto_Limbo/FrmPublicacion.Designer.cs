namespace Proyecto_Limbo
{
    partial class FrmPublicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublicacion));
            panel1 = new Panel();
            btnBorrar = new Button();
            btnBanear = new Button();
            btnVolver = new Button();
            txtDesc = new TextBox();
            lblLikes = new Label();
            label1 = new Label();
            lblUser = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(btnBorrar);
            panel1.Controls.Add(btnBanear);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(lblLikes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUser);
            panel1.Location = new Point(-6, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 353);
            panel1.TabIndex = 0;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Transparent;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Image = Properties.Resources.delete_Incindent;
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(209, 275);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(119, 52);
            btnBorrar.TabIndex = 23;
            btnBorrar.Text = "           Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnBanear
            // 
            btnBanear.BackColor = Color.Transparent;
            btnBanear.FlatAppearance.BorderSize = 0;
            btnBanear.FlatStyle = FlatStyle.Flat;
            btnBanear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnBanear.ForeColor = Color.White;
            btnBanear.Image = Properties.Resources.banear_usuario;
            btnBanear.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanear.Location = new Point(18, 275);
            btnBanear.Name = "btnBanear";
            btnBanear.Size = new Size(176, 52);
            btnBanear.TabIndex = 22;
            btnBanear.Text = "           Banear usuario";
            btnBanear.UseVisualStyleBackColor = false;
            btnBanear.Click += btnBanear_Click;
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
            btnVolver.Location = new Point(345, 275);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 52);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "           Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(18, 87);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new Size(432, 145);
            txtDesc.TabIndex = 19;
            // 
            // lblLikes
            // 
            lblLikes.AutoSize = true;
            lblLikes.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLikes.ForeColor = Color.Gold;
            lblLikes.Location = new Point(18, 235);
            lblLikes.Name = "lblLikes";
            lblLikes.Size = new Size(106, 23);
            lblLikes.TabIndex = 18;
            lblLikes.Text = "Me gustas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(15, 61);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 17;
            label1.Text = "Detalles:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.Gold;
            lblUser.Location = new Point(15, 27);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(83, 23);
            lblUser.TabIndex = 3;
            lblUser.Text = "Usuario:";
            // 
            // FrmPublicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 340);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPublicacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalles de publicación";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUser;
        private Button btnBorrar;
        private Button btnBanear;
        private Button btnVolver;
        private TextBox txtDesc;
        private Label lblLikes;
        private Label label1;
    }
}