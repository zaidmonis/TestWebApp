using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> getValues()
        {
            return new string[] {"a", "b"};
        }
    }
}