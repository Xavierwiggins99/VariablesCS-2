using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");

            int numberOfCupsOfCoffee = 3;

            string fullname = "Xavier Wiggins";

            DateTime today = System.DateTime.Now;

            Console.WriteLine(numberOfCupsOfCoffee + " " + fullname + " " + today);

            string username = Console.ReadLine();

            if (username == "Alice")
            { username = "bob"; }

            Console.WriteLine("Hello, " + username + "!");

            Console.Write("Enter a number: ");
            string firstNumberAsString = Console.ReadLine();
            Console.Write("Enter another number: ");
            string secondNumberAsString = Console.ReadLine();

            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);


            double sum = firstOperand + secondOperand;
            double difference = firstOperand - secondOperand;
            double product = firstOperand * secondOperand;
            double quotient = firstOperand / secondOperand;
            double remainder = firstOperand % secondOperand;

            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("difference : " + difference);
            Console.WriteLine("product : " + product);
            Console.WriteLine("quotient : " + quotient);
            Console.WriteLine("remainder : " + remainder);








        }
    }
}

