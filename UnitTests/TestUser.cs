using NUnit.Framework;
using TwitterClone;

namespace Tests
{
    class TestUser
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestUserCreation()
        {
            User user = new User("a", "b", "c");
        }

        [Test]
        public void TestMakeTweet()
        {
            User user = new User("a", "b", "c");
            user.MakeTweet("First");

            Assert.AreEqual("First", user.Tweets[0].Content);
        }
    }
}
