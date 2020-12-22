using Eduxapi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Infra.Repositories.Integration
{
    public class InstituicaoRepository : BaseRepository, IInstituicaoRepository
    {
        public void AddTurma(Turma turma)
        {
            con.turmas.Add(turma);
            con.SaveChanges();
        }
        public void AddCurso(Curso curso)
        {
            con.cursos.Add(curso);
            con.SaveChanges();
        }
        public void AddAluno(AlunoTurma alunoTurma)
        {
            con.alunoTurmas.Add(alunoTurma);
            con.SaveChanges();
        }
        public void AddTurma(ProfessorTurma professorTurma)
        {
            con.professorTurmas.Add(professorTurma);
            con.SaveChanges();
        }
        public Instituicao SearchForId(Guid id)
        {
            return con.instituicaos.Include(e=>e.cursos).Include(e=>e.turmas).ThenInclude(e=>e.alunos)
                .Include(e=>e.turmas).ThenInclude(e=>e.professores)
                .FirstOrDefault(e => e.id == id);
        }
        public List<Aluno> SearchAllAlunos(string name)
        {
            return con.alunos.Where(e => e.Nickname.Substring(0, name.Length) == name).ToList();
        }
        public List<Professor> SearchAllProfessores(string name)
        {
            return con.professores.Where(e => e.Nickname.Substring(0, name.Length) == name).ToList();
        }

        public List<AlunoInstituicao> SearchAlunos(Guid idInstituicao)
        {
            throw new NotImplementedException();
        }

        public List<ProfessorInstituicao> SearchProfessores(Guid idInstituicao)
        {
            throw new NotImplementedException();
        }
    }
}
