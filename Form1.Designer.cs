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
            ((System.ComponentModel.ISupportInitialize)dgvAdministrador).BeginInit();
            SuspendLayout();
            // 
            // dgvAdministrador
            // 
            dgvAdministrador.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAdministrador.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvAdministrador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministrador.Columns.AddRange(new DataGridViewColumn[] { dgv, dgvID, dgvFisica, dgvVirtual, dgvCPU });
            dgvAdministrador.Location = new Point(23, 63);
            dgvAdministrador.Name = "dgvAdministrador";
            dgvAdministrador.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new Font("Lucida Console", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvAdministrador.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvAdministrador.Size = new Size(881, 367);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 547);
            Controls.Add(dgvAdministrador);
            Name = "Form1";
            Text = "Administrador de Tareas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdministrador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdministrador;
        private DataGridViewTextBoxColumn dgv;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvFisica;
        private DataGridViewTextBoxColumn dgvVirtual;
        private DataGridViewTextBoxColumn dgvCPU;
    }
}
