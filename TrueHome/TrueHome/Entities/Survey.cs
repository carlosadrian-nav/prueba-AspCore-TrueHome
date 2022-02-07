namespace TrueHome.Entities
{
    public class Survey : BaseEntity
    {
        public int ActivityId { get; set; } 
        public Activity Activity { get; set; }
        public string Answers { get; set; }

        public Survey() : base()
        {
        }

        public Survey(
            int activityId,
            string answers,
            DateTime createdAt): base()
        {
            this.ActivityId = activityId;   
            this.Answers = answers;     
            this.CreatedAt = createdAt;
        }
    }
}
