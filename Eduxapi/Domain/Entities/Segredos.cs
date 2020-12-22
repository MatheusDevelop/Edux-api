using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Segredos:Base
    {
        
        public string nomeSegredo { get; set; }
        public string urlImg { get; set; }
        public List<SegredoUsuario> segredousuario { get; set; }
    }
}
