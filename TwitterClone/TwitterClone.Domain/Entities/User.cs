

namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstname;
        private string _lastname;
        private string _email;
        public User()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return _id; }
        }
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
