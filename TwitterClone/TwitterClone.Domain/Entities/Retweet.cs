

namespace TwitterClone.Domain.Entities
{
    public class Retweet :BaseEntity
    {
        
        private Guid _tweetId;
        private DateTime _retweetedAt;

        public Retweet() : base(Guid.NewGuid())
        {
            //// constrator chaining if base constractor has parameters
        }



        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public DateTime RetweetedAt
        {
            get { return _retweetedAt; }
        }
    }
}
