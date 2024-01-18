using System;
class Program {
    static void Main(string[] args)
    {
        int  originalNum, remainder, n = 0; double result = 0;


                    Console.WriteLine("the armstrong number from 1 to 1000 are:");
       
        

        for (int i = 1; i <= 1000; i++)
        {
            originalNum = i;
            n = 0;
            result = 0;
            for (originalNum = i; originalNum != 0; ++n)
            {
                originalNum /= 10;
            }

            for (originalNum = i; originalNum != 0; originalNum /= 10)
            {
                remainder = originalNum % 10;

                // store the sum of the power of individual digits in result
                result += Math.Pow(remainder, n);
            }
            // if num is equal to result, the number is an Armstrong number
            if ((int)result == i)
                Console.WriteLine("{0} is an Armstrong number.", i);

        }
        Console.ReadKey();
    }
}