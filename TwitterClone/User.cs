using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone
{
    public class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public List<Tweet> Tweets;

        public User(string firstName, string lastName, string username)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Tweets = new List<Tweet>();
        }

        public Tweet MakeTweet(string content)
        {
            Tweet t = new Tweet(this, content);
            Tweets.Add(t);
            return t;
        }
    }
}
