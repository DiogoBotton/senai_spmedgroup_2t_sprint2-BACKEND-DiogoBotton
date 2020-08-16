using AutoMapper;
using SpMedicalGroup_backend.Application.Queries.ViewModels;
using SpMedicalGroup_backend.Interfaces;
using SpMedicalGroup_backend.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Queries.QueriesViewModels
{
    public class ConsultaQueries : IConsultaQueries
    {
        public IConsultaRepository consultaRepository;
        public IMedicoRepository medicoRepository;
        public ITipoUsuarioRepository tipoUsuarioRepository;
        public IClinicaRepository clinicaRepository;
        public IUsuarioRepository usuarioRepository;
        public IAreaSaudeEspecialidadeRepository areaSaudeEspecialidadeRepository;
        public IStatusConsultaRepository statusConsultaRepository;
        public IProntuarioPacienteRepository prontuarioPacienteRepository;
        public IMapper _mapper;

        public ConsultaQueries(IConsultaRepository consultaRepository, IMedicoRepository medicoRepository, ITipoUsuarioRepository tipoUsuarioRepository, IClinicaRepository clinicaRepository, IUsuarioRepository usuarioRepository, IAreaSaudeEspecialidadeRepository areaSaudeEspecialidadeRepository, IStatusConsultaRepository statusConsultaRepository, IProntuarioPacienteRepository prontuarioPacienteRepository, IMapper mapper)
        {
            this.consultaRepository = consultaRepository;
            this.medicoRepository = medicoRepository;
            this.tipoUsuarioRepository = tipoUsuarioRepository;
            this.clinicaRepository = clinicaRepository;
            this.usuarioRepository = usuarioRepository;
            this.areaSaudeEspecialidadeRepository = areaSaudeEspecialidadeRepository;
            this.statusConsultaRepository = statusConsultaRepository;
            this.prontuarioPacienteRepository = prontuarioPacienteRepository;
            _mapper = mapper;
        }

        public List<ConsultaViewModel> GetAllConsultasCompletas()
        {
            var consultasDb = consultaRepository.GetAll();

            // Exemplo de mapeamento com o AutoMapper
            List<ConsultaViewModel> consultasVM = _mapper.Map<List<ConsultaViewModel>>(consultasDb);

            // OBS: As classes vem vazias, apenas com a propriedade "Id" preenchida, com isso, devemos buscar as respectivas entidades com estes ID's
            consultasVM.ForEach(x =>
            {
                //Recupera todas as informações do Médico
                x.Medico = _mapper.Map<MedicoViewModel>(medicoRepository.GetById(x.Medico.Id));

                //Recupera a especialidade do médico
                x.Medico.AreaSaudeEspecialidade = _mapper.Map<AreaSaudeEspecialidadeViewModel>(areaSaudeEspecialidadeRepository.GetById(x.Medico.AreaSaudeEspecialidade.Id));

                //Recupera à qual clínica o médico é vinculado
                x.Medico.Clinica = _mapper.Map<ClinicaViewModel>(clinicaRepository.GetById(x.Medico.Clinica.Id));

                //Recupera à qual usuário o médico é vinculado
                x.Medico.Usuario = _mapper.Map<UsuarioViewModel>(usuarioRepository.GetById(x.Medico.Usuario.Id));

                //Recupera o tipo do usuário
                x.Medico.Usuario.TipoUsuario = _mapper.Map<TipoUsuarioViewModel>(tipoUsuarioRepository.GetById(x.Medico.Usuario.TipoUsuario.Id));



                //Recupera todas as informações do Paciente
                x.ProntuarioPaciente = _mapper.Map<ProntuarioPacienteViewModel>(prontuarioPacienteRepository.GetById(x.ProntuarioPaciente.Id));

                //Recupera à qual usuário o paciente é vinculado
                x.ProntuarioPaciente.Usuario = _mapper.Map<UsuarioViewModel>(usuarioRepository.GetById(x.ProntuarioPaciente.Usuario.Id));

                //Recupera o tipo do usuário
                x.ProntuarioPaciente.Usuario.TipoUsuario = _mapper.Map<TipoUsuarioViewModel>(tipoUsuarioRepository.GetById(x.ProntuarioPaciente.Usuario.TipoUsuario.Id));

                //Recupera o status da consulta
                x.StatusConsulta = _mapper.Map<StatusConsultaViewModel>(statusConsultaRepository.FindById(x.StatusConsulta.Id));
            });

            return consultasVM;
        }

        public MedicoViewModel GetMedicoByConsultaRm(string crm)
        {
            var consultas = consultaRepository.GetAll();

            var medicos = medicoRepository.GetAll();

            consultas.ForEach(x =>
            {
                medicos.RemoveAll(m => m.Id != x.MedicoId);
            });

            var medicoVM = _mapper.Map<MedicoViewModel>(medicos.FirstOrDefault(x => x.CRM == crm));

            return medicoVM;
        }
    }
}
