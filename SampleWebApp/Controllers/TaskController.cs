using SampleWebApp.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebApp.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            //StateのListを取得する
            var TaskList = TaskFactory.GetTaskList();

            //Viewにデータを渡す。
            return View("Index", TaskList);
        }

        [HttpPost]
        public ActionResult Post(string value1)
        {
            ViewData["PostData"] = value1 + "を受け取りました。";
            return View();
        }
    }
}