using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ImersaoDev.models;
using ImersaoDev.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ImersaoDev.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoService? alunoService = new AlunoService();



        [HttpGet]
        public IActionResult Get()
        {
            return Ok(alunoService?.GetAlunos());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Aluno novoAluno)
        {
            alunoService?.addAluno(novoAluno);
            return CreatedAtAction(nameof(Get), novoAluno);
        }
    }
}