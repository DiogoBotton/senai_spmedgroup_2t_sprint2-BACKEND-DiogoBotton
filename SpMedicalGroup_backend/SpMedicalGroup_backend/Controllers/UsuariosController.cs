using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpMedicalGroup_backend.Application.InputRequests;
using SpMedicalGroup_Domain.Domains;
using SpMedicalGroup_Domain.Interfaces;

namespace SpMedicalGroup_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository usuarioRepository { get; set; }
        private ITipoUsuarioRepository tipoUsuarioRepository { get; set; }

        public UsuariosController(IUsuarioRepository usuarioRepository, ITipoUsuarioRepository tipoUsuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
            this.tipoUsuarioRepository = tipoUsuarioRepository;
        }

        [HttpPost]
        public async Task<IActionResult> ExemploHashSenha(UsuarioInput input)
        {
            try
            {
                var tipoUsuario = tipoUsuarioRepository.GetById(input.TipoUsuarioId);

                if(tipoUsuario == null)
                {
                    return StatusCode(404, new List<string>() 
                    { 
                        $"TipoUsuario id [{input.TipoUsuarioId}] não encontrado no banco de dados"
                    });
                }

                //Gera Hash da senha digitada
                var senhaHash = new PasswordHasher<UsuarioInput>().HashPassword(input, input.Senha);
                
                Usuario usuario = null;
                try
                {
                    usuario = new Usuario(input.Nome, input.Email, senhaHash, input.TipoUsuarioId);
                }
                catch (Exception ex)
                {
                    return StatusCode(400, new List<string>() 
                    { 
                        "Ocorreu um erro na criação do usuário", 
                        ex.Message 
                    });
                }

                usuarioRepository.Create(usuario);

                await usuarioRepository.UnitOfWork.SaveDbChanges();

                //Apenas para verificar se a senha esta como HashCode
                return StatusCode(200, usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(new List<string>()
                    {
                        "Ocorreu um erro desconhecido na requisição de criar o usuário, tente novamente mais tarde.",
                        ex.Message
                    });
            }
        }
    }
}
