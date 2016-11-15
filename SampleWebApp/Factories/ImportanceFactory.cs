using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Factories
{
    public class ImportanceFactory
    {
        public static List<Importance> GetimportanceList()
        {

            return new List<Importance>()
            {
                new Importance()
        {
            ImportanceID = 1,
                  DispImportance = "低"
                },
                new Importance()
        {
            ImportanceID = 2,
                  DispImportance = "中"
                },
                new Importance()
        {
            ImportanceID = 3,
                  DispImportance = "高"
                }
            };
        }
    }
}