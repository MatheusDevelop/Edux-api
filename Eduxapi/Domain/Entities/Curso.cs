using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Curso:Base
    {
        public string nomeCurso { get; set; }
        public string descricao { get; set; }
        public Guid Instituicaoid { get; set; }
        public Instituicao Instituicao { get; set; }
        public ICollection<Turma> turmas { get; set; }
    }
}
