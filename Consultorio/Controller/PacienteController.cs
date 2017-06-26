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

        public static PacienteController PacienteC
        {
            get
            {
                return pacienteC;
            }
        }

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

        public Paciente search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.PacienteSet
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        public Paciente search(string CPF)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.PacienteSet
                    .Where(c => c.CPF == CPF)
                    .FirstOrDefault();
            }
        }

        public void add(Paciente paciente)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.PacienteSet.Add(paciente);
                model1.SaveChanges();
            }
        }

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
