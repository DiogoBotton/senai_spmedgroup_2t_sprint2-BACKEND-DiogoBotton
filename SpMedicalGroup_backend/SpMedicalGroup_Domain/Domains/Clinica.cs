using SpMedicalGroup_Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_Domain.Domains
{
    public class Clinica : AbstractDomain
    {
        public string Endereco { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public DateTime HoraFuncionamentoInicio { get; set; }
        public DateTime HoraFuncionamentoFim { get; set; }
        public string CNPJ { get; set; }

        public Clinica()
        {

        }
    }
}
