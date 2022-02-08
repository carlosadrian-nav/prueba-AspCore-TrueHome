namespace TrueHome.Services.Activities.Commands.RescheduleActivities
{
    public class RescheduleDto
    {
        public int Id { get; set; }
        public DateTime Schedule { get; set; }

        public RescheduleDto(
            int id,
            DateTime schedule)
        {
            this.Id = id;
            this.Schedule = schedule;
        }

        public RescheduleDto()
        {

        }
    }
}
