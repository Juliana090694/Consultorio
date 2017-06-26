using Consultorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Controller
{
    class MedicoController
    {
        private static readonly MedicoController medicoC = new MedicoController();
        private static List<Medico> medicos = new List<Medico>();

        public static MedicoController MedicoC
        {
            get
            {
                return medicoC;
            }
        }

        internal List<Medico> Medicos
        {
            get
            {
                using (Model1Container model1 = new Model1Container())
                {
                    return model1.MedicoSet.ToList<Medico>();
                }
            }
        }

        public Medico search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.MedicoSet
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        public Medico search(string CRM)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.MedicoSet
                    .Where(c => c.CRM == CRM)
                    .FirstOrDefault();
            }
        }

        public void add(Medico medico)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.MedicoSet.Add(medico);
                model1.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                Medico medico = search(id);
                model1.MedicoSet.Attach(medico);
                model1.MedicoSet.Remove(medico);
                model1.SaveChanges();
            }
        }

        public void update(Medico medico)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.MedicoSet.Attach(medico);
                model1.Entry(medico).State = System.Data.Entity.EntityState.Modified;
                model1.SaveChanges();
            }
        }
    }
}
