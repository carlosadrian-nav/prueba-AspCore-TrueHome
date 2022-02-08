using Microsoft.AspNetCore.Mvc;
using TrueHome.Context;
using TrueHome.Entities;
using TrueHome.Interfaces;
using TrueHome.Services.Properties.Commands.RegisterProperties;

namespace TrueHome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyRepository _repository;

        public PropertyController(IPropertyRepository repository)
        {
            _repository = repository; 
        }

        [HttpPost]
        public async Task<ActionResult<int>> Add(PropertyDto entity)
        {
            try
            {
                RegisterPropertiesCommand command = new RegisterPropertiesCommand(_repository);
                return Ok(await command.RegisterProperty(entity));
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }
            

        }
    }
}
