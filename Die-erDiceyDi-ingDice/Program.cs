using System;

namespace DieerDiceyDiingDice
{
    internal class Program
    {
        // Making methods to easily acess the same code without having to write it over and over.
        static void Welcome()
        {
            Console.WriteLine("Welcome to this SUPER AMAZING and INCREDIBLE random dice roll\nmachine that will " +
                "bring you the ULTIMATE rolling EXPERIENCE!!!!!!\n" +
                "Brace yourself for one heck of a ride, and when you are ready...\nPRESS <SPACE> TO ROLL!!!!!!!!");
        }
        static void Toss()
        {
            Random rnd = new Random();
            int diceNum = rnd.Next(1, 7);

            if (diceNum == 1)
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You got an ace.");
            }
            else if (diceNum == 2)
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("You got a deuce.");
            }
            else if (diceNum == 3)
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You got a trey.");
            }
            else if (diceNum == 4)
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You got a cater.");
            }
            else if (diceNum == 5)
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You got a cinque.");
            }
            else if (diceNum == 6)
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You got a sice.");
            }
            else
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You got a, uh, seven.");
            }

        }
        static void Main(string[] args)
        {
            Welcome();
        while (true)
            {
                var keyPress = Console.ReadKey(false).Key;
                switch (keyPress)
                {
                    case ConsoleKey.Spacebar:
                        Toss();
                        break;
                    case ConsoleKey.Escape:
                        return;

                }
            }
        }
    }
}