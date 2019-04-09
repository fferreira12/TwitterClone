using NUnit.Framework;
using System.Collections.Generic;
using TwitterClone;
using TwitterClonePersistence;


namespace Tests.Persistence
{
    class TestDiskPersistence
    {

        TwitterCloneDiskPersistence persistence = new TwitterCloneDiskPersistence();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestSaveUserWithNoTweets()
        {
            User u = new User("Fernando", "Ferreira", "fferreira");

            persistence.SaveUser(u);

        }

        [Test]
        public void TestSaveUserWithTweets()
        {
            User u = new User("Fernando", "Ferreira", "fferreira");

            u.MakeTweet("First Tweet");
            u.MakeTweet("Second Tweet");
            u.MakeTweet("Third Tweet");

            persistence.SaveUser(u);

        }

        [Test]
        public void TestSaveUserWithManyTweets()
        {
            User u = new User("Fernando", "Ferreira", "fferreira");

            for(int i = 0; i < 100; i++)
            {
                u.MakeTweet("Tweet" + i);
            }

            persistence.SaveUser(u);

        }

        [Test]
        public void TestGetUsers()
        {
            ICollection<User> users = persistence.GetUsers();
            Assert.IsNotNull(users);
        }

        [Test]
        public void TestGetUserWithTweets()
        {
            User u = new User("Fernando", "Ferreira", "fferreira");

            u.MakeTweet("First Tweet");
            u.MakeTweet("Second Tweet");
            u.MakeTweet("Third Tweet");

            persistence.SaveUser(u);

            ICollection<User> users = persistence.GetUsers();
            Assert.IsNotNull(users);
            Assert.AreEqual(3, (users as IList<User>)[0].Tweets.Count);
        }

    }
}
