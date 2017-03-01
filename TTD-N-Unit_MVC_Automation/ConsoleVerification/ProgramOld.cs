using System.Text;
using System.Threading.Tasks;

namespace ConsoleVerification
{
    using System;
    using ForgetTheMilk.Controllers;

    internal class Program
    {
        private static void Main(string[] args)
        {
           /* while (true)
            {

                //TestDescriptionAndNoDueDate();
                //TestMayDueDateDoesWrapYear();
                //TestMayDueDateDoesNotWrapYear();

                Console.ReadLine();
            }
        }

        private static void TestMayDueDateDoesNotWrapYear()
        {
            var input = "pickup the laundries may 5 - as of 2017-05-04";
            Console.WriteLine("Scenario: " + input);
            var today = new DateTime(2017, 5, 4);

            var task = new Task(input, today);

            var dueDateShouldBe = new DateTime(2017, 5, 5);
            var success = dueDateShouldBe == task.DueDate;
            var failureMessage = "Due Date: " + task.DueDate + "should be " + dueDateShouldBe;
            PrintOutCome(success, failureMessage);
        }

        private static void TestMayDueDateDoesWrapYear()
        {
            var input = "pickup the laundries may 5 - as of 2017-05-31";
            Console.WriteLine("Scenario: " + input);
            var today = new DateTime(2017, 2, 23);
            var task = new Task(input, today);

            var dueDateShouldBe = new DateTime(2017, 2, 5);
            var success = dueDateShouldBe == task.DueDate;
            var failureMessage = "Due Date: " + task.DueDate + "should be " + dueDateShouldBe;
            PrintOutCome(success, failureMessage);
        }

        //private static void TestDescriptionAndNoDueDate()
        //{
        //    var input = "pickup the laundries";
        //    Console.WriteLine("Scenario: " + input);

        //    var task = new Task(input, default(DateTime));

        //    var descriptionShouldBe = input;
        //    DateTime? dueDateShouldBe = null;
        //    var success = descriptionShouldBe == task.Description && dueDateShouldBe == task.DueDate;
        //    var failureMessage = "Description: " + task.Description + " should be " + descriptionShouldBe
        //                          + Environment.NewLine
        //                          + "Due Date: " + task.DueDate + "should be " + dueDateShouldBe;
        //    PrintOutCome(success, failureMessage);

            
        //}

        public static void PrintOutCome(bool success, string failureMessage)
        {
            if (success)
            {
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.WriteLine("ERROR: ");
                Console.WriteLine(failureMessage);
            }
            Console.WriteLine();
        }

    }*/
}
