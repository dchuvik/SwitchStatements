using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your age");
            //var myAge = Convert.ToInt32(Console.ReadLine());
            //if (myAge >= 21)
            //    {   
            //    Console.WriteLine("you can drink wine");
            //    }
            //else if (myAge <= 3)
            //    {
            //        Console.WriteLine("You can drink a bottle.");
            //    }
            //else
            //    {
            //        Console.WriteLine("you can drink rootbeer");
            //    }

            //Console.WriteLine("what is your favorite car?");
            //string favCar = Console.ReadLine();

            //switch (favCar.ToLower())
            //{
            //    case "mustang":
            //        Console.WriteLine("Mustangs are cool.");
            //        break;
            //    case "lambo":
            //        Console.WriteLine("Lambo's are awesome.");
            //        break;
            //    case "tesla roadster":
            //    case "tesla":
            //        Console.WriteLine("Teslas are green!");
            //        break;
            //            case "corvette":
            //        Console.WriteLine("corvettes rock");
            //        break;
            //    default:
            //        Console.WriteLine("i dont know that car");
            //        break;


            //var r = new random();
            //var favnumber = r.next(1, 10);
            //console.writeline("guess my favorite number!")
            //var userinput = int.parse(console.readline());
            //if (userinput == 0)

            //var r = new Random();
            //var favNumber = r.Next(1, 10);
            //Console.WriteLine("guess my favorite number!");
            //var userInput = int.Parse(Console.ReadLine());

            //while (userInput < favNumber)
            //{
            //    Console.WriteLine("nope try again");
            //    break;
            //}
            //Console.WriteLine("That's right");
            //}

            Console.WriteLine("What is your favorite school subject?");
            var favSub = Console.ReadLine();
            switch (favSub.ToLower())
            {
                case "math":
                    Console.WriteLine("You can be a engineer!");
                    break;
                case "science":
                    Console.WriteLine("You can be a researcher!");
                    break;
                case "history":
                    Console.WriteLine("You can be an archeologist!");
                    break;
                case "art":
                    Console.WriteLine("You can be a painter");
                    break;
                case "gym":
                    Console.WriteLine("You can be an athlete");
                    break;
                case "english":
                    Console.WriteLine("You can be an author");
                    break;


            }
        }
    }
}
