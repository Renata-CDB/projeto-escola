using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstconection.domain.Model
{
   public class TurmaProfessor:IEntity
    {
        public int Id { get; set; }
        public int IdProfessor { get; set; }
        public Professor Professor { get; set; }
        public int IdTurma { get; set; }
        public Turma Turma { get; set; }
    }
}
