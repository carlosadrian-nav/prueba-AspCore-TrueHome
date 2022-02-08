using Microsoft.EntityFrameworkCore;
using TrueHome.Entities;
using TrueHome.Enums;
using TrueHome.Interfaces;

namespace TrueHome.Services.Activities.Queries.GetActivities
{
    public class GetActivitiesQuery
    {
        private readonly IActivityRepository _repository;
        public GetActivitiesQuery(
            IActivityRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<ActivitiesDto>> GetActivities(FiltersDto filters)
        {
            //To do - Utilizar autoMapper.

            var result = new List<ActivitiesDto>();
            var data =  _repository
                                .GetAll();
            //Si no se obtiene filtros se debera cumplir la siguiente condicion
            //(fechaActual - 3 dias) <= schedule <= (fechaActual + 2 semanas)
            if (filters.Status == null && filters.EndSchedule == null && filters.StartSchedule == null)
            {
                var StarDate = DateTime.UtcNow.AddDays(-3);
                var endDate = DateTime.UtcNow.AddDays(14);

                await data.Where(w => w.Schedule >= StarDate && w.Schedule <= endDate).ToListAsync();
                foreach (var item in data)
                {
                    var value = GenerateClass(item);
                    result.Add(value);
                }                
            }
            else {
                
                if (filters.Status != null)
                {
                    data = data.Where(w => (int)w.StatudId == filters.Status);
                }
                if (filters.EndSchedule != null && filters.StartSchedule != null)
                {
                    data = data.Where(w => w.Schedule >= filters.StartSchedule && w.Schedule <= filters.EndSchedule);
                }

                await data.ToListAsync();
                foreach (var item in data)
                {
                    var value = GenerateClass(item);

                    result.Add(value);
                }
            }
            return result;
        }

        
        private static ActivitiesDto GenerateClass(Activity entity)
        { 
            return new ActivitiesDto(
                                entity.Id,
                                entity.Schedule,
                                entity.Title,
                                entity.CreatedAt,
                                ValidCondition((int)entity.StatudId, entity.Schedule).ToString(),
                                new PropertyDto(
                                    entity.Property.Id,
                                    entity.Property.Title,
                                    entity.Property.Address),
                                "");
        }

        private static ConditionTypes ValidCondition(int statusId, DateTime schedule)
        {
            if (statusId == (int)StatusType.Done)
            {
                return ConditionTypes.Finalizada;
            }
            if (statusId == (int)StatusType.Active && schedule.Date <= DateTime.Now.Date)
            {
                return ConditionTypes.Atrasada;
            }
            
            return ConditionTypes.Pendiente;
            
        }
    }
}
