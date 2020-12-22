using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class ProfessorTurma:Base
    {
        public Guid professorid { get; set; }
        public Professor professor { get; set; }
        public Guid turmaid { get; set; }
        public Turma turma { get; set; }
    }
}
