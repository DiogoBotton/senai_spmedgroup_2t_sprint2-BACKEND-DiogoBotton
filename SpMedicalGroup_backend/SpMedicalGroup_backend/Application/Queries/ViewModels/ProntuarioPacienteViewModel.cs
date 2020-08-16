using SpMedicalGroup_backend.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Application.Queries.ViewModels
{
    public class ProntuarioPacienteViewModel
    {
        public long Id { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public UsuarioViewModel Usuario { get; set; }

        public ProntuarioPacienteViewModel()
        {

        }
    }
}
