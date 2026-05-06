namespace TicketMuseum
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pMenu = new Panel();
            btCerrarSesión = new Button();
            btAdministracion = new Button();
            btBitacora = new Button();
            btVentas = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            btMinimizar = new Button();
            btMaximizar = new Button();
            pbMenu = new PictureBox();
            pVentas = new Panel();
            lblTotalVentas = new Label();
            label1 = new Label();
            pVisitantes = new Panel();
            lblTotalVisitantes = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblBien = new Label();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
            pVentas.SuspendLayout();
            pVisitantes.SuspendLayout();
            SuspendLayout();
            // 
            // pMenu
            // 
            pMenu.BackColor = Color.FromArgb(0, 122, 204);
            pMenu.Controls.Add(btCerrarSesión);
            pMenu.Controls.Add(btAdministracion);
            pMenu.Controls.Add(btBitacora);
            pMenu.Controls.Add(btVentas);
            pMenu.Controls.Add(pictureBox2);
            pMenu.Dock = DockStyle.Left;
            pMenu.Location = new Point(0, 0);
            pMenu.Margin = new Padding(2);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(185, 571);
            pMenu.TabIndex = 0;
            // 
            // btCerrarSesión
            // 
            btCerrarSesión.BackColor = Color.FromArgb(0, 122, 204);
            btCerrarSesión.Dock = DockStyle.Bottom;
            btCerrarSesión.FlatAppearance.BorderSize = 0;
            btCerrarSesión.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btCerrarSesión.FlatStyle = FlatStyle.Flat;
            btCerrarSesión.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCerrarSesión.Image = Properties.Resources.cerrar_sesion;
            btCerrarSesión.ImageAlign = ContentAlignment.MiddleLeft;
            btCerrarSesión.Location = new Point(0, 537);
            btCerrarSesión.Margin = new Padding(2);
            btCerrarSesión.Name = "btCerrarSesión";
            btCerrarSesión.Size = new Size(185, 34);
            btCerrarSesión.TabIndex = 2;
            btCerrarSesión.Text = "Cerrar Sesión";
            btCerrarSesión.UseVisualStyleBackColor = false;
            btCerrarSesión.Click += btCerrarSesión_Click;
            // 
            // btAdministracion
            // 
            btAdministracion.BackColor = Color.FromArgb(0, 122, 204);
            btAdministracion.Dock = DockStyle.Top;
            btAdministracion.FlatAppearance.BorderSize = 0;
            btAdministracion.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btAdministracion.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btAdministracion.FlatStyle = FlatStyle.Flat;
            btAdministracion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAdministracion.Image = Properties.Resources.ADMINISTRACIÓN;
            btAdministracion.ImageAlign = ContentAlignment.MiddleLeft;
            btAdministracion.Location = new Point(0, 127);
            btAdministracion.Margin = new Padding(2);
            btAdministracion.Name = "btAdministracion";
            btAdministracion.Size = new Size(185, 34);
            btAdministracion.TabIndex = 4;
            btAdministracion.Text = "Administración";
            btAdministracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btAdministracion.UseVisualStyleBackColor = false;
            btAdministracion.Click += btAdministracion_Click;
            // 
            // btBitacora
            // 
            btBitacora.BackColor = Color.FromArgb(0, 122, 204);
            btBitacora.Dock = DockStyle.Top;
            btBitacora.FlatAppearance.BorderSize = 0;
            btBitacora.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btBitacora.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btBitacora.FlatStyle = FlatStyle.Flat;
            btBitacora.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btBitacora.Image = Properties.Resources.agenda;
            btBitacora.ImageAlign = ContentAlignment.MiddleLeft;
            btBitacora.Location = new Point(0, 93);
            btBitacora.Margin = new Padding(2);
            btBitacora.Name = "btBitacora";
            btBitacora.Size = new Size(185, 34);
            btBitacora.TabIndex = 3;
            btBitacora.Text = "Bitácora";
            btBitacora.TextImageRelation = TextImageRelation.ImageBeforeText;
            btBitacora.UseVisualStyleBackColor = false;
            btBitacora.Click += btBitacora_Click;
            // 
            // btVentas
            // 
            btVentas.BackColor = Color.FromArgb(0, 122, 204);
            btVentas.Dock = DockStyle.Top;
            btVentas.FlatAppearance.BorderSize = 0;
            btVentas.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btVentas.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btVentas.FlatStyle = FlatStyle.Flat;
            btVentas.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btVentas.Image = (Image)resources.GetObject("btVentas.Image");
            btVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btVentas.Location = new Point(0, 59);
            btVentas.Margin = new Padding(2);
            btVentas.Name = "btVentas";
            btVentas.Size = new Size(185, 34);
            btVentas.TabIndex = 2;
            btVentas.Text = "Ventas";
            btVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btVentas.UseVisualStyleBackColor = false;
            btVentas.Click += btVentas_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 122, 204);
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.magnific_genera_un_logo_para_un_mu_2885411368;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pbMenu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(185, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 36);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(btMinimizar);
            panel1.Controls.Add(btMaximizar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(771, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 36);
            panel1.TabIndex = 2;
            // 
            // btMinimizar
            // 
            btMinimizar.BackColor = Color.DimGray;
            btMinimizar.FlatStyle = FlatStyle.Flat;
            btMinimizar.Image = (Image)resources.GetObject("btMinimizar.Image");
            btMinimizar.Location = new Point(2, 5);
            btMinimizar.Margin = new Padding(2);
            btMinimizar.Name = "btMinimizar";
            btMinimizar.Size = new Size(31, 22);
            btMinimizar.TabIndex = 3;
            btMinimizar.UseVisualStyleBackColor = false;
            btMinimizar.Click += btMinimizar_Click;
            // 
            // btMaximizar
            // 
            btMaximizar.BackColor = Color.DimGray;
            btMaximizar.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btMaximizar.FlatStyle = FlatStyle.Flat;
            btMaximizar.Image = Properties.Resources.minimizar;
            btMaximizar.Location = new Point(37, 5);
            btMaximizar.Margin = new Padding(2);
            btMaximizar.Name = "btMaximizar";
            btMaximizar.Size = new Size(37, 22);
            btMaximizar.TabIndex = 2;
            btMaximizar.UseVisualStyleBackColor = false;
            btMaximizar.Click += btMaximizar_Click;
            // 
            // pbMenu
            // 
            pbMenu.Image = (Image)resources.GetObject("pbMenu.Image");
            pbMenu.Location = new Point(4, 4);
            pbMenu.Margin = new Padding(2);
            pbMenu.Name = "pbMenu";
            pbMenu.Size = new Size(27, 26);
            pbMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMenu.TabIndex = 2;
            pbMenu.TabStop = false;
            pbMenu.Click += pbMenu_Click;
            // 
            // pVentas
            // 
            pVentas.BackColor = Color.FromArgb(128, 128, 255);
            pVentas.Controls.Add(lblTotalVentas);
            pVentas.Controls.Add(label1);
            pVentas.Location = new Point(539, 265);
            pVentas.Name = "pVentas";
            pVentas.Size = new Size(383, 119);
            pVentas.TabIndex = 3;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVentas.Location = new Point(170, 64);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(22, 25);
            lblTotalVentas.TabIndex = 1;
            lblTotalVentas.Text = "$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 13);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "VENTAS DE HOY";
            // 
            // pVisitantes
            // 
            pVisitantes.BackColor = Color.Green;
            pVisitantes.Controls.Add(lblTotalVisitantes);
            pVisitantes.Controls.Add(label4);
            pVisitantes.Location = new Point(539, 461);
            pVisitantes.Name = "pVisitantes";
            pVisitantes.Size = new Size(395, 110);
            pVisitantes.TabIndex = 4;
            // 
            // lblTotalVisitantes
            // 
            lblTotalVisitantes.AutoSize = true;
            lblTotalVisitantes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVisitantes.Location = new Point(170, 64);
            lblTotalVisitantes.Name = "lblTotalVisitantes";
            lblTotalVisitantes.Size = new Size(22, 25);
            lblTotalVisitantes.TabIndex = 3;
            lblTotalVisitantes.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 13);
            label4.Name = "label4";
            label4.Size = new Size(243, 32);
            label4.TabIndex = 2;
            label4.Text = "VISITANTES DE HOY";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // lblBien
            // 
            lblBien.AutoSize = true;
            lblBien.BackColor = SystemColors.AppWorkspace;
            lblBien.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBien.Location = new Point(581, 113);
            lblBien.Name = "lblBien";
            lblBien.Size = new Size(320, 65);
            lblBien.TabIndex = 6;
            lblBien.Text = "BIENVENIDO";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 571);
            Controls.Add(lblBien);
            Controls.Add(pVisitantes);
            Controls.Add(pVentas);
            Controls.Add(panel2);
            Controls.Add(pMenu);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(2);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            Load += Inicio_Load;
            Shown += Inicio_Shown;
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMenu).EndInit();
            pVentas.ResumeLayout(false);
            pVentas.PerformLayout();
            pVisitantes.ResumeLayout(false);
            pVisitantes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pMenu;
        private Panel panel2;
        private PictureBox pbMenu;
        private PictureBox pictureBox2;
        private Button btVentas;
        private Button btCerrarSesión;
        private Button btAdministracion;
        private Button btBitacora;
        private Button btMinimizar;
        private Button btMaximizar;
        private Panel panel1;
        private Panel pVentas;
        private Panel pVisitantes;
        private Label lblTotalVentas;
        private Label label1;
        private Label lblTotalVisitantes;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblBien;
    }
}