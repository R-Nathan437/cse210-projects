using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string x = Console.ReadLine();
        int grade = int.Parse(x);
        int d = 60;
        int c = 70;
        int b = 80; 
        int a = 90;

        if (grade < d)
            {
                Console.Write("You have an F. ");
            }
        else if (grade < c)
            {
                Console.Write("You have an D. ");
            }
        else if (grade< b)
            {
                Console.Write("You have an C. ");
            }
        else if (grade < a)
            {
                Console.Write("You have an B. ");
            }
        else
            {
                Console.Write("You have an A. ");
            }
        if (grade < c)
            {
                Console.Write("You didn't quite pass, but you can take this knowlege and retake the class.");
            }
        else 
            {
                Console.WriteLine("You passed, congragulations!");
            }
    }
}