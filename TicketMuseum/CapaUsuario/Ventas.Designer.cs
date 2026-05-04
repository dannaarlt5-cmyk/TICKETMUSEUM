namespace TicketMuseum
{
    partial class Ventas
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            tbNombreResponsable = new TextBox();
            button1 = new Button();
            numBoletos = new NumericUpDown();
            label3 = new Label();
            panel2 = new Panel();
            lblhora = new Label();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            cbMetodoPago = new ComboBox();
            label10 = new Label();
            txttotal = new TextBox();
            label8 = new Label();
            btCancelar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            bSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBoletos).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(bSalir);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 48);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 42);
            label1.TabIndex = 0;
            label1.Text = "Registro de Venta   ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Responsable:";
            // 
            // tbNombreResponsable
            // 
            tbNombreResponsable.Location = new Point(15, 35);
            tbNombreResponsable.Margin = new Padding(2);
            tbNombreResponsable.Name = "tbNombreResponsable";
            tbNombreResponsable.Size = new Size(249, 23);
            tbNombreResponsable.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(34, 323);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(162, 29);
            button1.TabIndex = 3;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numBoletos
            // 
            numBoletos.Location = new Point(284, 36);
            numBoletos.Margin = new Padding(2);
            numBoletos.Name = "numBoletos";
            numBoletos.Size = new Size(43, 23);
            numBoletos.TabIndex = 4;
            numBoletos.ValueChanged += numBoletos_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 19);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Boletos:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblhora);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numBoletos);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbNombreResponsable);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(14, 77);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 128);
            panel2.TabIndex = 8;
            // 
            // lblhora
            // 
            lblhora.Location = new Point(272, 87);
            lblhora.Margin = new Padding(2, 0, 2, 0);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(64, 24);
            lblhora.TabIndex = 9;
            lblhora.Text = "10:00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(284, 67);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 8;
            label11.Text = "Hora:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(14, 84);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 67);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(14, 58);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 9;
            label5.Text = "Datos Grupo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(14, 209);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 11;
            label6.Text = "Datos venta";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(cbMetodoPago);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txttotal);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(14, 227);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(392, 79);
            panel3.TabIndex = 10;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cbMetodoPago.Location = new Point(146, 32);
            cbMetodoPago.Margin = new Padding(2);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(129, 23);
            cbMetodoPago.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(146, 16);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 8;
            label10.Text = "Metodo de pago:";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(19, 32);
            txttotal.Margin = new Padding(2);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(106, 23);
            txttotal.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 16);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 6;
            label8.Text = "Total:";
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.DarkRed;
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = SystemColors.Control;
            btCancelar.Location = new Point(225, 323);
            btCancelar.Margin = new Padding(2);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(162, 29);
            btCancelar.TabIndex = 12;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // bSalir
            // 
            bSalir.BackColor = Color.Red;
            bSalir.Image = Properties.Resources.X;
            bSalir.Location = new Point(383, 0);
            bSalir.Margin = new Padding(0);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(40, 20);
            bSalir.TabIndex = 1;
            bSalir.UseVisualStyleBackColor = false;
            bSalir.Click += bSalir_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 367);
            Controls.Add(btCancelar);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBoletos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox tbNombreResponsable;
        private Button button1;
        private NumericUpDown numBoletos;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private TextBox txttotal;
        private Label label8;
        private ComboBox cbMetodoPago;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label lblhora;
        private Label label11;
        private Button btCancelar;
        private System.Windows.Forms.Timer timer1;
        private Button bSalir;
    }
}