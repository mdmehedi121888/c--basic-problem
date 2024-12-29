using System;
using System.Collections.Generic;


public class MaximumMinimum
{
    public void MaximumMinimumValue()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter the input array: ");
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                List<int> numbers = new List<int>();

                foreach (string numberStr in inputArray)
                {
                    numbers.Add(int.Parse(numberStr));
                }
                int mx = numbers[0], mn = numbers[0];
                foreach (int number in numbers)
                {
                    if (number > mx)
                        mx = number;
                    if (number < mn)
                        mn = number;
                }
                Console.WriteLine($"Maximum number: {mx} and Minimum number: {mn}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }
    }
}