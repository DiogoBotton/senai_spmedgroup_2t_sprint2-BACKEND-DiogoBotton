using SpMedicalGroup_backend.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Application.Queries.ViewModels
{
    public class StatusConsultaViewModel
    {
        public long Id { get; set; }
        public string Titulo { get; set; }

        public StatusConsultaViewModel()
        {

        }
        public StatusConsultaViewModel(string titulo)
        {
            Titulo = titulo;
        }
    }
}
