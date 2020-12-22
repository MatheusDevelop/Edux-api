using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Instituicao:Base
    {
        public string Nickname { get; set; }
        public List<Curso> cursos { get; set; }
        public List<Turma> turmas { get; set; }
    }
}
