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
    public class ProntuarioPacienteRepository : IProntuarioPacienteRepository
    {
        public SpMedGroupContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public ProntuarioPacienteRepository(SpMedGroupContext context)
        {
            _context = context;
        }

        public ProntuarioPaciente Create(ProntuarioPaciente objeto)
        {
            return _context.ProntuariosPacientes.Add(objeto).Entity;
        }

        public ProntuarioPaciente GetById(long id)
        {
            return _context.ProntuariosPacientes.FirstOrDefault(x => x.Id == id);
        }
    }
}
