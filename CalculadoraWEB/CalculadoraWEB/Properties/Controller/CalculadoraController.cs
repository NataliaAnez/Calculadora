using Microsoft.AspNetCore.Mvc;

namespace CalculadoraWEB.Properties.Controller
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet]
        [Route("Suma")]
        public int SumaGet(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpPost]
        [Route("Suma")]
        public int SumaPost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 + num2;
        }

        [HttpGet]
        [Route("Resta")]
        public int RestaGet(int num1, int num2)
        {
            return num1 - num2;
        }
        [HttpPost]
        [Route("Resta")]
        public int RestaPost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 - num2;
        }

       


    }
}

