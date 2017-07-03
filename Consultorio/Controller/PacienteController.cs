using Consultorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Controller
{
    class PacienteController
    {
        private static readonly PacienteController pacienteC = new PacienteController();
        private static List<Paciente> pacientes = new List<Paciente>();

        //Singleton: retorna a instância do paciente
        public static PacienteController PacienteC
        {
            get
            {
                return pacienteC;
            }
        }

        //Retorna lista de pacientes
        internal List<Paciente> Pacientes
        {
            get
            {
                using (Model1Container model1 = new Model1Container())
                {
                    return model1.PacienteSet.ToList<Paciente>();
                }
            }
        }

        //Procura paciente por id
        public Paciente search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.PacienteSet
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        //Procura paciente por cpf
        public Paciente search(string CPF)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.PacienteSet
                    .Where(c => c.CPF == CPF)
                    .FirstOrDefault();
            }
        }

        //adiciona paciente
        public void add(Paciente paciente)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.PacienteSet.Add(paciente);
                model1.SaveChanges();
            }
        }

        //remove paciente
        public void delete(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                Paciente paciente = search(id);
                model1.PacienteSet.Attach(paciente);
                model1.PacienteSet.Remove(paciente);
                model1.SaveChanges();
            }
        }

        //Atualiza paciente
        public void update(Paciente paciente)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.PacienteSet.Attach(paciente);
                model1.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
                model1.SaveChanges();
            }
        }
    }
}
