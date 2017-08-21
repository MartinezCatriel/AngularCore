using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularCore.Web.Controllers
{
    [Route("/api/[controller]")]
    public class ValuesController : Controller
    {
        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>() { "Hello", "world" };
        }
    }
}