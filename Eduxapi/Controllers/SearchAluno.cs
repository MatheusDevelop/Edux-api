﻿using System;
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
    public class SearchAluno : ControllerBase
    {
        InstituicaoRepository rep = new InstituicaoRepository();
        [HttpGet("{name}")]
        public List<Aluno> Get(string name)
        {
           return rep.SearchAllAlunos(name);
        }
    }
}
