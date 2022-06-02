using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if statement practice
            //var r = new Random();
            //var favNumber = r.Next(1, 1000);
            //int userInput;

            //do
            //{
            //    Console.WriteLine("guess my favorite number!");
            //    userInput = int.Parse(Console.ReadLine());
            //    if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too high");
            //    }
            //    else if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"You guessed it!!!");
            //    }
            //} while (favNumber != userInput);



            Console.WriteLine("What is your favorite school subject?");
            var favSub = Console.ReadLine();
            switch (favSub.ToLower())
            {
                case "math":
                case "mathamatics":
                    Console.WriteLine("You can be a engineer!");
                    break;
                case "science":
                case "physics":
                case "biology":
                case "chemistry":
                    Console.WriteLine("You can be a researcher!");
                    break;
                case "history":
                    Console.WriteLine("You can be an archeologist!");
                    break;
                case "art":
                    Console.WriteLine("You can be a painter");
                    break;
                case "gym":
                case "PE":
                    Console.WriteLine("You can be an athlete");
                    break;
                case "english":
                    Console.WriteLine("You can be an author");
                    break;
                default:
                    Console.WriteLine("I don't know that subject");
                    break;


            }
        }
    }
}

