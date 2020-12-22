using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class AlunoInstituicao:Base
    {
        public Aluno aluno { get; set; }
        public Instituicao instituicao { get; set; }
    }
}
