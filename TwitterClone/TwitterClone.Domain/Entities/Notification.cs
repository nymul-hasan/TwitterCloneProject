

namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _userId;
        private string _content;
        private DateTime _createdAt;

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
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
