using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string x = Console.ReadLine();
        int grade = int.Parse(x);
        string letter = "";
        if (grade < 60)
        {
            letter = "F";
        }
        else if (grade < 70)
        {
            letter = "D";
        }
        else if (grade < 80)
        {
            letter = "C";
        }
        else if (grade < 90)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }
        Console.Write($"You have an {letter}. ");
        if (grade < 70)
        {
            Console.Write("You didn't quite pass, but you can take this knowlege and retake the class.");
        }
        else 
        {
            Console.Write("You passed, congragulations!");
        }
    }
}