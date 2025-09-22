using System.Diagnostics;

namespace Administrador_de_Procesos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
