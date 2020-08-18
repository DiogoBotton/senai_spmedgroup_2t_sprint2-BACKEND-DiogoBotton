using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Application.Queries.ViewModels
{
    public class MedicoViewModel
    {
        public long Id { get; set; }
        public string CRM { get; set; }
        public UsuarioViewModel Usuario { get; set; }
        public AreaSaudeEspecialidadeViewModel AreaSaudeEspecialidade { get; set; }
        public ClinicaViewModel Clinica { get; set; }

        public MedicoViewModel()
        {

        }
    }
}
