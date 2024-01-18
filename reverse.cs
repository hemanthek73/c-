using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine($"Reversed Number: {reversedNumber}");
    }

    static int ReverseNumber(int num)
    {
        int reversed = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        return reversed;
    }
}
