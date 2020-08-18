using SpMedicalGroup_Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_Domain.Domains
{
    public class StatusConsulta : AbstractDomain
    {
        public string Titulo { get; set; }

        public StatusConsulta()
        {

        }
        public StatusConsulta(string titulo)
        {
            Titulo = titulo;
        }
    }
}
