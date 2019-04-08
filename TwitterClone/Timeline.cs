using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone
{
    public class Timeline
    {

        Stack<Tweet> Tweets;

        public Timeline()
        {
            Tweets = new Stack<Tweet>();
        }

        public void AddTweet(Tweet tweet)
        {
            Tweets.Push(tweet);
        }

        public List<Tweet> GetLatestNTweets(int quantity)
        {
            if (Tweets.Count <= quantity)
            {
                return Tweets.ToList();
            }
            else
            {
                return Tweets.Take(quantity).ToList();
            }
        }

    }
}
