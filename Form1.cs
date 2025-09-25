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
    }
}
