using Microsoft.AspNetCore.Mvc;
using TrueHome.Interfaces;
using TrueHome.Services.Activities.Commands.CancelActivities;
using TrueHome.Services.Activities.Commands.RegisterActivities;
using TrueHome.Services.Activities.Commands.RescheduleActivities;
using TrueHome.Services.Activities.Queries.GetActivities;

namespace TrueHome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityRepository _repository;
        private readonly IPropertyRepository _propertyRepository;

        public ActivityController(
            IActivityRepository repository,
            IPropertyRepository propertyRepository
            )
        {
            _repository = repository;
            _propertyRepository = propertyRepository;
        }
        /// <summary>
        /// Buscar todas las actividades
        /// </summary>
        /// <param name="filters.StartSchedule">Fecha incial de busqueda</param>
        /// <param name="filters.EndSchedule">Fecha Final de busqueda</param>
        /// <param name="filters.Status">Filtro status de las activivdades</param>
        /// <returns></returns>
        [HttpPost("Search")]
        public async Task<ActionResult> GetAll(FiltersDto filters)
        {
            try
            {
                GetActivitiesQuery query = new(_repository);

                return Ok(await query.GetActivities(filters));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        ///// <summary>
        ///// Metodo para crear una actividad
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Add(ActivityDto entity)
        {
            try
            {
                RegisterActivitiesCommand command = new(_repository, _propertyRepository);

                return Ok(await command.RegisterActivity(entity));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        ///// <summary>
        ///// Metodo para editar una actividad
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, RescheduleDto entity)
        {
            if (id != entity.Id)
            {
                return BadRequest(entity);
            }

            try
            {
                RescheduleActivitiesCommand command = new(_repository);

                return Ok(await command.ReScheduleAcivity(entity));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        ///// <summary>
        ///// Metodo para cancelar actividades por Id
        ///// </summary>
        ///// <param name="id">Id de la actividad</param>
        ///// <returns></returns>
        [HttpPut("{id}/Cancel")]
        public async Task<ActionResult> Cancel(int id)
        {
            try
            {
                CancelActivitiesCommand command = new CancelActivitiesCommand(_repository);

                return Ok(await command.CancelActivity(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
