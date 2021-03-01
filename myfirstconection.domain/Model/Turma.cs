using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstconection.domain.Model
{
     public class Turma:IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<TurmaProfessor> TurmaProfessor { get; set; }
    }
}
