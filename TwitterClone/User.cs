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

        public Stack<Tweet> Tweets;

        public User(string firstName, string lastName, string username)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Tweets = new Stack<Tweet>();
        }

        public Tweet MakeTweet(string content)
        {
            Tweet t = new Tweet(this, content);
            Tweets.Push(t);
            return t;
        }
    }
}
