using System;
using System.Collections.Generic;


public class FactorialNumber
{
    public void Factorial()
    {
        try
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                int n = int.Parse(Console.ReadLine());
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("Factorial of " + n + " is: " + fact);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}