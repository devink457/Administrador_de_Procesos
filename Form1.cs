
/* Velveth Sarai Chavez Mejía 0901 23 6269 
   Agregue estas librerias para que el programa pudiera funcionar correctamente
 */

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
        /* Velveth Saraí Chavez Mejía 0901 23 6269
           Aqui agregue dos metodos para el  boton de actualizar funcione 
            igual que el txtcontador que es un timer        
         */
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

        /* Velveth Saraí Chavez Mejía 0901 23 6269
           Este metodo actua como administrador de tareas
            porque limpia la tabla, lista todos los procesos, muestra su nombre, Id, 
            memoria fisica usada, memoria virtual y sesion, tambien muestra un contador
            con el numero total de procesos encontrados
         */
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

        private void btnDetener_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == txtProceso.Text)
                    {
                        p.Kill(); // Matar el proceso
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("No selecicono ningun proceso" + x, "error al eliminar", MessageBoxButtons.OK);
            }
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void txtProceso_Click(object sender, EventArgs e)
        {

        }
        /* Velveth Sarai Chavez Mejia 0901 23 6269
           Cuando haces clic en cualquier fila, este evento agarra el nombre del proceso de la fila seleccionada y 
            lo muestra en el txtProceso
         */
        private void dgvAdministrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProceso.Text = dgvAdministrador.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
