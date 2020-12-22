using Eduxapi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Infra.Repositories.Integration
{
    public class AlunoRepository : BaseRepository,IAlunoRepository
    {
        public List<AlunoTurma> SearchTurmas(Guid idAluno)
        {
            var user = con.alunoTurmas.Include(e=>e.turma).ThenInclude(c=>c.objetivos)
                .Include(e=>e.objetivosConcluidos).Where(e=>e.alunoid == idAluno).ToList();
            return user;
        }
    }
}
