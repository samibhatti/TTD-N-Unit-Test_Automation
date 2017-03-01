using ForgetTheMilk.Controllers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ForgetTheMilk.Controllers
{
    public class Task
    {
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }

        public Task(string task, DateTime today)
        {
            //var taskItem = new Task { Description = task };
            Description = task;
            var dueDatePattern = new Regex(@"(feb|mar|apr|may)\s(\d+)");
            var hasDueDate = dueDatePattern.IsMatch(task);
            if (hasDueDate)
            {
                var dueDate = dueDatePattern.Match(task);
                var monthInput = dueDate.Groups[1].Value;
                //var month = monthInput == "may" ? 5 : 4;
                //                var month = DateTime.ParseExact(monthInput, "MMM", CultureInfo.CurrentCulture).Month;
                var month = DateTime.ParseExact(monthInput, "MMM", CultureInfo.CreateSpecificCulture("en-US")).Month;
                var day = Convert.ToInt32(dueDate.Groups[2].Value);
                var year = today.Year;
                var shouldWrapYear = month < today.Month || (month == today.Month && day < today.Day);

                if (shouldWrapYear)
                {
                    year++;
                }

                if (day <= DateTime.DaysInMonth(today.Year, month))
                { 
                    DueDate = new DateTime(year, month, day);
                   // if (DueDate < today)
                    //{
                  //DueDate = DueDate.Value.AddYears(1);

                  //  }
                } else
                
                    DueDate = new DateTime(year, month, 1);
                    
                

            }
        }
    }
}