using AutoMapper;
using SpMedicalGroup_backend.Domains;
using SpMedicalGroup_backend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Infraestructure.ProfileAutoMapper
{
    public class AutoMap : Profile
    {
        public AutoMap()
        {
            // Domain para ViewModel
            CreateMap<Usuario, UsuarioViewModel>()
                .ForPath(s => s.TipoUsuario.Id, d => d.MapFrom(d => d.TipoUsuarioId));

            CreateMap<ProntuarioPaciente, ProntuarioPacienteViewModel>()
                .ForPath(s => s.Usuario.Id, d => d.MapFrom(d => d.UsuarioId));

            CreateMap<Medico, MedicoViewModel>()
                .ForPath(s => s.Usuario.Id, d => d.MapFrom(d => d.UsuarioId))
                .ForPath(s => s.AreaSaudeEspecialidade.Id, d => d.MapFrom(d => d.AreaSaudeEspecialidadeId))
                .ForPath(s => s.Clinica.Id, d => d.MapFrom(d => d.ClinicaId));

            CreateMap<Consulta, ConsultaViewModel>()
                .ForPath(s => s.Medico.Id, d => d.MapFrom(d => d.MedicoId))
                .ForPath(s => s.ProntuarioPaciente.Id, d => d.MapFrom(d => d.ProntuarioPacienteId))
                .ForPath(s => s.StatusConsulta.Id, d => d.MapFrom(d => d.StatusConsultaId));

        }
    }
}
