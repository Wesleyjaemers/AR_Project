using ARShowcase.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARShowcase.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ModelController : ControllerBase
    {

        public IActionResult ModelList()
        {
            var model = new Model {Id = 1, Name = "TestModel" };
            return new ObjectResult(model);
        }

        public string ModelById()
        {
            return "A single model by id";
        }
    }
}
