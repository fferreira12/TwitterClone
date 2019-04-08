using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TwitterClone;

namespace TwitterConsoleInterface
{
    class Program
    {
        static Timeline timeline = new Timeline();

        static void Main(string[] args)
        {
            PrintHeader();
            string name = GetName();
            User user = CreateUser(name);
            int option = -1;
            do
            {
                option = GetOption();
                switch (option)
                {
                    case 1:
                        MakeTweet(user);
                        break;
                    case 2:
                        SeeTweets();
                        break;
                    default:
                        break;
                }
            } while (option != 0);
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("Welcome to Twitter Clone console app");
        }

        static string GetName()
        {
            Console.WriteLine("Type your name: ");
            return Console.ReadLine();
        }

        static User CreateUser(string name)
        {
            return new User(name, "", name);
        }

        static int GetOption()
        {
            int option = -1;
            do
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("1: Make a Tweet");
                Console.WriteLine("2: See Timeline");
                Console.WriteLine("0: Exit");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Type a valid option");
                }
            } while (option != 1 && option != 2 && option != 0);
            return option;
        }

        static void MakeTweet(User user)
        {
            Console.WriteLine("Make Tweet Selected");
            Console.WriteLine("Type Tweet Contents (Max 280 chars)");
            string text = Console.ReadLine();
            Tweet t = new Tweet(user, text);
            timeline.AddTweet(t);
        }

        static void SeeTweets()
        {
            Console.WriteLine("See Timeline Selected");
            Console.WriteLine("----------");
            foreach (Tweet t in timeline.GetLatestNTweets(10))
            {
                Console.WriteLine($"{t.User.Username} ({t.Time.ToShortTimeString()}): {t.Content}");
                Console.WriteLine("----------");
            }
        }

        static void PrintFooter()
        {
            Console.WriteLine("Thanks for using Twitter Clone Console app");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


    }
}
