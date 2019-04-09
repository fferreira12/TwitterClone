using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone;

namespace TwitterClonePersistence
{
    [Serializable]
    public class UserDTO
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public List<TweetDTO> Tweets;

        public UserDTO() { }

        public void SetUser(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Tweets = user.Tweets.Select(t => new TweetDTO(t)).ToList();
        }

        public User GetUser()
        {
            User u =  new User(FirstName, LastName, Username);

            foreach (TweetDTO tdto in Tweets)
            {
                u.Tweets.Push(tdto.GetTweet());
            }

            return u;
        }

    }
}
