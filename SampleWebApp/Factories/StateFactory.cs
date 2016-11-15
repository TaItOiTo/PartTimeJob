using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Factories
{
    public class StateFactory
    {
        public static List<State> GetStateList()
        {

            return new List<State>()
            {
                new State()
                {
                  StateID = 1,
                  DispState = "Do"
                },
                new State()
                {
                  StateID = 2,
                  DispState = "Doing"
                },
                new State()
                {
                　StateID = 3,
                  DispState = "Done"
                }
            };
        }
    }
}