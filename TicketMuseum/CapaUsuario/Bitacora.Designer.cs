namespace TicketMuseum
{
    partial class Bitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtBuscar = new TextBox();
            label1 = new Label();
            button1 = new Button();
            dgvBitacora = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btCancelar = new Button();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(111, 64);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(235, 26);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 64);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(550, 60);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(35, 29);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvBitacora
            // 
            dgvBitacora.BackgroundColor = SystemColors.Control;
            dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBitacora.Columns.AddRange(new DataGridViewColumn[] { Nombre, Grupo, Fecha, Hora });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBitacora.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBitacora.GridColor = SystemColors.ActiveCaptionText;
            dgvBitacora.Location = new Point(23, 103);
            dgvBitacora.Margin = new Padding(2);
            dgvBitacora.Name = "dgvBitacora";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DimGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvBitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvBitacora.RowHeadersVisible = false;
            dgvBitacora.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dgvBitacora.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvBitacora.Size = new Size(584, 216);
            dgvBitacora.TabIndex = 3;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Responsable";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 300;
            // 
            // Grupo
            // 
            Grupo.HeaderText = "Grupo";
            Grupo.MinimumWidth = 8;
            Grupo.Name = "Grupo";
            Grupo.Width = 150;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.Width = 230;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.MinimumWidth = 8;
            Hora.Name = "Hora";
            Hora.Width = 150;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(btCancelar);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 49);
            panel1.TabIndex = 4;
            // 
            // btCancelar
            // 
            btCancelar.FlatAppearance.BorderColor = Color.White;
            btCancelar.FlatAppearance.MouseDownBackColor = Color.White;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Image = (Image)resources.GetObject("btCancelar.Image");
            btCancelar.Location = new Point(592, 5);
            btCancelar.Margin = new Padding(2);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(27, 21);
            btCancelar.TabIndex = 5;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(99, 5);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 42);
            label3.TabIndex = 1;
            label3.Text = "Bitácora    ";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(419, 68);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(117, 23);
            dtpFecha.TabIndex = 15;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(356, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 16;
            label2.Text = "Fecha: ";
            // 
            // Bitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 376);
            Controls.Add(label2);
            Controls.Add(dtpFecha);
            Controls.Add(panel1);
            Controls.Add(dgvBitacora);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Bitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitacora";
            Load += Bitacora_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Label label1;
        private Button button1;
        private DataGridView dgvBitacora;
        private Panel panel1;
        private Label label3;
        private Button btCancelar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DateTimePicker dtpFecha;
        private Label label2;
    }
}