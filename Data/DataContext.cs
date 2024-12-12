using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using MurilloApi.Models;

namespace MurilloApi.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
       {
           
       }

       public DbSet<Clima> TB_CLIMA {get; set;}

       protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Clima>().ToTable("TB_CLIMA");
            modelBuilder.Entity<Clima>().HasData
            (
            new Clima() {id = 1, TemperaturaMax = 38.7, TemperaturaMin = 21, Unidades = Unidades.Celsius, Umidade ="25%", Milimetros = 00,  Data = new DateTime (2020,01,25),  },
            new Clima() {id = 2, TemperaturaMax = -5.5, TemperaturaMin = -21.0, Unidades = Unidades.Fahrenheint,Umidade = "40%", Milimetros = 5,  Data = new DateTime (2022,11,20),  },
            new Clima() {id = 4, TemperaturaMax = 25.1, TemperaturaMin = 15, Unidades = Unidades.Celsius,Umidade = "80%", Milimetros = 12,  Data = new DateTime(2018,08,21), },
            new Clima() {id = 5, TemperaturaMax = 32.1, TemperaturaMin = 15, Unidades = Unidades.Celsius, Umidade = "90%", Milimetros = 50,  Data = new DateTime(2019,09,14),  },
            new Clima() {id = 6, TemperaturaMax = -12, TemperaturaMin = -25.9, Unidades = Unidades.Fahrenheint,Umidade = "25%", Milimetros = 00,  Data = new DateTime(2020, 01, 21), }           
            );
        }

         protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder){
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
         }


        

       
    }

    
 }
 
 