using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string x = Console.ReadLine();
        int number = int.Parse(x);
        int d = 60;
        int c = 70;
        int b = 80; 
        int a = 90;

        if (x < d)
            {
                Console.WriteLine("You have an F");
            }
        else if (x < c)
            {
                Console.WriteLine("You have an D");
            }
        else if (x < b)
            {
                Console.WriteLine("You have an c");
            }
        else if (x < a)
            {
                Console.WriteLine("You have an B");
            }
        else
            {
                Console.WriteLine("You have an A");
            }
        if (x < c)
            {
                Console.WriteLine("You didn't quite pass, but you can take this knowlege and retake the class");
            }
        else 
            {
                Console.WriteLine("You passed, Congragulations");
            }
    }
}