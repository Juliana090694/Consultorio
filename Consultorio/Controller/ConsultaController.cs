using Consultorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Consultorio.Controller
{
    class ConsultaController
    {
        private static readonly ConsultaController consultaC = new ConsultaController();
        private static List<Consulta> consultas = new List<Consulta>();

        public static ConsultaController ConsultaC
        {
            get
            {
                return consultaC;
            }
        }

        internal List<Consulta> Consultas
        {
            get
            {
                using (Model1Container model1 = new Model1Container())
                {
                    return model1.ConsultaSet
                        .Include(c => c.Paciente)
                        .Include(c => c.Medico)
                        .ToList<Consulta>();
                }
            }
        }

        public Consulta search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.ConsultaSet
                    .Include(c => c.Paciente)
                    .Include(c => c.Medico)
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        public Consulta search(DateTime date)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.ConsultaSet
                    .Include(c => c.Paciente)
                    .Include(c => c.Medico)
                    .Where(c => c.DataConsulta == date)
                    .FirstOrDefault();
            }
        }

        public void add(Consulta consulta)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.PacienteSet.Attach(consulta.Paciente);
                model1.MedicoSet.Attach(consulta.Medico);
                model1.ConsultaSet.Add(consulta);
                model1.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                //model1.PacienteSet.Attach(consulta.Paciente);
                //model1.MedicoSet.Attach(consulta.Medico);
                Consulta consulta = search(id);
                model1.ConsultaSet.Attach(consulta);
                model1.ConsultaSet.Remove(consulta);
                model1.SaveChanges();
            }
        }

        public void update(Consulta consulta)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.ConsultaSet.Attach(consulta);
                model1.PacienteSet.Attach(consulta.Paciente);
                model1.MedicoSet.Attach(consulta.Medico);
                model1.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
                model1.SaveChanges();
            }
        }
    }
}
