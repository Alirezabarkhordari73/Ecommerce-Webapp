namespace ECS.Domain.Common
{
    public class EntityBase
    {
        public long Id { get; set; }

        public DateTime InsertDate { get; set; }

        public EntityBase()
        {
            InsertDate = DateTime.Now;
        }
    }
}
