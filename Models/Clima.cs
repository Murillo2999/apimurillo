using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;
using MurilloApi.Models.Enum;

namespace MurilloApi.Models
{
    public class Clima
    {
        public int id { get; set; }
        public Localidade Localidade {get; set;}
        public double TemperaturaMin {get; set;}
        public double TemperaturaMax {get; set;}

        public string Umidade { get; set; }
        public int Milimetros { get; set; }

        public DateTime Data { get; set; }
        
        public TiposClima TiposClima { get; set; }

        public Unidades Unidades {get; set;}
    }
}