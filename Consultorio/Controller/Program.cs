using Consultorio.Model;
using Consultorio.View;
using Consultorio.View.Lista;
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
        private static ConsultaSearchView consultaSearchView;
        private static MedicoSearchView medicoSearchView;
        private static PacienteSearchView pacienteSearchView;
        private static ProntuarioSearchView prontuarioSearchView;
        private static ListaConsulta listaconsulta;
        private static ListaMedico listamedico;
        private static ListaProntuario listaprontuario;
        private static ListaPaciente listapaciente;


        //Instancia todas as janelas e abre a principal
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
            consultaSearchView = new ConsultaSearchView();
            medicoSearchView = new MedicoSearchView();
            pacienteSearchView = new PacienteSearchView();
            prontuarioSearchView = new ProntuarioSearchView();
            listaconsulta = new ListaConsulta();
            listamedico = new ListaMedico();
            listapaciente = new ListaPaciente();
            listaprontuario = new ListaProntuario();

            Application.Run(mainForm);
        }

        //Abre a tela de paciente para novo paciente
        public static void openPaciente()
        {
            pacienteView.clearBoxes();
            pacienteView.setComponents();
            pacienteView.isEditable = true;
            pacienteView.isUpdating = false;
            pacienteView.ShowDialog(mainForm);
        }

        //abre a tela de paciente para atualizar ou visualizar paciente
        public static void openPaciente(Paciente paciente, bool isEditable)
        {
            pacienteView.clearBoxes();
            pacienteView.setComponents(paciente, isEditable);
            pacienteView.isEditable = isEditable;
            pacienteView.isUpdating = true;
            pacienteView.ShowDialog(mainForm);
        }

        //Abre tela para adicionar médico
        public static void openMedico()
        {
            medicoView.clearBoxes();
            medicoView.setComponents();
            medicoView.isEditable = true;
            medicoView.isUpdating = false;
            medicoView.ShowDialog(mainForm);
        }

        //abre tela para editar ou visualizar medico
        public static void openMedico(Medico medico, bool isEditable)
        {
            medicoView.clearBoxes();
            medicoView.setComponents(medico, isEditable);
            medicoView.isEditable = isEditable;
            medicoView.isUpdating = true;
            medicoView.ShowDialog(mainForm);
        }

        //abre tela de consulta para visualizar
        public static void openConsulta()
        {
            consultaView.clearBoxes();
            consultaView.setComponents();
            consultaView.isEditable = true;
            consultaView.isUpdating = false;
            consultaView.ShowDialog(mainForm);
        }

        //abre tela de consulta para editar ou visualizar
        public static void openConsulta(Consulta consulta, bool isEditable)
        {
            consultaView.clearBoxes();
            consultaView.setComponents(consulta, isEditable);
            consultaView.isEditable = isEditable;
            consultaView.isUpdating = true;
            consultaView.ShowDialog(mainForm);
        }

        //abre tela de prontuario para adicionar novo
        public static void openProntuario()
        {
            prontuarioView.clearBoxes();
            prontuarioView.setComponents();
            prontuarioView.isEditable = true;
            prontuarioView.isUpdating = false;
            prontuarioView.ShowDialog(mainForm);
        }

        //abre tela de prontuario para editar ou visualizar
        public static void openProntuario(Prontuario prontuario, bool isEditable)
        {
            prontuarioView.clearBoxes();
            prontuarioView.setComponents(prontuario, isEditable);
            prontuarioView.isEditable = isEditable;
            prontuarioView.isUpdating = true;
            prontuarioView.ShowDialog(mainForm);
        }

        //fecha as telas de cada um deles 
        public static void closePaciente()
        {
            pacienteView.isEditable = true;
            pacienteView.isUpdating = false;
            pacienteView.Close();
        }

        public static void closeMedico()
        {
            medicoView.isEditable = true;
            medicoView.isUpdating = false;
            medicoView.Close();
        }

        public static void closeConsulta()
        {
            consultaView.isEditable = true;
            consultaView.isUpdating = false;
            consultaView.Close();
        }

        public static void closeProntuario()
        {
            prontuarioView.isEditable = true;
            prontuarioView.isUpdating = false;
            prontuarioView.Close();
        }

        //abrem e fecham telas de pesquisas!

        public static void openConsultaSearch()
        {
            consultaSearchView.ShowDialog(mainForm);
            consultaSearchView.ClearBoxes();
        }

        public static void closeConsultaSearch()
        {
            consultaSearchView.Close();
        }

        public static void openMedicoSearch()
        {
            medicoSearchView.ShowDialog(mainForm);
            medicoSearchView.ClearBoxes();
        }

        public static void closeMedicoSearch()
        {
            medicoSearchView.Close();
        }

        public static void openPacienteSearch()
        {
            pacienteSearchView.ShowDialog(mainForm);
            pacienteSearchView.ClearBoxes();
        }

        public static void closePacienteSearch()
        {
            pacienteSearchView.Close();
        }

        public static void openProntuarioSearch()
        {
            prontuarioSearchView.ShowDialog(mainForm);
            prontuarioSearchView.ClearBoxes();
        }

        public static void closeProntuarioSearch()
        {
            prontuarioSearchView.Close();
        }
        public static void openListaProntuario()
        {
            listaprontuario.ShowDialog(mainForm);
        }
        public static void openListaPaciente()
        {
            listapaciente.ShowDialog(mainForm);
        }
        public static void openListaConsulta()
        {
            listaconsulta.ShowDialog(mainForm);
        }
        public static void openListaMedico()
        {
            listamedico.ShowDialog(mainForm);
        }
    }
}
