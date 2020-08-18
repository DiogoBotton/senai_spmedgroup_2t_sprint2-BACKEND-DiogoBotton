﻿using SpMedicalGroup_Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_Domain.Domains
{
    public class Usuario : AbstractDomain
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public long TipoUsuarioId { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nome, string email, string senha, long tipoUsuarioId)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            TipoUsuarioId = tipoUsuarioId;
        }
    }
}
