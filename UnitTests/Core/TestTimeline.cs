using NUnit.Framework;
using System;
using System.Collections.Generic;
using TwitterClone;

namespace Tests.Core
{
    public class TestTimeline
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateTimeline()
        {
            Timeline timeline = new Timeline();
        }

        [Test]
        public void TestAddTweet()
        {
            Timeline timeline = new Timeline();

            User user = new User("a", "b", "c");
            Tweet tweet = new Tweet(user, "This is a tweet");

            timeline.AddTweet(tweet);

            //Assert.AreEqual(1, timeline.GetLatestNTweets(1).Count);
        }

        [Test]
        public void TestAdd2Tweets()
        {
            Timeline timeline = new Timeline();

            User user1 = new User("ash", "boyd", "c@gmail.com");
            User user2 = new User("dale", "eve", "f@gmail.com");
            Tweet tweet1 = new Tweet(user1, "This is a tweet 1");
            Tweet tweet2 = new Tweet(user2, "This is a tweet 2");

            timeline.AddTweet(tweet1);
            timeline.AddTweet(tweet2);

            List<Tweet> tweets = timeline.GetLatestNTweets(2);

            //Since it is a stack, the last added tweet should be the first in the list.
            Assert.AreEqual("f@gmail.com", tweets[0].UserName);
            Assert.AreEqual("c@gmail.com", tweets[1].UserName);
        }

        [Test]
        public void TestGetTweets()
        {
            Timeline timeline = new Timeline();

            User user = new User("a", "b", "c");
            Tweet tweet = new Tweet(user, "This is a tweet");

            timeline.AddTweet(tweet);

            Assert.AreEqual(1, timeline.GetLatestNTweets(1).Count);
        }

    }

}