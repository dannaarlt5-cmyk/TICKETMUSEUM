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
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
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
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(264, 675);
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
            btCerrarSesión.Location = new Point(0, 618);
            btCerrarSesión.Name = "btCerrarSesión";
            btCerrarSesión.Size = new Size(264, 57);
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
            btAdministracion.Location = new Point(0, 210);
            btAdministracion.Name = "btAdministracion";
            btAdministracion.Size = new Size(264, 56);
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
            btBitacora.Location = new Point(0, 154);
            btBitacora.Name = "btBitacora";
            btBitacora.Size = new Size(264, 56);
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
            btVentas.Location = new Point(0, 98);
            btVentas.Name = "btVentas";
            btVentas.Size = new Size(264, 56);
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
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 98);
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
            panel2.Location = new Point(264, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 60);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(btMinimizar);
            panel1.Controls.Add(btMaximizar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(786, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(113, 60);
            panel1.TabIndex = 2;
            // 
            // btMinimizar
            // 
            btMinimizar.BackColor = Color.DimGray;
            btMinimizar.FlatStyle = FlatStyle.Flat;
            btMinimizar.Image = (Image)resources.GetObject("btMinimizar.Image");
            btMinimizar.Location = new Point(3, 9);
            btMinimizar.Name = "btMinimizar";
            btMinimizar.Size = new Size(44, 36);
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
            btMaximizar.Location = new Point(53, 9);
            btMaximizar.Name = "btMaximizar";
            btMaximizar.Size = new Size(53, 36);
            btMaximizar.TabIndex = 2;
            btMaximizar.UseVisualStyleBackColor = false;
            btMaximizar.Click += btMaximizar_Click;
            // 
            // pbMenu
            // 
            pbMenu.Image = (Image)resources.GetObject("pbMenu.Image");
            pbMenu.Location = new Point(6, 6);
            pbMenu.Name = "pbMenu";
            pbMenu.Size = new Size(39, 44);
            pbMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMenu.TabIndex = 2;
            pbMenu.TabStop = false;
            pbMenu.Click += pbMenu_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 675);
            Controls.Add(panel2);
            Controls.Add(pMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMenu).EndInit();
            ResumeLayout(false);
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
    }
}