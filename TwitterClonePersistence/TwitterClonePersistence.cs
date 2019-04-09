using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TwitterClone;

namespace TwitterClonePersistence
{
    public class TwitterCloneDiskPersistence
    {

        public const string USERS_FILENAME = "users.xml";
        public const string TWEETS_FILENAME = "tweets.xml";

        public void SaveUser(User user)
        {
            List<User> users = new List<User>
            {
                user
            };

            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            TextWriter writer = new StreamWriter(USERS_FILENAME);
            serializer.Serialize(writer, users);
            writer.Close();
        }

        public ICollection<User> GetUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ICollection<User>));
            FileStream fs = new FileStream(USERS_FILENAME, FileMode.Open);

            ICollection<User> users;
            users = (ICollection<User>)serializer.Deserialize(fs);
            return users;
        }

        public void SaveTweet(Tweet tweet)
        {

        }

        public ICollection<Tweet> GetTweets()
        {
            return null;

        }

    }
}
