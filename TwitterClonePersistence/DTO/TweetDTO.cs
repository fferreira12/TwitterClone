using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone;

namespace TwitterClonePersistence
{
    [Serializable]
    public class TweetDTO
    {

        public string Content { get; set; }
        public DateTime Time { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public TweetDTO() { }

        public TweetDTO(Tweet t)
        {
            SetTweet(t);
        }

        public void SetTweet(Tweet tweet)
        {
            Content = tweet.Content;
            Time = tweet.Time;
            FirstName = tweet.User.FirstName;
            LastName = tweet.User.LastName;
            Username = tweet.User.Username;
        }

        public Tweet GetTweet()
        {
            return new Tweet(new User(FirstName, LastName, Username), Content);
        }

    }
}
