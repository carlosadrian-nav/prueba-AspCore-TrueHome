using TrueHome.Context;
using TrueHome.Entities;
using TrueHome.Interfaces;
using TrueHome.Repositories;

namespace TrueHome.Services.Properties.Commands.RegisterProperties
{
    public class RegisterPropertiesCommand
    {
        private readonly IPropertyRepository _repository;

        public RegisterPropertiesCommand(IPropertyRepository repository)
        {
            this._repository = repository;
        }

        public async Task<int> RegisterProperty(PropertyDto entity)
        {
            try
            {
                var propertyEntity = await Task.FromResult(new Property(
                                        entity.Title,
                                        entity.Address,
                                        entity.Description,
                                        null,
                                        entity.StatudId.ToString(),
                                        entity.StatudId));


                _repository.Add(propertyEntity);
                _repository.SaveChanges();

                return propertyEntity.Id;
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
            
        }
    }
}
