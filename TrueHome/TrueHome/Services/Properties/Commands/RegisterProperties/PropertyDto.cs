using TrueHome.Enums;

namespace TrueHome.Services.Properties.Commands.RegisterProperties
{
    public class PropertyDto
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime DisabledAt { get; set; }
        public StatusType StatudId { get; set; }
        public PropertyDto(
            string title,
            string address,
            string description,
            DateTime disabledAt,
            StatusType statudId
            )
        {
            this.Title = title;
            this.Address = address;
            this.Description = description;
            this.DisabledAt = disabledAt;            
            this.StatudId = statudId;
        }

        public PropertyDto()
        {
        }
    }
}
