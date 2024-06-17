namespace Proyecto_Limbo
{
    partial class FrmTorneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTorneo));
            panel1 = new Panel();
            btnCrear = new Button();
            btnAdj = new Button();
            button3 = new Button();
            txtPuntos = new TextBox();
            txtPremio = new TextBox();
            txtGrupo = new TextBox();
            txtDesc = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblUserNumber = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(btnAdj);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtPuntos);
            panel1.Controls.Add(txtPremio);
            panel1.Controls.Add(txtGrupo);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUserNumber);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 466);
            panel1.TabIndex = 0;
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
            btnCrear.Location = new Point(28, 373);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(105, 52);
            btnCrear.TabIndex = 16;
            btnCrear.Text = "           Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnAdj
            // 
            btnAdj.BackColor = Color.Transparent;
            btnAdj.FlatAppearance.BorderSize = 0;
            btnAdj.FlatStyle = FlatStyle.Flat;
            btnAdj.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAdj.ForeColor = Color.White;
            btnAdj.Image = Properties.Resources.upload_icon;
            btnAdj.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdj.Location = new Point(256, 305);
            btnAdj.Name = "btnAdj";
            btnAdj.Size = new Size(139, 52);
            btnAdj.TabIndex = 15;
            btnAdj.Text = "           Ver Adjunto";
            btnAdj.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.exit_icon;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(290, 373);
            button3.Name = "button3";
            button3.Size = new Size(105, 52);
            button3.TabIndex = 14;
            button3.Text = "           Volver";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtPuntos
            // 
            txtPuntos.Location = new Point(290, 276);
            txtPuntos.Name = "txtPuntos";
            txtPuntos.Size = new Size(109, 23);
            txtPuntos.TabIndex = 13;
            // 
            // txtPremio
            // 
            txtPremio.Location = new Point(173, 237);
            txtPremio.Name = "txtPremio";
            txtPremio.Size = new Size(226, 23);
            txtPremio.TabIndex = 12;
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(173, 199);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(226, 23);
            txtGrupo.TabIndex = 11;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(28, 76);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(371, 101);
            txtDesc.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 13);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(226, 23);
            txtNombre.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(28, 316);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 8;
            label5.Text = "Adjuntos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(25, 273);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 7;
            label4.Text = "Puntos Rep.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(25, 234);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 6;
            label3.Text = "Premio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(25, 196);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 5;
            label2.Text = "Grupo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 4;
            label1.Text = "Detalles:";
            // 
            // lblUserNumber
            // 
            lblUserNumber.AutoSize = true;
            lblUserNumber.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserNumber.ForeColor = Color.Gold;
            lblUserNumber.Location = new Point(25, 10);
            lblUserNumber.Name = "lblUserNumber";
            lblUserNumber.Size = new Size(84, 23);
            lblUserNumber.TabIndex = 3;
            lblUserNumber.Text = "Nombre:";
            // 
            // FrmTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 434);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTorneo";
            Text = "Crear Torneo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUserNumber;
        private Label label2;
        private Label label1;
        private TextBox txtPuntos;
        private TextBox txtPremio;
        private TextBox txtGrupo;
        private TextBox txtDesc;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnAdj;
        private Button button3;
        private Button btnCrear;
    }
}