using System;

public class Prime
{
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public void prime()
    {
        try
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                if (IsPrime(num))
                {
                    Console.WriteLine($"{num} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{num} is not a prime number.");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}