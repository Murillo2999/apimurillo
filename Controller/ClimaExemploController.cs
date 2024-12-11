using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MurilloApi.Models;
using MurilloApi.Models.Enum;

namespace MurilloApi.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ClimaExemploController : ControllerBase
    {
        private static List<Clima> climas = new List<Clima>()
        {
            new Clima() {id = 1, TemperaturaMax = 38.7, TemperaturaMin = 21, Unidades = Unidades.Celsius, Umidade ="25%", Milimetros = 00,  Data = new DateTime (2020,01,25), TiposClima=TiposClima.Claro },
            new Clima() {id = 2, TemperaturaMax = -5.5, TemperaturaMin = -21.0, Unidades = Unidades.Fahrenheint,Umidade = "40%", Milimetros = 5,  Data = new DateTime (2022,11,20), TiposClima=TiposClima.Neve },
            new Clima() {id = 4, TemperaturaMax = 25.1, TemperaturaMin = 15, Unidades = Unidades.Celsius,Umidade = "80%", Milimetros = 12,  Data = new DateTime(2018,08,21), TiposClima=TiposClima.Chuva },
            new Clima() {id = 5, TemperaturaMax = 32.1, TemperaturaMin = 15, Unidades = Unidades.Celsius, Umidade = "90%", Milimetros = 50,  Data = new DateTime(2019,09,14), TiposClima=TiposClima.TempestadeComRaios },
            new Clima() {id = 6, TemperaturaMax = -12, TemperaturaMin = -25.9, Unidades = Unidades.Fahrenheint,Umidade = "25%", Milimetros = 00,  Data = new DateTime(2020, 01, 21), TiposClima=TiposClima.SolComNuvens },
            
        };

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            return Ok(climas[0]);
        }

         [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(climas);
        }
    }
}