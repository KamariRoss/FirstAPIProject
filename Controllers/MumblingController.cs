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
    public class MumblingController : ControllerBase
    {

        [HttpGet("mumble")]
        public string Hello(string s)
        {
            s = s.ToLower();
            var timesToRepeatTheLetter = 1;
            var answerString = "";
            foreach (var letter in s)
            {
                for (var i = 0; i < timesToRepeatTheLetter; i++)
                {
                    if (i == 0)
                    {
                        answerString += letter.ToString().ToUpper();
                    }
                    else
                    {
                        answerString += letter;
                    }
                }
                answerString += "-";
                timesToRepeatTheLetter++;
            }

            return answerString.TrimEnd('-');
        }
    }
}


