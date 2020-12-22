using Eduxapi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Infra.Repositories
{
    interface IProfessorRepository
    {
        public List<ProfessorTurma> SearchTurmas(Guid idProfessor);
        public void AddObjetivo(Turma turma);
    }
}
