namespace Administrador_de_Procesos
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvAdministrador = new DataGridView();
            dgv = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvFisica = new DataGridViewTextBoxColumn();
            dgvVirtual = new DataGridViewTextBoxColumn();
            dgvCPU = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnDetener = new Button();
            btnSalir = new Button();
            txtContador = new Label();
            label1 = new Label();
            txtProceso = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAdministrador).BeginInit();
            SuspendLayout();
            // 
            // dgvAdministrador
            // 
            dgvAdministrador.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAdministrador.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvAdministrador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministrador.Columns.AddRange(new DataGridViewColumn[] { dgv, dgvID, dgvFisica, dgvVirtual, dgvCPU });
            dgvAdministrador.Location = new Point(20, 47);
            dgvAdministrador.Margin = new Padding(3, 2, 3, 2);
            dgvAdministrador.Name = "dgvAdministrador";
            dgvAdministrador.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new Font("Lucida Console", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvAdministrador.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvAdministrador.Size = new Size(771, 298);
            dgvAdministrador.TabIndex = 0;
            // 
            // dgv
            // 
            dgv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = Color.Turquoise;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgv.DefaultCellStyle = dataGridViewCellStyle1;
            dgv.HeaderText = "Proceso";
            dgv.MinimumWidth = 6;
            dgv.Name = "dgv";
            // 
            // dgvID
            // 
            dgvID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.Turquoise;
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dgvID.DefaultCellStyle = dataGridViewCellStyle2;
            dgvID.HeaderText = "ID";
            dgvID.MinimumWidth = 6;
            dgvID.Name = "dgvID";
            // 
            // dgvFisica
            // 
            dgvFisica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.Turquoise;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dgvFisica.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFisica.HeaderText = "Memoria Física";
            dgvFisica.MinimumWidth = 6;
            dgvFisica.Name = "dgvFisica";
            // 
            // dgvVirtual
            // 
            dgvVirtual.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = Color.Turquoise;
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvVirtual.DefaultCellStyle = dataGridViewCellStyle4;
            dgvVirtual.HeaderText = "Memoria Virtual";
            dgvVirtual.MinimumWidth = 6;
            dgvVirtual.Name = "dgvVirtual";
            // 
            // dgvCPU
            // 
            dgvCPU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = Color.Turquoise;
            dataGridViewCellStyle5.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dgvCPU.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCPU.HeaderText = "CPU";
            dgvCPU.MinimumWidth = 6;
            dgvCPU.Name = "dgvCPU";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Yellow;
            btnActualizar.Location = new Point(21, 316);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(101, 29);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.Green;
            btnDetener.Location = new Point(143, 316);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(98, 29);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Blue;
            btnSalir.Location = new Point(689, 316);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtContador
            // 
            txtContador.AutoSize = true;
            txtContador.ForeColor = SystemColors.HotTrack;
            txtContador.Location = new Point(34, 357);
            txtContador.Name = "txtContador";
            txtContador.Size = new Size(38, 15);
            txtContador.TabIndex = 4;
            txtContador.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(596, 357);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre del Proceso";
            // 
            // txtProceso
            // 
            txtProceso.AutoSize = true;
            txtProceso.ForeColor = SystemColors.HotTrack;
            txtProceso.Location = new Point(717, 357);
            txtProceso.Name = "txtProceso";
            txtProceso.Size = new Size(13, 15);
            txtProceso.TabIndex = 6;
            txtProceso.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 410);
            Controls.Add(txtProceso);
            Controls.Add(label1);
            Controls.Add(txtContador);
            Controls.Add(btnSalir);
            Controls.Add(btnDetener);
            Controls.Add(btnActualizar);
            Controls.Add(dgvAdministrador);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Padding = new Padding(18, 60, 18, 15);
            Text = "Administrador de Tareas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdministrador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAdministrador;
        private DataGridViewTextBoxColumn dgv;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvFisica;
        private DataGridViewTextBoxColumn dgvVirtual;
        private DataGridViewTextBoxColumn dgvCPU;
        private Button btnActualizar;
        private Button btnDetener;
        private Button btnSalir;
        private Label txtContador;
        private Label label1;
        private Label txtProceso;
    }
}
