using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class ProfessorInstituicao:Base
    {
        public Instituicao instituicao { get; set; }
        public Professor professor { get; set; }
    }
}
