using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class ObjetivoConcluido:Base
    {
        public Guid alunoid { get; set; }
        public AlunoTurma aluno { get; set; }
        public Guid objetivoid { get; set; }
        public Objetivo objetivo { get; set; }
        public float nota { get; set; }
        
    }
}
