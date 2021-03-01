using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myfirstconection.Data.Repository;
using myfirstconection.domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfirstconection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly TurmaRepository repo;

        public TurmaController()
        {
            repo = new TurmaRepository();
        }

        [HttpGet]
        public IEnumerable<Turma> Get()
        {
            return repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Turma Get(int id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Turma> Post([FromBody] Turma turma)
        {
            repo.Incluir(turma);

            return repo.SelecionarTudo();
        }
        [HttpPut]
        public IEnumerable<Turma> Put([FromBody] Turma turma)
        {
            repo.Alterar(turma);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Turma> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
