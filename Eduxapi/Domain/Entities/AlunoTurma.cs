using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class AlunoTurma:Base
    {
        public Guid alunoid { get; set; }
        public virtual Aluno aluno { get; set; }
        public Guid turmaid { get; set; }
        public virtual Turma turma { get; set; }
        public virtual List<ObjetivoConcluido> objetivosConcluidos { get; set; }

    }
}
