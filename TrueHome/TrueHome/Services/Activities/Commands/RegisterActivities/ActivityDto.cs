namespace TrueHome.Services.Activities.Commands.RegisterActivities
{
    public class ActivityDto
    {
        public int PropertyId { get; set; }
        public DateTime Schedule { get; set; }
        public string Title { get; set; }

        public int StatusId { get; set; }

        public ActivityDto()
        {
        }

        public ActivityDto(
            int propertyId,
            DateTime schedule,
            string title,
            int statusId)
        {
            this.PropertyId = propertyId;
            this.Schedule = schedule;
            this.Title = title;
            this.StatusId = statusId;
        }
    }
}
