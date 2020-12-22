using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Curtida:Base
    {
        public Guid usuarioid { get; set; }
        public Usuario usuario { get; set; }
        public Guid postid { get; set; }
        public Post post { get; set; }

    }
}
