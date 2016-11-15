using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class State
    {

        /// <summary>
        /// ステータスID
        /// </summary>
        public int StateID { get;  set; }

        /// <summary>
        /// 表示するステータス
        /// </summary>
        public string DispState { get; set; }
    }
}