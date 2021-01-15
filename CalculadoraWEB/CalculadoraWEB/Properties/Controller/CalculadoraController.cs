using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraWEB.Properties.Controller
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpPost]
        public int Sumar([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 + num2;
        }

    }
}

