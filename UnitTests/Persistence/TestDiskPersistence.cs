using NUnit.Framework;
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

    }
}
