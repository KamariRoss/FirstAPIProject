using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPIProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExplosionController : ControllerBase
    {

        [HttpGet("explode")]
        public string Hello(string s)
        {
            var answerString = "";
            foreach (var letter in s)
            {
                var number = int.Parse(letter.ToString());
                for (var i = 0; i < number; i++)
                {
                    answerString += letter;
                }
            }
            return answerString;
        }
    }
}



