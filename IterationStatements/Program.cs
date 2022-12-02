using System;
using System.Reflection.Metadata.Ecma335;

namespace IterationStatements
{
    public class Program
    {        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 
        // Only had to change the Increment to decrement, everything else was right. Yay!
        public static void ManyNums()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        // I got this one right! Yay!
        public static void TimesThree()
        {
        for (int w = 3; w <= 999; w+=3)
        {
            Console.WriteLine(w);
        }
}

        //Write a method to accept two integers as parameterss and check whether
        //they are equal or not
        // I needed help with calling this method. Forgot to input the arguement 
        public static void AreEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($" {a} and {b} are equal.");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal.");
            }
        }
        //Write a method to check whether a given number is even or odd
        // I was able to get this one without help :)
        public static string OddBall(int num)
        {
            return num % 2 == 0 ? "Even" : "Odd";
        }

        //Write a method to check whether a given number is positive or negative
        // Completed this one without help, too!
        public static void PosOrNeg()
        {
            int n;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
                       
            if (n == 0)
            {
                Console.WriteLine(n + " is zero.");
            }
            else if (n > 0)
            {
                Console.WriteLine(n + " is a positive number.");
            }
            else
            {
                Console.WriteLine(n + " is a negative number");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        // I needed help all the way through on this one
        public static void CanIVote()
        {
            Console.WriteLine("How old are you? Enter your age below.");
            var enterAge = int.TryParse(Console.ReadLine(), out int age);

            if (age >=18)
            {
                Console.WriteLine("Get out and vote, son!");
            }
            else
            {
                Console.WriteLine("Come back when you are older");
            }
        }

       

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        // I was able to figure this one out without help
        public static void OnTheRange()
        {
            Console.WriteLine("Is your number between 10 and -10?");
            Console.WriteLine("Enter a number: ");
            var result = int.Parse(Console.ReadLine());

            if (result >= -10 && result <= 10)
            {
                Console.WriteLine("This number is within range");
            }
            else
            {
                Console.WriteLine("This number is not in range.");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        // The firt time I ran this code it was not stopping at 12.
        // Went to lab and go some help to get through
        public static void MultiPass()
        {
            Console.WriteLine("Enter a number to see the multiplication table");
            int numb = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {numb} = {numb * i}");
            }
        }

        //Call the methods to test them in the Main method below
        public static void Main(string[] args)
        {

            ManyNums();
            TimesThree();
            AreEqual(9, 19);
            OddBall(76);
            PosOrNeg();
            CanIVote();
            MultiPass();
        }


    }
}

