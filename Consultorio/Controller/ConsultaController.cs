using Consultorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data;

namespace Consultorio.Controller
{
    class ConsultaController
    {
        private static readonly ConsultaController consultaC = new ConsultaController();
        private static List<Consulta> consultas = new List<Consulta>();

        //Singleton: retorna a instância fixa da classe
        public static ConsultaController ConsultaC
        {
            get
            {
                return consultaC;
            }
        }

        //Retorna a lista de consultas do banco ao ser chamado
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

        //Procura no banco por ID
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

        //Procura por data da consulta
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

        //Procura pela data da consulta para o médico em específico
        public List<Consulta> search(DateTime date, string medicoCRM)
        {
            using (Model1Container model1 = new Model1Container())
            {
                try
                {
                    List<Consulta> ca = model1.ConsultaSet
                    .Include(c => c.Paciente)
                    .Include(c => c.Medico)
                    .Where(c => c.Medico.CRM == medicoCRM)
                    .Where(v => DbFunctions.TruncateTime(v.DataConsulta) == DbFunctions.TruncateTime(date))
                    .ToList<Consulta>();
                    return ca;
                }
                catch (Exception e)
                {
                    return null;
                }

            }
        }

        //adiciona consulta
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

        //Deleta um registro
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

        //Atualiza um cadastro no banco
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
