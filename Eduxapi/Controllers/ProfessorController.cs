using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduxapi.Domain.Entities;
using Eduxapi.Infra.Repositories;
using Eduxapi.Infra.Repositories.Integration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eduxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        ProfessorRepository rep = new ProfessorRepository();

        [HttpPost]
        public ActionResult<List<ProfessorTurma>> Get(Professor professor)
        {
            return rep.SearchTurmas(professor.id);
        }
        
    }
}
