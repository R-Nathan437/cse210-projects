using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.Write("Guess the Magic Number: ");
        string guess = Console.ReadLine();
        int magnum = int.Parse(guess);
        int count = 0;

        while (magnum != number)
        {
            count += 1;
            if (magnum < number)
            {
                Console.WriteLine("higher, try again:");
                guess = Console.ReadLine();
                magnum = int.Parse(guess);
            }
            else if (magnum > number)
            {
                Console.WriteLine("lower, try agian:");
                guess = Console.ReadLine();
                magnum =int.Parse(guess);
            }
        }
        Console.WriteLine("Correct!");
        Console.WriteLine($"Number of Guesses:{count}.");
    }
}