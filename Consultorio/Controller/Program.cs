using Consultorio.Model;
using Consultorio.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public static class Program
    {
        private static Form1 mainForm;
        private static PacienteView pacienteView;
        private static MedicoView medicoView;
        private static ConsultaView consultaView;
        private static ProntuarioView prontuarioView;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new Form1();
            pacienteView = new PacienteView();
            medicoView = new MedicoView();
            consultaView = new ConsultaView();
            prontuarioView = new ProntuarioView();
            Application.Run(mainForm);
        }

        public static void openPaciente()
        {
            pacienteView.ShowDialog(mainForm);
        }

        public static void openPaciente(Paciente paciente, bool isEditable)
        {
            pacienteView.ShowDialog(mainForm);
        }
    }
}
