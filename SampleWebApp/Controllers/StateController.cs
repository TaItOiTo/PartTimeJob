using SampleWebApp.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebApp.Content
{
    public class StateController : Controller
    {
        // GET: State
        public ActionResult Index()//indexというアクション
        {
            //StateのListを取得する
            var StateList = StateFactory.GetStateList();

            //Viewにデータを渡す。
            return View("Index",StateList);
        }
    }
}