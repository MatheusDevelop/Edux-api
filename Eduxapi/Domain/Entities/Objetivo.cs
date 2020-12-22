using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Objetivo:Base
    {
        public Guid turmaid { get; set; }
        public Turma turma { get; set; }
        public string descricao { get; set; }
    }
}
