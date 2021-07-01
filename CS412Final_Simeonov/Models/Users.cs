using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Models
{
    public class Users
    {
        private static List<User> listOfAllUsers;
        //User batman = new User() { 
        //    FirstName = "Bruce",
        //    LastName = "Wayne",
        //    Email = "BruceWayne@gmail.com",
        //    Username = "Batman",
        //    Password = "IamBatman"
        //};

        //User ironMan = new User()
        //{
        //    FirstName = "Tony",
        //    LastName = "Stark",
        //    Email = "TonyStark@gmail.com",
        //    Username = "IronMan",
        //    Password = "TheBestAvenger"
        //};

        //User hulk = new User()
        //{
        //    FirstName = "Bruce",
        //    LastName = "Banner",
        //    Email = "HulkSmash@gmail.com",
        //    Username = "Hulk",
        //    Password = "NoDoors"
        //};

        //User thor = new User()
        //{
        //    FirstName = "Thor",
        //    LastName = "OdinSon",
        //    Email = "ThorOdinSon@gmail.com",
        //    Username = "Thor",
        //    Password = "TheStrongestAvenger"
        //};

        //User cptAmerica = new User()
        //{
        //    FirstName = "Steve",
        //    LastName = "Rogers",
        //    Email = "SteveRogers@gmail.com",
        //    Username = "CaptainAmerica",
        //    Password = "ICanDoThisAllDay"
        //};

        //User loki = new User()
        //{
        //    FirstName = "Loki",
        //    LastName = "OdinSon",
        //    Email = "LokiOdinSon@gmail.com",
        //    Username = "Loki",
        //    Password = "IWillNeverDoItAgain"
        //};

        public Users() { 
            listOfAllUsers = new List<User>();
            User batman = new User()
            {
                FirstName = "Bruce",
                LastName = "Wayne",
                Email = "BruceWayne@gmail.com",
                Username = "Batman",
                Password = "IamBatman"
            };
            User ironMan = new User()
            {
                FirstName = "Tony",
                LastName = "Stark",
                Email = "TonyStark@gmail.com",
                Username = "IronMan",
                Password = "TheBestAvenger"
            };
            User hulk = new User()
            {
                FirstName = "Bruce",
                LastName = "Banner",
                Email = "HulkSmash@gmail.com",
                Username = "Hulk",
                Password = "NoDoors"
            };
            User thor = new User()
            {
                FirstName = "Thor",
                LastName = "OdinSon",
                Email = "ThorOdinSon@gmail.com",
                Username = "Thor",
                Password = "TheStrongestAvenger"
            };
            User cptAmerica = new User()
            {
                FirstName = "Steve",
                LastName = "Rogers",
                Email = "SteveRogers@gmail.com",
                Username = "CaptainAmerica",
                Password = "ICanDoThisAllDay"
            };
            User loki = new User()
            {
                FirstName = "Loki",
                LastName = "OdinSon",
                Email = "LokiOdinSon@gmail.com",
                Username = "Loki",
                Password = "IWillNeverDoItAgain"
            };
            listOfAllUsers.Add(loki);
            listOfAllUsers.Add(cptAmerica);
            listOfAllUsers.Add(thor);
            listOfAllUsers.Add(hulk);
            listOfAllUsers.Add(ironMan);
            listOfAllUsers.Add(batman);
        }
        public static List<User> getAllUsers() {
            return listOfAllUsers;
        }
    }
}