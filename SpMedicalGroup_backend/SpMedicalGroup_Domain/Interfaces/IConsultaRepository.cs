using SpMedicalGroup_Domain.Domains;
using SpMedicalGroup_Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_Domain.Interfaces
{
    public interface IConsultaRepository : IRepository<Consulta>
    {
        List<Consulta> GetAll();
    }
}
