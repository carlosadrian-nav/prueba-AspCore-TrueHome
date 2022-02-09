namespace TrueHome.Entities
{
    public class Survey : BaseEntity
    {
        public Activity Activity { get; set; }
        public string Answers { get; set; }

        public Survey() : base()
        {
        }

        public Survey(
            Activity activity,
            string answers,
            DateTime createdAt): base()
        {  
            this.Activity = activity;
            this.Answers = answers;     
            this.CreatedAt = createdAt;
        }
    }
}
