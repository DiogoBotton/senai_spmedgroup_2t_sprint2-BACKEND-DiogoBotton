﻿using SpMedicalGroup_backend.Infraestructure.Contexts;
using SpMedicalGroup_Domain.Domains;
using SpMedicalGroup_Domain.Interfaces;
using SpMedicalGroup_Domain.SeedWork;
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

        public List<Medico> GetAll()
        {
            return _context.Medicos.ToList();
        }
    }
}
