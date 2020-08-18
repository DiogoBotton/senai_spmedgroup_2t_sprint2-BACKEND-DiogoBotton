using SpMedicalGroup_backend.Infraestructure.Contexts;
using SpMedicalGroup_Domain.Domains;
using SpMedicalGroup_Domain.Interfaces;
using SpMedicalGroup_Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Infraestructure.Repositories
{
    public class StatusConsultaRepository : IStatusConsultaRepository
    {
        public SpMedGroupContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public StatusConsultaRepository(SpMedGroupContext context)
        {
            _context = context;
        }

        public StatusConsulta Create(StatusConsulta statusConsulta)
        {
            return _context.StatusConsultas.Add(statusConsulta).Entity;
        }

        public StatusConsulta FindByDescricao(string descricao)
        {
            return _context.StatusConsultas.FirstOrDefault(x => x.Titulo == descricao);
        }

        public StatusConsulta FindById(long id)
        {
            return _context.StatusConsultas.FirstOrDefault(x => x.Id == id);
        }
    }
}
