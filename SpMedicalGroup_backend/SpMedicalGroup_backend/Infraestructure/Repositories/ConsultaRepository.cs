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
    public class ConsultaRepository : IConsultaRepository
    {
        public SpMedGroupContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public ConsultaRepository(SpMedGroupContext context)
        {
            _context = context;
        }

        public Consulta Create(Consulta objeto)
        {
            return _context.Consultas.Add(objeto).Entity;
        }

        public List<Consulta> GetAll()
        {
            return _context.Consultas.ToList();
        }
    }
}
