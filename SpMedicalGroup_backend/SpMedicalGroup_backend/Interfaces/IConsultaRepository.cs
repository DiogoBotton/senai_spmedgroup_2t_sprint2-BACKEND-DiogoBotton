using SpMedicalGroup_backend.Domains;
using SpMedicalGroup_backend.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Interfaces
{
    public interface IConsultaRepository : IRepository<Consulta>
    {
        List<Consulta> GetAll();
    }
}
