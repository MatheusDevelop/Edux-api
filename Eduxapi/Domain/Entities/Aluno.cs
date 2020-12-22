using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Aluno:Base
    {
        public string Nickname { get; set; }
        public List<AlunoInstituicao> instituicaos { get; set; }
        public List<AlunoTurma> turmas { get; set; }
    }
}
