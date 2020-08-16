using SpMedicalGroup_backend.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Application.Queries.ViewModels
{
    public class UsuarioViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuarioViewModel TipoUsuario { get; set; }

        public UsuarioViewModel()
        {
        }
    }
}
