using ChainOfWorkDesignPatternConsoleApp1.Entities;
using ChainOfWorkDesignPatternConsoleApp1.Handlers;
using System;

namespace ChainOfWorkDesignPatternConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Work!");
            ///1.Promotes decoupling of Request from Handler object
            ///2.When a requet belongs to several different categories,so.
            ///it will either process the request or send to the next handler.
            
            ///The below example demonstrates validating object in multiple steps
            Person person = new Person()
            {
                Name = "Tanuja",
                Age = 30,
                Income = 200
            };

            Request request = new Request() { Data = person };
            NameHandler nameHandler = new NameHandler();
            AgeHandler ageHandler = new AgeHandler();
            IncomeHandler incomeHandler = new IncomeHandler();

            nameHandler.SetNextHandler(ageHandler);
            ageHandler.SetNextHandler(incomeHandler);

            nameHandler.Process(request);

            foreach (string item in request.ValidationMessages)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
