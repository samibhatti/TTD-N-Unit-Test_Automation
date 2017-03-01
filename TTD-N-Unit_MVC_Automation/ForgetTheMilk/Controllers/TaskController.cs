using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ForgetTheMilk.Controllers
{
    public class TaskController : Controller
    {
        public static readonly List<Task> Tasks = new List<Task>();
         
        public ActionResult Index()
        {
            return View(Tasks);
        }

        [HttpPost]
        public ActionResult Add(string task)
        {
            /* Tasks.Add(task);
             Tasks.Add(new Task { Description = task });
             var taskItem = new Task { Description = task };
             var dueDatePattern = new Regex(@"may\s(\d)");
             var hasDueDate = dueDatePattern.IsMatch(task);
             if (hasDueDate)
             {
                 var dueDate = dueDatePattern.Match(task);
                 var day = Convert.ToInt32(dueDate.Groups[1].Value);
                 taskItem.DueDate = new DateTime(DateTime.Today.Year, 5, day);
             }*/
            var taskItem = new Task(task, DateTime.Today);
            Tasks.Add(taskItem);
            return RedirectToAction("Index");
        }


        /*public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}