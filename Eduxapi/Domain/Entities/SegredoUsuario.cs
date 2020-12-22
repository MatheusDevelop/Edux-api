using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class SegredoUsuario:Base
    {
        public Guid segredoid { get; set; }
        public Segredos segredo { get; set; }
        public Guid usuarioid { get; set; }
        public Usuario usuario { get; set; }
    }
}
