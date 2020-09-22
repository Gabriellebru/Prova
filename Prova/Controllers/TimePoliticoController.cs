﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Prova.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimePoliticoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listar Politicos");
        }
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok("Criado com sucesso");
        }

    }
}