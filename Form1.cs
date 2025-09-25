using System.Diagnostics;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador_de_Procesos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            UpdateProcessList();
            txtContador.Enabled = true;
        }

        private void txtContador_Tick(object sender, EventArgs e)
        {
            UpdateProcessList();
        }


        private void UpdateProcessList()
        {
            dgvAdministrador.Rows.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                int n = dgvAdministrador.Rows.Add();
                dgvAdministrador.Rows[n].Cells[0].Value = p.ProcessName;
                dgvAdministrador.Rows[n].Cells[1].Value = p.Id;
                dgvAdministrador.Rows[n].Cells[2].Value = p.WorkingSet64;
                dgvAdministrador.Rows[n].Cells[3].Value = p.VirtualMemorySize64;
                dgvAdministrador.Rows[n].Cells[4].Value = p.SessionId;
            }
            txtContador.Text = "Procesos Actuales: " + dgvAdministrador.Rows.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Josue Guillermo Abril del Cid
        private void btnDetener_Click(object sender, EventArgs e)//Boton para detener el proceso
        {
            try//Try catch para evitar errores
            {
                foreach (Process p in Process.GetProcesses())//Recorrer todos los procesos
                {
                    if (p.ProcessName == txtProceso.Text)//Si el nombre del proceso es igual al que se ingreso en el textbox
                    {
                        p.Kill(); // Matar el proceso
                    }
                }
            }
            catch (Exception x)//Catch para mostrar el error
            {
                MessageBox.Show("No selecicono ningun proceso" + x, "error al eliminar", MessageBoxButtons.OK);//Mensaje de error
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)//Boton para salir del programa
        {
            Close();//Cerrar el programa
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void txtProceso_Click(object sender, EventArgs e)
        {

        }

        private void dgvAdministrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProceso.Text = dgvAdministrador.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
