using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Usuario:Base
    {
        public string Nickname { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public bool isAluno { get; set; }
        public bool isInstituicao { get; set; }
        public bool isProfessor { get; set; }
        public List<Post> posts { get; set; }
        public List<SegredoUsuario> segredos { get; set; }
        public Usuario()
        {
            isAluno = false;
            isInstituicao = false;
            isProfessor = false;
        }
    }
}
