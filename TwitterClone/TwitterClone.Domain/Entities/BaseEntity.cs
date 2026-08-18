

namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        
        public Guid Id { get; private set; } //proparty 
        public DateTime Createdat { get; private set; }
        public DateTime? Updatedat { get; private set; }
        public Guid CreateBy { get; private set; }
        public Guid? UpdateBy { get; private set; }

        public BaseEntity(Guid id)
        {
            Id = id;
            Createdat = DateTime.UtcNow;//  base consturctor with parametter
        }
    }
}
