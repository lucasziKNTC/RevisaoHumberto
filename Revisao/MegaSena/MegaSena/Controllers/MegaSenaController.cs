using MegaSena.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaSena.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MegaSenaController : ControllerBase
    {


        [HttpGet]
        public ActionResult Ola()
        {

            return Ok("Ola");

        }


        [HttpPost("RegistrarJogo")]
        [ProducesResponseType(typeof(Numeros), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]



        public ActionResult RegistrarJogo(Numeros numeros)
        {
            

            if(numeros.Numero1 != numeros.Numero2 &&
               numeros.Numero1 != numeros.Numero3 &&
               numeros.Numero1 != numeros.Numero4 &&
               numeros.Numero1 != numeros.Numero5 &&
               numeros.Numero1 != numeros.Numero6 &&

               numeros.Numero2 != numeros.Numero3 &&
               numeros.Numero2 != numeros.Numero4 &&
               numeros.Numero2 != numeros.Numero5 &&
               numeros.Numero2 != numeros.Numero6 &&

               numeros.Numero3 != numeros.Numero4 &&
               numeros.Numero3 != numeros.Numero5 &&
               numeros.Numero3 != numeros.Numero6 &&

               numeros.Numero4 != numeros.Numero5 &&
               numeros.Numero4 != numeros.Numero6 &&

               numeros.Numero5 != numeros.Numero6 
     
              )

            {
                return Ok(numeros);
                    
            }


            return BadRequest("Numeros não podem repetir");


        }


        [HttpPost("RegistrarJogoAleatorio")]
        [ProducesResponseType(typeof(Numeros), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        public ActionResult RegistrarJogoAleatorio()
        {

            Random Aleatorio = new Random();
            string Resultado = "";
            
            for(int i=0; i<= 6 - 1; i++)
            {
                Resultado = Resultado + " - " + Aleatorio.Next(1 , 60);

                
            }
          
            return Ok("Jogo registrado, seu jogo sera:" + Resultado);
        }
        
       
    }
}
