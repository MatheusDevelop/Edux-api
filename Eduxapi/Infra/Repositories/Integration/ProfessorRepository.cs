using Eduxapi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Infra.Repositories.Integration
{
    public class ProfessorRepository : BaseRepository,IProfessorRepository
    {
        public void AddObjetivo(Turma turma)
        {
            var newObjetivo = new Objetivo();
            newObjetivo.descricao = turma.objetivoDescribe;
            newObjetivo.turmaid = turma.id;
            con.objetivos.Add(newObjetivo);
            con.SaveChanges();
        }

        public List<ProfessorTurma> SearchTurmas(Guid idProfessor)
        {

            var turmas = con.professorTurmas.Include(e=>e.turma).ThenInclude(e=>e.objetivos).Include(e=>e.turma).ThenInclude(e=>e.alunos).ThenInclude(e=>e.aluno)
                .Where(e => e.professorid == idProfessor).ToList();

            return turmas;
        }
    }
}
