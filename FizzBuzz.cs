using System;

class Program
{
    static void Main()
    {
        int n = 15; // You can change this value to any positive integer
        FizzBuzz(n);
    }

    static void FizzBuzz(int n)
    {
        // Loop from 1 to n (inclusive)
        for (int i = 1; i <= n; i++)
        {
            // Check if the number is divisible by both 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz"); // Print "FizzBuzz" for multiples of both 3 and 5
            }
            // Check if the number is divisible by 3
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz"); // Print "Fizz" for multiples of 3
            }
            // Check if the number is divisible by 5
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz"); // Print "Buzz" for multiples of 5
            }
            else
            {
                Console.WriteLine(i); // Print the number if it's not divisible by 3 or 5
            }
        }
    }
}
