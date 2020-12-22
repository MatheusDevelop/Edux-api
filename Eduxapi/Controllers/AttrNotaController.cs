using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduxapi.Domain.Entities;
using Eduxapi.Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eduxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttrNotaController : ControllerBase
    {
        Eduxcontext con = new Eduxcontext();
        [HttpPost]
        public ActionResult post(ObjetivoConcluido obj)
        {
            con.objetivosConcluido.Add(obj);
            con.SaveChanges();
            return Ok();
        }
    }
}
