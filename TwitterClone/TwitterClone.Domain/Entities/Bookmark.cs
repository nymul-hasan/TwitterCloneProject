

namespace TwitterClone.Domain.Entities
{
    public class Bookmark :BaseEntity
    {
        
        private Guid _tweetId;
        private DateTime _bookmarkedAt;

        public Bookmark() : base(Guid.NewGuid())
        {
            //// constrator chaining if base constractor has parameters
        }


        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public DateTime BookmarkedAt
        {
            get { return _bookmarkedAt; }
        }
    }
}
