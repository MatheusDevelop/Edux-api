using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Professor:Base
    {
        public string Nickname { get; set; }
        public ICollection<ProfessorTurma> turmas { get; set; }
        public ICollection<ProfessorInstituicao> instituicaos { get; set; }

    }
}
