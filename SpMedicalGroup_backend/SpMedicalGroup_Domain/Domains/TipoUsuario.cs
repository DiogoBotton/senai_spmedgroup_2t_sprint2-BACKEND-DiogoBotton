﻿using SpMedicalGroup_Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_Domain.Domains
{
    public class TipoUsuario : AbstractDomain
    {
        public string Titulo { get; set; }

        public TipoUsuario()
        {

        }
        public TipoUsuario(string titulo)
        {
            Titulo = titulo;
        }
    }
}
