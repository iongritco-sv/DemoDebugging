namespace Debugging
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    class Program
    {
        private static int State = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var localIntVariable = 10;
            var localStringVariable = "String variables";
            var jsonString = @"{'Email': 'ion.gritco @gmail.com','FirstName': 'FirstName1541575195020363','LastName': 'LastName1541575195020363'}";
            localIntVariable = 20;
            DoSomethingInAnotherMethod(localIntVariable);

            var listOfElements = new List<MyClass>();
            for (int i = 0; i < 1000; i++)
            {
                listOfElements.Add(new MyClass{Number = i, Title = $"Title {i}"});
            }

            var myClass = new MyClass();
            myClass.Title = "prop1";
            myClass.Title = "prop2";

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

            myClass.Title = "Titlu dupa exceptie";

            Console.WriteLine("dada");

            Console.ReadLine();
        }

        private static int ChangeState()
        {
            State++;
            return State;
        }

        private static int ChangeState(int i)
        {
            State = State + i;
            return State;
        }

        private static void DoSomethingInAnotherMethod(int input)
        {
            Console.WriteLine($"Another method {input}");
        }

        [DebuggerDisplay("Obiect cu titlu {Title} {Number}")]
        private class MyClass
        {
            public string Title { get; set; }

            public int Number { get; set; }
        }
    }
}
