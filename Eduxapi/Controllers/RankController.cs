using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduxapi.Domain.Entities;
using Eduxapi.Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eduxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankController : ControllerBase
    {
        Eduxcontext con = new Eduxcontext();

        [HttpGet]
        public List<Rank> Get()
        {
            return con.Rank.Include(e=>e.aluno).OrderByDescending(e => e.pontos).ToList();
        }
    }
}
