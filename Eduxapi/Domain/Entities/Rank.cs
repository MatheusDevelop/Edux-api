using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Rank:Base
    {
        public int pontos { get; set; }
        public Guid alunoid { get; set; }
        public Aluno aluno { get; set; }
    }
}
