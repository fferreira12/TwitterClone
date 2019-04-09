using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone
{
    public class User
    {
        private Timeline timeline;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public Stack<Tweet> Tweets;

        public User(string firstName, string lastName, string username, Timeline timeline = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Tweets = new Stack<Tweet>();
            this.timeline = timeline;
        }

        public Tweet MakeTweet(string content)
        {
            Tweet t = new Tweet(this, content);
            if(timeline != null)
            {
                timeline.AddTweet(t);
            }
            Tweets.Push(t);
            return t;
        }
    }
}
