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
        
        //Singleton: retorna a instância da classe
        public static MedicoController MedicoC
        {
            get
            {
                return medicoC;
            }
        }

        //Retorna a lista de medicos 
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

        //procura medico por id
        public Medico search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.MedicoSet
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        //procura medico por crm
        public Medico search(string CRM)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.MedicoSet
                    .Where(c => c.CRM == CRM)
                    .FirstOrDefault();
            }
        }

        //adiciona medico
        public void add(Medico medico)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.MedicoSet.Add(medico);
                model1.SaveChanges();
            }
        }

        //deleta medico
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

        //Atualiza medico
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
