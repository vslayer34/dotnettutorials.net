using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _04_ReturnValueFromTaskExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        // api/greetings/name
        [HttpGet("{name}")]
        public string GetGreetings(string name) => $"Hello {name}, Welcone to web API";
    }
}
