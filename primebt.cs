using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Prime numbers between 1 and 1000:");

        for (int i = 2; i <= 1000; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.ReadLine(); // Pause to see the output
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
