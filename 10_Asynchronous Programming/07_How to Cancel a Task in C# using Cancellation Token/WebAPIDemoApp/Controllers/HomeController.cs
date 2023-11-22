using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemoApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("name")]
    public async Task<string> GetGreetings(string name)
    {
        await Task.Delay(5000);
        return $"Hello {Char.ToUpper(name[0]) + name.Substring(1).ToLower()}, Welcome to the web API";
    }
}