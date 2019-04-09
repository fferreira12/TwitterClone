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
            UserDTO udto = new UserDTO();
            udto.SetUser(user);
            List<UserDTO> users = new List<UserDTO>
            {
                udto
            };

            XmlSerializer serializer = new XmlSerializer(typeof(List<UserDTO>));
            TextWriter writer = new StreamWriter(USERS_FILENAME);
            serializer.Serialize(writer, users);
            writer.Close();
        }

        public ICollection<User> GetUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<UserDTO>));
            FileStream fs = new FileStream(USERS_FILENAME, FileMode.Open);

            List<UserDTO> users;
            users = (List<UserDTO>)serializer.Deserialize(fs);
            return users.Select(udto => udto.GetUser()).ToList();
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
