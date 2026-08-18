

namespace TwitterClone.Domain.Entities
{
    internal class Tweet : BaseEntity
    {
        
        private Guid _authorId; 
        private string _content;

        public Tweet() : base(Guid.NewGuid())
        {
            //// constrator chaining if base constractor has parameters
        }

        public Guid AuthorId { 
            get { return _authorId; }
        }
        public string Content { 
            get { return _content; } 
            set { _content = value; }
        }
    }
}
