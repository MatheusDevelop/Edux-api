using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduxapi.Domain.Entities;
using Eduxapi.Infra.Repositories.Integration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eduxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorTurmaController : ControllerBase
    {
        InstituicaoRepository rep = new InstituicaoRepository();
        [HttpPost]
        public ActionResult Post(ProfessorTurma pt)
        {
            rep.AddTurma(pt);
            return Ok();
        }
    }
}
