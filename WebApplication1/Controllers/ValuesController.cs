using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{id}")]
        public IEnumerable<string> Get()
    {
        return new string[]
                { "Hello LTTS!",
                    "Hello Galaxy!",
                    "Hello Universe!"
                };
    }

   [HttpGet]
    public ActionResult Get([FromQuery]int count)
    {
            string[] recep = { "laddu", "kalakand", "kaja" };
            if(!recep.Any())
            {
                return NotFound();
            }
            return Ok(recep.Take(count));
       
    }

    [HttpPost("{id}")]
    public string Post(int id)
    {
        return "Hello World!";
    }


    [HttpPut("{id}")]
    public string Put(int id)
    {
        return "Hello Galaxy!";
    }


    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return "Hello Universe!";
    }
    }
}
