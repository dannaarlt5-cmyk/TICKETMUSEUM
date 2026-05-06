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
            btnImprimir = new Button();
            button2 = new Button();
            label1 = new Label();
            lblFecha = new Label();
            label4 = new Label();
            label5 = new Label();
            lblEfectivo = new Label();
            label7 = new Label();
            lblHora = new Label();
            label9 = new Label();
            btVolver = new Button();
            panel2 = new Panel();
            label10 = new Label();
            label = new Label();
            labelt = new Label();
            lblTarjeta = new Label();
            lblMontoTotal = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(99, 5);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(250, 42);
            label3.TabIndex = 1;
            label3.Text = "Administración ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 49);
            panel1.TabIndex = 5;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(0, 122, 204);
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Image = Properties.Resources.imprimir;
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(12, 341);
            btnImprimir.Margin = new Padding(2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(127, 28);
            btnImprimir.TabIndex = 6;
            btnImprimir.Text = "imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
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
            button2.Location = new Point(155, 342);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(127, 28);
            button2.TabIndex = 7;
            button2.Text = "Cerrar Caja";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(136, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 8;
            label1.Text = " CIERRE DE CAJA ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 11F);
            lblFecha.Location = new Point(136, 103);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(80, 17);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "29/04/2026";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(71, 101);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 10;
            label4.Text = " Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(102, 138);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(200, 19);
            label5.TabIndex = 12;
            label5.Text = " Monto Total Recaudado:";
            // 
            // lblEfectivo
            // 
            lblEfectivo.AutoSize = true;
            lblEfectivo.Font = new Font("Arial", 11F);
            lblEfectivo.Location = new Point(172, 169);
            lblEfectivo.Margin = new Padding(2, 0, 2, 0);
            lblEfectivo.Name = "lblEfectivo";
            lblEfectivo.Size = new Size(76, 17);
            lblEfectivo.TabIndex = 11;
            lblEfectivo.Text = "$ 3,580.50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(245, 101);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 19);
            label7.TabIndex = 14;
            label7.Text = "Hora: ";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 11F);
            lblHora.Location = new Point(294, 104);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(44, 17);
            lblHora.TabIndex = 13;
            lblHora.Text = "17:45";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold);
            label9.Location = new Point(45, 11);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(204, 38);
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
            btVolver.Location = new Point(298, 341);
            btVolver.Margin = new Padding(2);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(118, 28);
            btVolver.TabIndex = 16;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(71, 257);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 61);
            panel2.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(2, 11);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(39, 25);
            label10.TabIndex = 18;
            label10.Text = " ⚠";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Arial", 12F, FontStyle.Bold);
            label.Location = new Point(103, 167);
            label.Margin = new Padding(2, 0, 2, 0);
            label.Name = "label";
            label.Size = new Size(72, 19);
            label.TabIndex = 18;
            label.Text = " Efetivo:";
            // 
            // labelt
            // 
            labelt.AutoSize = true;
            labelt.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelt.Location = new Point(102, 199);
            labelt.Margin = new Padding(2, 0, 2, 0);
            labelt.Name = "labelt";
            labelt.Size = new Size(66, 19);
            labelt.TabIndex = 20;
            labelt.Text = "Tarjeta:";
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Font = new Font("Arial", 11F);
            lblTarjeta.Location = new Point(172, 201);
            lblTarjeta.Margin = new Padding(2, 0, 2, 0);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(76, 17);
            lblTarjeta.TabIndex = 19;
            lblTarjeta.Text = "$ 3,580.50";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Arial", 11F);
            lblMontoTotal.Location = new Point(306, 140);
            lblMontoTotal.Margin = new Padding(2, 0, 2, 0);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(76, 17);
            lblMontoTotal.TabIndex = 21;
            lblMontoTotal.Text = "$ 3,580.50";
            // 
            // Administración
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 403);
            Controls.Add(lblMontoTotal);
            Controls.Add(labelt);
            Controls.Add(lblTarjeta);
            Controls.Add(label);
            Controls.Add(panel2);
            Controls.Add(btVolver);
            Controls.Add(label7);
            Controls.Add(lblHora);
            Controls.Add(label5);
            Controls.Add(lblEfectivo);
            Controls.Add(label4);
            Controls.Add(lblFecha);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnImprimir);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private Button btnImprimir;
        private Button button2;
        private Label label1;
        private Label lblFecha;
        private Label label4;
        private Label label5;
        private Label lblEfectivo;
        private Label label7;
        private Label lblHora;
        private Label label9;
        private Button btVolver;
        private Panel panel2;
        private Label label10;
        private Label label;
        private Label labelt;
        private Label lblTarjeta;
        private Label lblMontoTotal;
    }
}