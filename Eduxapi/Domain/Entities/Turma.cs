using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Turma:Base
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public Guid instituicaoid { get; set; }
        public Instituicao instituicao { get; set; }
        public Guid cursoid { get; set; }
        public Curso curso { get; set; }
        public virtual List<AlunoTurma> alunos { get; set; }
        public virtual List<ProfessorTurma> professores { get; set; }
        public virtual List<Objetivo> objetivos { get; set; }

        [NotMapped]
        public string objetivoDescribe { get; set; }

    }
}
