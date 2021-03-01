using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myfirstconection.Data.Repository;
using myfirstconection.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfirstconection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly ProfessorRepository repo;

        public ProfessorController()
        {
            repo = new ProfessorRepository();
        }

        [HttpGet]
        public IEnumerable<Professor> Get()
        {
            return repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Professor Get(int id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Professor> Post([FromBody] Professor prof)
        {
            repo.Incluir(prof);

            return repo.SelecionarTudo();
        }
        [HttpPut]
        public IEnumerable<Professor> Put([FromBody] Professor prof)
        {
            repo.Alterar(prof);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Professor> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
