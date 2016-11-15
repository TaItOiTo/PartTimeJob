using SampleWebApp.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebApp.Controllers
{
    public class ImportanceController : Controller
    {
        // GET: Importance
        public ActionResult Index()//indexというアクション
        {
            //StateのListを取得する
            var ImportanceList = ImportanceFactory.GetimportanceList();

            //Viewにデータを渡す。
            return View("Index", ImportanceList);
        }
    }
}