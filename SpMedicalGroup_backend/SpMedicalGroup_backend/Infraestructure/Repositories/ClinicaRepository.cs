﻿using SpMedicalGroup_backend.Domains;
using SpMedicalGroup_backend.Infraestructure.Contexts;
using SpMedicalGroup_backend.Interfaces;
using SpMedicalGroup_backend.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Infraestructure.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        public SpMedGroupContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public ClinicaRepository(SpMedGroupContext context)
        {
            _context = context;
        }

        public Clinica Create(Clinica objeto)
        {
            return _context.Clinicas.Add(objeto).Entity;
        }

        public Clinica GetById(long id)
        {
            return _context.Clinicas.FirstOrDefault(x => x.Id == id);
        }
    }
}
