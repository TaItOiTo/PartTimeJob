using SampleWebApp.Factories;
using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Factories
{
    public class TaskFactory
    {
        public static List<Task> GetTaskList()
        {
            return new List<Task>()
            {            
            new Task()
            {
                TaskID = 1,
                Title = "たいとる１",
                UserInfo = new User()
                {
                    UserID = 1,
                    DispUser = "みよし",
                },
                StateInfo = new State()
                {
                    StateID = 1,
                    DispState = "DO",
                },
                ImportanceInfo = new Importance()
                {
                    ImportanceID = 1,
                    DispImportance = "低",
                },
                Explain = "説明１",
                Datetime = DateTime.Parse("2016年11月13日"),
                },
                new Task()
                {
                   TaskID = 2,
                Title = "たいとる2",
                UserInfo = new Models.User()
                {
                    UserID = 2,
                },
                StateInfo = new Models.State()
                {
                    StateID = 2,
                },
                ImportanceInfo = new Models.Importance()
                {
                    ImportanceID = 2,
                },
                Explain = "説明2",
                Datetime = DateTime.Parse("2016年11月13日"),
                },

                new Task()
                {
                    TaskID = 3,
                Title = "たいとる3",
                UserInfo = new Models.User()
                {
                    UserID = 3,
                },
                StateInfo = new Models.State()
                {
                    StateID = 3,
                },
                ImportanceInfo = new Models.Importance()
                {
                    ImportanceID = 3,
                },
                Explain = "説明3",
                Datetime = DateTime.Parse("2016年11月13日"),
                },
            };
    }

    }
}