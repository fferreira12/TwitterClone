using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone
{
    public class Tweet
    {
        private string content;
        public readonly DateTime Time;

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                if(value.Length > 280)
                {
                    content = value.Substring(0, 280);
                }
                else
                {
                    content = value;
                }
            }
        }
        public User User { get; set; }

        public Tweet(User user, string content)
        {
            User = user;
            Content = content;
            Time = DateTime.Now;
        }

    }
}
