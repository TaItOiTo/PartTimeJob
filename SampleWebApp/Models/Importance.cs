using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class Importance
    {

        /// <summary>
        /// 重要度のID
        /// </summary>
        public int ImportanceID { get;  set; }

        /// <summary>
        /// 表示する重要度
        /// </summary>
        public string DispImportance { get; set; }
    }
}