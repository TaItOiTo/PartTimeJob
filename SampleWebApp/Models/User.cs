using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class User
    {

        /// <summary>
        /// ユーザ固有のID
        /// </summary>
        public int UserID { get; set; }

      　///　<summary>
        ///　ユーザの表示名
        ///　</summary> 
        public string DispUser { get; set; }
    }
}