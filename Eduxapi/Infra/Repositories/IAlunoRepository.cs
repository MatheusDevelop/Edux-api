using Eduxapi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Infra.Repositories
{
    public interface IAlunoRepository
    {
        public List<AlunoTurma> SearchTurmas(Guid idAluno);        
    }
}
