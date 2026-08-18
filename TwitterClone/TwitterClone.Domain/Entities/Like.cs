

namespace TwitterClone.Domain.Entities
{
    internal class Like :BaseEntity
    {
      
        private Guid _tweetId;
        private DateTime _likedAt;
        
        
        public Guid TweetId { 
            get { return _tweetId; }
        }
        public DateTime LikedAt {
            get { return _likedAt; }
        }
    }
}
