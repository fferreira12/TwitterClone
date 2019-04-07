using NUnit.Framework;
using System;
using TwitterClone;

namespace Tests
{
    public class TestTweet
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTweetCreation()
        {
            User user = new User("a", "b", "c");
            Tweet tweet = new Tweet(user, "tweet");

            Assert.Pass();
        }

        [Test]
        public void TestTweetContent()
        {
            User user = new User("a", "b", "c");
            Tweet tweet = new Tweet(user, "This is a tweet");

            Assert.AreEqual("This is a tweet", tweet.Content);
        }

        [Test]
        public void TestTweetContentLimit()
        {
            User user = new User("a", "b", "c");
            Tweet tweet = new Tweet(user, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec vehicula consequat augue, vel dignissim urna iaculis eu. Phasellus fermentum, eros nec eleifend ultrices, turpis est rhoncus ante, sed molestie elit mi eget velit. Aliquam ultrices felis eu arcu aliquet, volutpat sed.XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec vehicula consequat augue, vel dignissim urna iaculis eu. Phasellus fermentum, eros nec eleifend ultrices, turpis est rhoncus ante, sed molestie elit mi eget velit. Aliquam ultrices felis eu arcu aliquet, volutpat sed.", tweet.Content);
        }

        [Test]
        public void TestCreationTime()
        {
            User user = new User("a", "b", "c");
            Tweet tweet = new Tweet(user, "This is a tweet");

            DateTime now = DateTime.Now;

            //10 million ticks == 1 second
            Assert.IsTrue(tweet.Time.Ticks - now.Ticks <= 10000000 , tweet.Content);
        }
    }
}