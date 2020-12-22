using Eduxapi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Infra.Repositories
{
    interface IInstituicaoRepository
    {
        public List<ProfessorInstituicao> SearchProfessores(Guid idInstituicao);
        public List<AlunoInstituicao> SearchAlunos(Guid idInstituicao);
        public List<Aluno> SearchAllAlunos(string name);
        

    }
}
