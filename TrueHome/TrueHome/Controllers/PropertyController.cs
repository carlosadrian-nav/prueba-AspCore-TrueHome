using Microsoft.AspNetCore.Mvc;
using TrueHome.Context;
using TrueHome.Entities;
using TrueHome.Services.Properties.Commands.RegisterProperties;

namespace TrueHome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : ControllerBase
    {
        private readonly TrueHomeContext _context;

        private readonly ILogger<WeatherForecastController> _logger;
        public PropertyController(TrueHomeContext context, ILogger<WeatherForecastController> logger)
        {
            _context = context; 
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Add(Property entity)
        {
            RegisterPropertiesCommand command = new RegisterPropertiesCommand(_context);
            command.RegisterProperty(entity);

            return Ok(command);

        }
    }
}
