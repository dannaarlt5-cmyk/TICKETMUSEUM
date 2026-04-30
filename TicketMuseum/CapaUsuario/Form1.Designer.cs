namespace TicketMuseum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btAcceder = new Button();
            textBox1 = new TextBox();
            tbContrasena = new TextBox();
            lbC = new Label();
            label3 = new Label();
            panel2 = new Panel();
            tbUsuario = new TextBox();
            panel3 = new Panel();
            tbCancelar = new Button();
            btMostrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.magnific_logo_de_museo_para_los_mo_2891664379;
            pictureBox1.Location = new Point(45, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(222, 44);
            label2.TabIndex = 12;
            label2.Text = "Ticket Museum    ";
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(38, -85);
            label1.Name = "label1";
            label1.Size = new Size(108, 61);
            label1.TabIndex = 5;
            // 
            // btAcceder
            // 
            btAcceder.BackColor = Color.FromArgb(40, 40, 40);
            btAcceder.FlatAppearance.BorderSize = 0;
            btAcceder.FlatStyle = FlatStyle.Flat;
            btAcceder.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAcceder.ForeColor = SystemColors.ControlLight;
            btAcceder.Location = new Point(293, 228);
            btAcceder.Name = "btAcceder";
            btAcceder.Size = new Size(416, 40);
            btAcceder.TabIndex = 1;
            btAcceder.Text = "Acceder";
            btAcceder.UseVisualStyleBackColor = false;
            btAcceder.Click += btAcceder_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(293, 134);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 0);
            textBox1.TabIndex = 2;
            textBox1.Text = "Usuario";
            // 
            // tbContrasena
            // 
            tbContrasena.BackColor = SystemColors.ActiveCaptionText;
            tbContrasena.BorderStyle = BorderStyle.None;
            tbContrasena.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContrasena.ForeColor = SystemColors.ActiveCaption;
            tbContrasena.Location = new Point(293, 152);
            tbContrasena.Multiline = true;
            tbContrasena.Name = "tbContrasena";
            tbContrasena.PasswordChar = '*';
            tbContrasena.Size = new Size(416, 44);
            tbContrasena.TabIndex = 3;
            tbContrasena.Text = "Contraseña";
            tbContrasena.UseSystemPasswordChar = true;
            tbContrasena.Click += tbContrasena_Click;
            tbContrasena.Leave += tbContrasena_Leave;
            // 
            // lbC
            // 
            lbC.AutoSize = true;
            lbC.ForeColor = SystemColors.ActiveCaption;
            lbC.Location = new Point(392, 287);
            lbC.Name = "lbC";
            lbC.Size = new Size(214, 25);
            lbC.TabIndex = 5;
            lbC.Text = "¿Olvidaste la Contraseña?";
            lbC.Click += lbC_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(449, 23);
            label3.Name = "label3";
            label3.Size = new Size(102, 43);
            label3.TabIndex = 6;
            label3.Text = "LOGIN";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(293, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 25);
            panel2.TabIndex = 7;
            // 
            // tbUsuario
            // 
            tbUsuario.BackColor = SystemColors.ActiveCaptionText;
            tbUsuario.BorderStyle = BorderStyle.None;
            tbUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsuario.ForeColor = SystemColors.ActiveCaption;
            tbUsuario.Location = new Point(293, 84);
            tbUsuario.Multiline = true;
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(416, 44);
            tbUsuario.TabIndex = 8;
            tbUsuario.Text = "Usuario";
            tbUsuario.Click += tbUsuario_Click;
            tbUsuario.Leave += tbUsuario_Leave;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(293, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 25);
            panel3.TabIndex = 9;
            // 
            // tbCancelar
            // 
            tbCancelar.BackColor = SystemColors.ActiveCaptionText;
            tbCancelar.FlatStyle = FlatStyle.Flat;
            tbCancelar.ForeColor = SystemColors.ActiveBorder;
            tbCancelar.Image = (Image)resources.GetObject("tbCancelar.Image");
            tbCancelar.Location = new Point(753, 5);
            tbCancelar.Name = "tbCancelar";
            tbCancelar.Size = new Size(22, 22);
            tbCancelar.TabIndex = 10;
            tbCancelar.UseVisualStyleBackColor = false;
            tbCancelar.Click += tbCancelar_Click;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = SystemColors.ActiveCaptionText;
            btMostrar.FlatAppearance.BorderSize = 0;
            btMostrar.FlatStyle = FlatStyle.Flat;
            btMostrar.Image = (Image)resources.GetObject("btMostrar.Image");
            btMostrar.Location = new Point(724, 158);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(38, 34);
            btMostrar.TabIndex = 12;
            btMostrar.UseVisualStyleBackColor = false;
            btMostrar.Click += btMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(780, 330);
            Controls.Add(btMostrar);
            Controls.Add(tbCancelar);
            Controls.Add(tbUsuario);
            Controls.Add(panel3);
            Controls.Add(tbContrasena);
            Controls.Add(label3);
            Controls.Add(lbC);
            Controls.Add(textBox1);
            Controls.Add(btAcceder);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btAcceder;
        private Label label1;
        private TextBox textBox1;
        private TextBox tbContrasena;
        private Label lbC;
        private Label label3;
        private Panel panel2;
        private TextBox tbUsuario;
        private Panel panel3;
        private Button tbCancelar;
        private Label label2;
        private Button btMostrar;
        private PictureBox pictureBox1;
    }
}
