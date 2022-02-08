using TrueHome.Enums;

namespace TrueHome.Entities
{
    public partial class Property : BaseEntity
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; } 
        public DateTime? DisabledAt { get; set; }
        public string Status { get; set; }
        public StatusType StatudId { get; set; }
        public Property(
            string title,
            string address,
            string description,
            DateTime? disabledAt,
            string status,
            StatusType statudId
            ) : base()
        {
            this.Title = title;
            this.Address = address;    
            this.Description = description; 
            this.DisabledAt = disabledAt;   
            this.Status = status;   
            this.StatudId = statudId;
        }

        public Property()
        {
        }
        
    }
}
