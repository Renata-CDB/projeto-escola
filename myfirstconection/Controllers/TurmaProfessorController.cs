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
    public class TurmaProfessorController : ControllerBase
    {
        private readonly TurmaProfessorRepository repo;

        public TurmaProfessorController()
        {
            repo = new TurmaProfessorRepository();
        }

        [HttpGet]
        public IEnumerable<TurmaProfessor> Get()
        {   
            return repo.SelecionarTudo();
        }
        
        [HttpGet("{id}")]
        public TurmaProfessor Get(int id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<TurmaProfessor> Post([FromBody] TurmaProfessor tp)
        {
            repo.Incluir(tp);

            return repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<TurmaProfessor> Put([FromBody] TurmaProfessor tp)
        {
            repo.Alterar(tp);
            return repo.SelecionarTudo();
        }
        
        [HttpDelete("{id}")]
        public IEnumerable<TurmaProfessor> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
