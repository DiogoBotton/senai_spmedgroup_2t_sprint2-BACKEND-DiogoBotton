using SpMedicalGroup_backend.Application.Queries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Queries.Interfaces
{
    public interface IConsultaQueries
    {
        List<ConsultaViewModel> GetAllConsultasCompletas();
    }
}
