using Microsoft.AspNetCore.Mvc;
using weatherbackend.Services;
using System.Web.Http.Cors;

namespace weather_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    
    WeatherService WS = new WeatherService();

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        WS.Main();

        return Ok(WS.root);
    }
}
