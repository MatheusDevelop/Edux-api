using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Post:Base
    {
        public Guid usuarioid { get; set; }
        public Usuario usuario { get; set; }
        public string urlImg { get; set; }
        public string titulo { get; set; }
        public List<Curtida> curtidas { get; set; }
        [NotMapped]
        public string autor { get; set; }
        [NotMapped]
        public int numCurtida { get; set; }

    }
}
