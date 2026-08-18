

namespace TwitterClone.Domain.Entities
{
    public class Notification :BaseEntity
    {
        
        
        private string _content;


        public Notification() : base(Guid.NewGuid())
        {
            //// constrator chaining if base constractor has parameters
        }





        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
    }
}
