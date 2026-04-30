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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btCancelar = new Button();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 106);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 41);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 106);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(786, 100);
            button1.Name = "button1";
            button1.Size = new Size(50, 49);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Grupo, Fecha, Hora });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(33, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(834, 360);
            dataGridView1.TabIndex = 3;
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
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 81);
            panel1.TabIndex = 4;
            // 
            // btCancelar
            // 
            btCancelar.FlatAppearance.BorderColor = Color.White;
            btCancelar.FlatAppearance.MouseDownBackColor = Color.White;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Image = (Image)resources.GetObject("btCancelar.Image");
            btCancelar.Location = new Point(846, 9);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(39, 35);
            btCancelar.TabIndex = 5;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(141, 9);
            label3.Name = "label3";
            label3.Size = new Size(257, 62);
            label3.TabIndex = 1;
            label3.Text = "Bitácora    ";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkRed;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Image = Properties.Resources.app;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(719, 558);
            button4.Name = "button4";
            button4.Size = new Size(148, 48);
            button4.TabIndex = 14;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.ForestGreen;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Image = Properties.Resources.edit__1_;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(548, 558);
            button5.Name = "button5";
            button5.Size = new Size(148, 48);
            button5.TabIndex = 13;
            button5.Text = "Editar";
            button5.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(599, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 31);
            dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(508, 109);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 16;
            label2.Text = "Fecha: ";
            // 
            // Bitacora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 627);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitacora";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label3;
        private Button btCancelar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private Button button4;
        private Button button5;
        private DateTimePicker dateTimePicker1;
        private Label label2;
    }
}