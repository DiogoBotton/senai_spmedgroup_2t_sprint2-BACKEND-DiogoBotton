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
    public class MedicoRepository : IMedicoRepository
    {
        public SpMedGroupContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public MedicoRepository(SpMedGroupContext context)
        {
            _context = context;
        }

        public Medico Create(Medico objeto)
        {
            return _context.Medicos.Add(objeto).Entity;
        }

        public Medico GetById(long id)
        {
            return _context.Medicos.FirstOrDefault(x => x.Id == id);
        }
    }
}
