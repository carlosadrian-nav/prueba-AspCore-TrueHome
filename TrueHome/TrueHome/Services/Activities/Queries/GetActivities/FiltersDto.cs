namespace TrueHome.Services.Activities.Queries.GetActivities
{
    public class FiltersDto
    {
        public DateTime? StartSchedule { get; set; } 
        public DateTime? EndSchedule { get; set; } 
        public int? Status { get; set; }

        public FiltersDto()
        {
        }

        public FiltersDto(
            DateTime? startSchedule,
            DateTime? endSchedule,
            int? status)
        {
            this.StartSchedule = startSchedule;
            this.EndSchedule = endSchedule; 
            this.Status = status;
        }

    }
}
