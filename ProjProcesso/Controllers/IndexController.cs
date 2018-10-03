using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjProcesso.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet]
        [Route("calculajuros")]
        public string Get(double valorinicial, int meses)
        {
            var juros = 0.01;
            var valor = valorinicial * Math.Pow((1 + juros), meses);
            return string.Format("{0:N}", valor) ;
        }


        [HttpGet]
        [Route("showmethecode")]
        public string ShowMe()
        {
            return "https://github.com/rogeriosoaresec/ProjProcesso";
        }
    }
}