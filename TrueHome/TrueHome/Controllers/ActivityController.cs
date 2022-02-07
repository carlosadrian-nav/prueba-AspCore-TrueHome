using Microsoft.AspNetCore.Mvc;
using TrueHome.Entities;

namespace TrueHome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        public ActivityController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IEnumerable<Activity> Get()
        {
            return new List<Activity>();    
        }
    }
}
