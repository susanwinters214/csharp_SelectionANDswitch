using System;

namespace SelectionANDswitch
{
    internal class Program
    {
 
 
            static void Main(string[] args)
            {
                var r = new Random();  // set fav num to random so that game can be played multiple times
                var favNumber = r.Next(1, 1001);
                bool isWinner = false;

                do
                {
                    Console.WriteLine("Guess a number between 1-1000.");
                    int userInput = int.Parse(Console.ReadLine());

                    if (userInput == favNumber)
                    {
                        Console.WriteLine("You win!");
                        isWinner = true;
                    }
                    else if (userInput < favNumber)
                    {
                        Console.WriteLine("Too low! Guess again.");

                    }
                    else if (userInput > favNumber)
                    {
                        Console.WriteLine("Too high! Guess again");
                    }
                }
                while (!isWinner);

                Console.WriteLine($"The answer was {favNumber}!");


                //part 2:
                Console.WriteLine("What is your favorite subject?");

                string subject = Console.ReadLine();

                switch (subject.ToLower())
                {
                    case "math":
                        Console.WriteLine("I hate Math!");
                        break;
                    case "science":
                        Console.WriteLine("I love science!");
                        break;
                    case "pe":
                        Console.WriteLine("PE is the best!");
                        break;
                    case "history":
                        Console.WriteLine("History sucks!");
                        break;
                    case "english":
                        Console.WriteLine("English is boring!");
                        break;
                    default:
                        Console.WriteLine("I don't know that!");
                        break;


                }


            }


        }
    }