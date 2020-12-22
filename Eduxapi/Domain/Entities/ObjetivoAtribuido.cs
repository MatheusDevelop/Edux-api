using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class ObjetivoAtribuido:Base
    {
        public AlunoTurma alunoturma { get; set; }
        public string tarefa { get; set; }
    }
}
