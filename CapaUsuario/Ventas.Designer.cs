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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            btCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 80);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 62);
            label1.TabIndex = 0;
            label1.Text = "Registro de Venta   ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 31);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre Responsable:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 31);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(49, 538);
            button1.Name = "button1";
            button1.Size = new Size(231, 48);
            button1.TabIndex = 3;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(405, 60);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 31);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 5;
            label3.Text = "Boletos:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(20, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 210);
            panel2.TabIndex = 8;
            // 
            // label12
            // 
            label12.Location = new Point(388, 145);
            label12.Name = "label12";
            label12.Size = new Size(92, 40);
            label12.TabIndex = 9;
            label12.Text = "10:00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(405, 112);
            label11.Name = "label11";
            label11.Size = new Size(55, 25);
            label11.TabIndex = 8;
            label11.Text = "Hora:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 112);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 6;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(20, 96);
            label5.Name = "label5";
            label5.Size = new Size(135, 30);
            label5.TabIndex = 9;
            label5.Text = "Datos Grupo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(20, 348);
            label6.Name = "label6";
            label6.Size = new Size(127, 30);
            label6.TabIndex = 11;
            label6.Text = "Datos venta";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(20, 378);
            panel3.Name = "panel3";
            panel3.Size = new Size(558, 129);
            panel3.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            comboBox1.Location = new Point(208, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(208, 26);
            label10.Name = "label10";
            label10.Size = new Size(152, 25);
            label10.TabIndex = 8;
            label10.Text = "Metodo de pago:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 54);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 26);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
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
            btCancelar.Location = new Point(322, 538);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(231, 48);
            btCancelar.TabIndex = 12;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 612);
            Controls.Add(btCancelar);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private TextBox textBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private TextBox textBox3;
        private Label label8;
        private ComboBox comboBox1;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label12;
        private Label label11;
        private Button btCancelar;
    }
}