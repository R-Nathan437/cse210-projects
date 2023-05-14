using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Create aj list of numbers, type 0 to end");
        int newNumber = 1;
        while (newNumber != 0)
        {
            Console.Write("Enter one number: ");
            string response = Console.ReadLine();
            newNumber = int.Parse(response);

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        float avg = sum / numbers.Count;
        Console.WriteLine($"The average: {avg}");
        numbers.Sort();
        var x = numbers.Last();
        Console.WriteLine($"The max is: {x}");
    }
}