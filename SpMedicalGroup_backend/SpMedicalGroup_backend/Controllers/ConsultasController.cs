using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpMedicalGroup_backend.Infraestructure.Contexts;
using SpMedicalGroup_backend.Interfaces;
using SpMedicalGroup_backend.Queries.Interfaces;

namespace SpMedicalGroup_backend.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        public IConsultaQueries consultaQueries;

        public ConsultasController(IConsultaQueries consultaQueries)
        {
            this.consultaQueries = consultaQueries;
        }

        [HttpGet]
        public IActionResult GetAllConsultas()
        {
            try
            {
                var consultas = consultaQueries.GetAllConsultasCompletas();

                if (consultas.Any())
                    return StatusCode(200, consultas);
                else
                    return StatusCode(204, consultas);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro na requisição: [{ex.Message}]");
            }
        }
    }
}
