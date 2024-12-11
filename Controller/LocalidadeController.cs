using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MurilloApi.Models;

namespace MurilloApi.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class LocalidadeController : ControllerBase
    {
        private static List<Localidade> localidades = new List<Localidade>()
        {
            new Localidade() {Id = 1, Cidade = "Ribeirão Preto", Estado = "São Paulo", Pais = "Brasil"},
            new Localidade() {Id = 1, Cidade = "Baltimore", Estado = "Maryland", Pais = "EUA"},
            new Localidade() {Id = 1, Cidade = "Belem", Estado = "Para", Pais = "Brasil"},
            new Localidade() {Id = 1, Cidade = "Denver", Estado = "Colorado", Pais = "EUA"},
        };

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            return Ok(localidades[0]);
        }

         [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(localidades);
        }



    }
}