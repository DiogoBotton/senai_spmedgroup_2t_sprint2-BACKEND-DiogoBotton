using SpMedicalGroup_Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_Domain.Domains
{
    public class ProntuarioPaciente : AbstractDomain
    {
        public string RG { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public long UsuarioId { get; set; }

        public ProntuarioPaciente()
        {

        }
    }
}
