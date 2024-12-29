using System;
using System.Collections.Generic;


public class FibonacciSequence
{
    public void Fibonacci()
    {
        try
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine(0);
                }
                else if (n == 2)
                {
                    Console.WriteLine("0 1");
                }
                else if (n > 2)
                {
                    int first = 0, second = 1;
                    Console.Write("0 1 ");
                    for (int i = 3; i <= n; ++i)
                    {
                        int fibo = first + second;
                        first = second;
                        second = fibo;
                        Console.Write($"{second} ");
                    }
                    Console.WriteLine();
                }


            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}