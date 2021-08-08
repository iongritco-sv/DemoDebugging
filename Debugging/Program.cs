using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Debugging
{
    class Program
    {
        private static int State = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Programmers' Week 2021!");

            var intVariable = 10;
            var stringVariable = "string value";
            var jsonString = @"{'Email': 'ion.gritco @gmail.com','FirstName': 'FirstName1541575195020363','LastName': 'LastName1541575195020363'}";
            intVariable = 20;
            
            DoSomethingInAnotherMethod(intVariable);

            var listOfElements = new List<DebuggingClass>();
            for (int i = 0; i < 1000; i++)
            {
                listOfElements.Add(new DebuggingClass{Number = i, Title = $"Title {i}"});
            }

            var debuggingClass = new DebuggingClass();
            debuggingClass.Title = "value1";
            debuggingClass.Title = "value2";

            ChangeState();

            Console.WriteLine(ChangeState(ChangeState()));

            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            debuggingClass.Title = "Title after exception";

            Console.WriteLine("Finish him!");

            Console.ReadLine();
        }

        private static int ChangeState()
        {
            State++;
            return State;
        }

        private static int ChangeState(int i)
        {
            State += i;
            return State;
        }

        private static void DoSomethingInAnotherMethod(int input)
        {
            Console.WriteLine($"Another method {input}");
        }

        //[DebuggerDisplay("Object with {Title} {Number}")]
        private class DebuggingClass
        {
            public string Title { get; set; }

            public int Number { get; set; }
        }
    }
}
