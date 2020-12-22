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
    public class SegredoController : ControllerBase
    {
        Eduxcontext con = new Eduxcontext();
        [HttpGet]
        public List<Segredos> Get()
        {
            return con.segredos.ToList();
        }
        [HttpGet("{id}")]
        public List<SegredoUsuario> GetId(string id)
        {
            return con.segredousuario.Include(e=>e.segredo).Where(e => e.usuarioid == new Guid(id)).ToList();
        }
        [HttpPost]
        public void Post(SegredoUsuario seg)
        {
            con.segredousuario.Add(seg);
            con.SaveChanges();

        }
    }
}
