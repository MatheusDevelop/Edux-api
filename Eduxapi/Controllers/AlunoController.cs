using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduxapi.Domain.Entities;
using Eduxapi.Domain.Services;
using Eduxapi.Infra.Repositories.Integration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eduxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        AlunoRepository rep = new AlunoRepository();
        RankAtt rank = new RankAtt();
        [HttpPost]
        public List<AlunoTurma> Get(Aluno aluno)
        {
            rank.RankAt(aluno.id);
            return rep.SearchTurmas(aluno.id);
        }
    }
}
