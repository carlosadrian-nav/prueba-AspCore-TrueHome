using TrueHome.Enums;

namespace TrueHome.Entities
{
    public class Activity : BaseEntity
    {
        public DateTime Schedule { get; set; }
        public string Title { get; set; }
        public int PropertyId { get; set; }
        public string Status { get; set; }
        public StatusType StatudId { get; set; }
        public Property Property { get; set; }  

        public Activity(
            DateTime schedule,
            string title,
            int propertyId,
            string status,
            StatusType statudId,
            Property property
            ) : base()
        {
            this.Schedule = schedule;  
            this.Title = title; 
            this.PropertyId = propertyId;   
            this.Status = status;   
            this.StatudId = statudId;
            this.Property = property;

        }

        public Activity() : base()
        {
        }

    }
}
