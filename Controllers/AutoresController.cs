using System;
using System.Collections.Generic;
using autores_api.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace autores_api.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            var hoy = DateTime.Now;
            return new List<Autor>(){
                new Autor(){
                    Id = 1,
                    Nombre = "David"
                },
                 new Autor(){
                    Id = 2,
                    Nombre = "Daniel"
                }
            };
            
        }
        
    }
}