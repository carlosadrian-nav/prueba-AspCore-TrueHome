namespace TrueHome.Entities
{
    public partial class BaseEntity
    {
        public  int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }  

        public BaseEntity()
        {
        }

        public BaseEntity(
            int id,
            DateTime createdAt,
            DateTime updateAt)
        {
            this.Id = id;
            this.CreatedAt = createdAt; 
            this.UpdateAt = updateAt;   
        }
    }
}
