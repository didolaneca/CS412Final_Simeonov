using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Models
{
    [Serializable]
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public string TimeStamp { get; set; }

        public Address Address { get; set; }

        public User findUserByEmail(User user) {
            return users.Find(usr => usr.Email.Equals(user.Email));
        }

        List<User> users = new List<User>() {
            new User() {
            FirstName = "Bruce",
            LastName = "Wayne",
            Email = "BruceWayne@gmail.com",
            Username = "Batman",
            Password = "IamBatman"
        },

        new User()
        {
            FirstName = "Tony",
            LastName = "Stark",
            Email = "TonyStark@gmail.com",
            Username = "IronMan",
            Password = "TheBestAvenger"
        },

        new User()
        {
            FirstName = "Bruce",
            LastName = "Banner",
            Email = "HulkSmash@gmail.com",
            Username = "Hulk",
            Password = "NoDoors"
        },

        new User()
        {
            FirstName = "Thor",
            LastName = "OdinSon",
            Email = "ThorOdinSon@gmail.com",
            Username = "Thor",
            Password = "TheStrongestAvenger"
        },

        new User()
        {
            FirstName = "Steve",
            LastName = "Rogers",
            Email = "SteveRogers@gmail.com",
            Username = "CaptainAmerica",
            Password = "ICanDoThisAllDay"
        },

        new User()
        {
            FirstName = "Loki",
            LastName = "OdinSon",
            Email = "LokiOdinSon@gmail.com",
            Username = "Loki",
            Password = "IWillNeverDoItAgain"
        }
    };
    }
}