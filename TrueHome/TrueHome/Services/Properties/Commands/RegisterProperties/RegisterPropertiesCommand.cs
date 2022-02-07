using TrueHome.Context;
using TrueHome.Entities;
using TrueHome.Repositories;

namespace TrueHome.Services.Properties.Commands.RegisterProperties
{
    public class RegisterPropertiesCommand
    {
        private readonly TrueHomeContext _context;

        public RegisterPropertiesCommand(TrueHomeContext context)
        {
            this._context = context;
        }

        public void RegisterProperty(Property entity)
        {

            PropertyRepository repo = new(_context);

            repo.Add(entity);   
            repo.SaveChanges();

            return; 
        }
    }
}
