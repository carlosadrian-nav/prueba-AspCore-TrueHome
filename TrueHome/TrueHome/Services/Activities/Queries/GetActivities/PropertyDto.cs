using AutoMapper;
using TrueHome.Entities;

namespace TrueHome.Services.Activities.Queries.GetActivities
{
    public class PropertyDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public PropertyDto()
        {
        }

        public PropertyDto(
            int id,
            string title,
            string address)
        {
            this.Id = id;
            this.Title = title;
            this.Address = address;
        }

    }
}
