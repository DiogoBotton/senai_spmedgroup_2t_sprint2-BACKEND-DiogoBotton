using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Application.Queries.ViewModels
{
    public class ConsultaViewModel
    {
        public long Id { get; set; }
        public DateTime DataHoraConsulta { get; set; }
        public string Descricao { get; set; }
        public MedicoViewModel Medico { get; set; }
        public ProntuarioPacienteViewModel ProntuarioPaciente { get; set; }
        public StatusConsultaViewModel StatusConsulta { get; set; }

        public ConsultaViewModel()
        {

        }
    }
}
