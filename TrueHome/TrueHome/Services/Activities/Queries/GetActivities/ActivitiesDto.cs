namespace TrueHome.Services.Activities.Queries.GetActivities
{
    public class ActivitiesDto
    {
        public int Id { get; set; }
        public DateTime Schedule { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Condition { get; set; }
        public PropertyDto Property { get; set; }
        public string Survey { get; set; }

        public ActivitiesDto(
            int id,
            DateTime schedule,
            string title,
            DateTime createdat,
            string condition,
            PropertyDto property,
            string survey
            )
        {
            this.Id = id;
            this.Schedule = schedule;
            this.Title = title;
            this.CreatedAt = createdat;
            this.Condition = condition;
            this.Property = property;
            this.Survey = survey;
        }


    }
}
