using SpMedicalGroup_backend.Domains;
using SpMedicalGroup_backend.Infraestructure.Contexts;
using SpMedicalGroup_backend.Interfaces;
using SpMedicalGroup_backend.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Infraestructure.Repositories
{
    public class AreaSaudeEspecialidadeRepository : IAreaSaudeEspecialidadeRepository
    {
        public SpMedGroupContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public AreaSaudeEspecialidadeRepository(SpMedGroupContext context)
        {
            _context = context;
        }

        public AreaSaudeEspecialidade Create(AreaSaudeEspecialidade objeto)
        {
            return _context.AreasSaudeEspecialidades.Add(objeto).Entity;
        }

        public AreaSaudeEspecialidade GetById(long id)
        {
            return _context.AreasSaudeEspecialidades.FirstOrDefault(x => x.Id == id);
        }
    }
}
