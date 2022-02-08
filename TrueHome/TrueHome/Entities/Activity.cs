using TrueHome.Enums;

namespace TrueHome.Entities
{
    public class Activity : BaseEntity
    {
        public DateTime Schedule { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public StatusType StatudId { get; set; }
        public Property Property { get;  }  

        public Activity(
            DateTime schedule,
            string title,
            string status,
            StatusType statudId,
            Property property
            ) 
        {
            this.Schedule = schedule;  
            this.Title = title; 
            this.Status = status;   
            this.StatudId = statudId;
            this.Property = property;

        }

        public Activity() 
        {
        }

    }
}
