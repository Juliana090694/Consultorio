using Consultorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Consultorio.Controller
{
    class ProntuarioController
    {
        private static readonly ProntuarioController prontuarioC = new ProntuarioController();
        private static List<Prontuario> prontuarios = new List<Prontuario>();

        public static ProntuarioController ProntuarioC
        {
            get
            {
                return prontuarioC;
            }
        }

        internal List<Prontuario> Prontuarios
        {
            get
            {
                using (Model1Container model1 = new Model1Container())
                {
                    return model1.ProntuarioSet
                        .Include(c => c.Paciente)
                        .Include(c => c.Medico)
                        .Include(c => c.Consulta)
                        .ToList<Prontuario>();
                }
            }
        }

        public Prontuario search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.ProntuarioSet
                    .Include(c => c.Paciente)
                    .Include(c => c.Medico)
                    .Include(c => c.Consulta)
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        public Prontuario search(DateTime date)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.ProntuarioSet
                    .Include(c => c.Paciente)
                    .Include(c => c.Medico)
                    .Include(c => c.Consulta)
                    .Where(c => c.Consulta.DataConsulta == date)
                    .FirstOrDefault();
            }
        }

        public void add(Prontuario prontuario)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.PacienteSet.Attach(prontuario.Paciente);
                model1.MedicoSet.Attach(prontuario.Medico);
                model1.ConsultaSet.Attach(prontuario.Consulta);
                model1.ProntuarioSet.Add(prontuario);
                model1.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                //model1.PacienteSet.Attach(prontuario.Paciente);
                //model1.MedicoSet.Attach(prontuario.Medico);
                //model1.ConsultaSet.Attach(prontuario.Consulta);
                Prontuario prontuario = search(id);
                model1.ProntuarioSet.Attach(prontuario);
                model1.ProntuarioSet.Remove(prontuario);
                model1.SaveChanges();
            }
        }

        public void update(Prontuario prontuario)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.ProntuarioSet.Attach(prontuario);
                model1.PacienteSet.Attach(prontuario.Paciente);
                model1.MedicoSet.Attach(prontuario.Medico);
                model1.ConsultaSet.Attach(prontuario.Consulta);
                model1.Entry(prontuario).State = System.Data.Entity.EntityState.Modified;
                model1.SaveChanges();
            }
        }
    }
}
