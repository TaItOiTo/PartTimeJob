using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Factories
{
    public class UserFactory
    {

        public static List<User> GetUserList()
        {

            return new List<User>()
            {
                new User()
        {
            UserID = 1,
                  DispUser = "ミヨシ"
                },
                new User()
        {
            UserID = 2,
                  DispUser = "ナガイ"
                },
                new User()
        {
            UserID = 3,
                  DispUser = "ナナウミ"
                }
            };
        }
    }
}