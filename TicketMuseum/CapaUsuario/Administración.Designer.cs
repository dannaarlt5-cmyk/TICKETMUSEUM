namespace TicketMuseum.CapaUsuario
{
    partial class Administración
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administración));
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            lblFecha = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTotalRecaudado = new Label();
            label7 = new Label();
            lblHora = new Label();
            label9 = new Label();
            btVolver = new Button();
            panel2 = new Panel();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(141, 9);
            label3.Name = "label3";
            label3.Size = new Size(368, 62);
            label3.TabIndex = 1;
            label3.Text = "Administración ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 81);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.imprimir;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(17, 479);
            button1.Name = "button1";
            button1.Size = new Size(181, 47);
            button1.TabIndex = 6;
            button1.Text = "imprimir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(221, 480);
            button2.Name = "button2";
            button2.Size = new Size(181, 46);
            button2.TabIndex = 7;
            button2.Text = "Cerrar Caja";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(194, 108);
            label1.Name = "label1";
            label1.Size = new Size(227, 29);
            label1.TabIndex = 8;
            label1.Text = " CIERRE DE CAJA ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 11F);
            lblFecha.Location = new Point(194, 172);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(120, 25);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "29/04/2026";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(101, 169);
            label4.Name = "label4";
            label4.Size = new Size(96, 29);
            label4.TabIndex = 10;
            label4.Text = " Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(146, 230);
            label5.Name = "label5";
            label5.Size = new Size(300, 29);
            label5.TabIndex = 12;
            label5.Text = " Monto Total Recaudado:";
            // 
            // lblTotalRecaudado
            // 
            lblTotalRecaudado.AutoSize = true;
            lblTotalRecaudado.Font = new Font("Arial", 11F);
            lblTotalRecaudado.Location = new Point(245, 281);
            lblTotalRecaudado.Name = "lblTotalRecaudado";
            lblTotalRecaudado.Size = new Size(114, 25);
            lblTotalRecaudado.TabIndex = 11;
            lblTotalRecaudado.Text = "$ 3,580.50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(350, 169);
            label7.Name = "label7";
            label7.Size = new Size(81, 29);
            label7.TabIndex = 14;
            label7.Text = "Hora: ";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 11F);
            lblHora.Location = new Point(420, 173);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(66, 25);
            lblHora.TabIndex = 13;
            lblHora.Text = "17:45";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold);
            label9.Location = new Point(45, 25);
            label9.Name = "label9";
            label9.Size = new Size(310, 58);
            label9.TabIndex = 15;
            label9.Text = "   Verifique que el efectivo\n   coincida antes de cerrar";
            // 
            // btVolver
            // 
            btVolver.BackColor = Color.DarkRed;
            btVolver.FlatAppearance.BorderSize = 0;
            btVolver.FlatStyle = FlatStyle.Flat;
            btVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btVolver.ForeColor = Color.White;
            btVolver.Image = (Image)resources.GetObject("btVolver.Image");
            btVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btVolver.Location = new Point(425, 479);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(169, 46);
            btVolver.TabIndex = 16;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(101, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 101);
            panel2.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(3, 19);
            label10.Name = "label10";
            label10.Size = new Size(64, 38);
            label10.TabIndex = 18;
            label10.Text = " ⚠";
            // 
            // Administración
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 571);
            Controls.Add(panel2);
            Controls.Add(btVolver);
            Controls.Add(label7);
            Controls.Add(lblHora);
            Controls.Add(label5);
            Controls.Add(lblTotalRecaudado);
            Controls.Add(label4);
            Controls.Add(lblFecha);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Administración";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración";
            Load += Administración_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label lblFecha;
        private Label label4;
        private Label label5;
        private Label lblTotalRecaudado;
        private Label label7;
        private Label lblHora;
        private Label label9;
        private Button btVolver;
        private Panel panel2;
        private Label label10;
    }
}