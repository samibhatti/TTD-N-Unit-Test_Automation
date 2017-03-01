using ForgetTheMilk.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleVerification
{
    public class CreateTaskTests : AssertionHelper
    {
        [Test]
        public void DescriptionAndNoDueDate()
        {
            var input = "pickup the laundries";
            //Console.WriteLine("Scenario: " + input);

            var task = new Task(input, default(DateTime));

            var descriptionShouldBe = input;
            DateTime? dueDateShouldBe = null;
            //var success = descriptionShouldBe == task.Description && dueDateShouldBe == task.DueDate;
            //var failureMessage = "Description: " + task.Description + " should be " + descriptionShouldBe
            //                      + Environment.NewLine
            //                      + "Due Date: " + task.DueDate + "should be " + dueDateShouldBe;
            ////Program.PrintOutCome(success, failureMessage);
            //Assert.That(success, failureMessage);

//            Assert.AreEqual(descriptionShouldBe, task.Description);
            Expect(task.Description, Is.EqualTo(descriptionShouldBe));
            Assert.AreEqual(dueDateShouldBe, task.DueDate);

        }
        [Test]
        public void MayDueDateDoesWrapYear()
        {
            var input = "pickup the laundries may 5 - as of 2017-05-31";
            var today = new DateTime(2017, 5, 31);
            var task = new Task(input, today);

            var dueDateShouldBe = new DateTime(2018, 5, 5);

            Expect(task.DueDate, Is.EqualTo(dueDateShouldBe));
        }

        [Test]
        public  void MayDueDateDoesNotWrapYear()
        {
            var input = "pickup the laundries may 5 - as of 2017-05-04";
            var today = new DateTime(2017, 5, 4);

            var task = new Task(input, today);

            var dueDateShouldBe = new DateTime(2017, 5, 5);

            // var success = dueDateShouldBe == task.DueDate;
            // var failureMessage = "Due Date: " + task.DueDate + "should be " + dueDateShouldBe;

            Expect(task.DueDate, Is.EqualTo(dueDateShouldBe));
        }

        [Test]
        [TestCase("Groceries apr 5", 4)]
        [TestCase("Groceries may 5", 5)]
        public void AprilDueDate(string input, int expectedMonth)
        {
//            var input = "Groceries apr 5";
            //var today = new DateTime(2017, 5, 31);

            var task = new Task(input, default(DateTime));

            //var dueDateShouldBe = new DateTime(4);

            // var success = dueDateShouldBe == task.DueDate;
            // var failureMessage = "Due Date: " + task.DueDate + "should be " + dueDateShouldBe;

            Expect(task.DueDate, Is.Not.Null);
            Expect(task.DueDate.Value.Month, Is.EqualTo(expectedMonth));
        }

        [Test]

        public void TwoDigitDay_ParseBothDigits()
        {
            var input = "Groceries apr 10";

            var task = new Task(input, default(DateTime));

            Expect(task.DueDate.Value.Day, Is.EqualTo(10));
        }

        [Test]
        public void DayGreaterThanMonthMaxDay()
        {
            var input = "Groceries apr 40";

            var task = new Task(input, default(DateTime));

            Expect(task.DueDate.Value.Day, Is.EqualTo(1));
        }
        [Test]
        public void AddFeb29TaskInMarchOfYearBeforeLeapYear_ParsesDueDate()
        {
            var input = "Groceries feb 29";
            var today = new DateTime(2017,3,1);

            var task = new Task(input, today);

            Expect(task.DueDate.Value, Is.EqualTo(new DateTime(2018,2,1)));
        }
    }
}
